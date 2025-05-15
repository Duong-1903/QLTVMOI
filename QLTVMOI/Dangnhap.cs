
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVMOI
{
    public partial class Dangnhap : Form
    {
        private Timer timer;
        private double opacity = 0.0; // Độ mờ ban đầu
        private int targetY; // Vị trí Y đích (giữa form)
        private int currentY; // Vị trí Y hiện tại
        private bool dragging = false; // Biến để kiểm tra xem đang kéo form hay không
        private Point dragCursorPoint; // Điểm chuột khi bắt đầu kéo
        private Point dragFormPoint; // Điểm form khi bắt đầu kéo
        private PlaceholderTextBox textbox = new PlaceholderTextBox();
        int alpha = 0;
        public Dangnhap()
        {
            InitializeComponent();
            RoundPanel(pnl_dangnhap, 20);
            RoundForm(20);

            // Apply corner rounding to controls
            RoundControl(btn_dangnhap, 10);
            RoundControl(txt_matkhau, 10);
            RoundControl(txt_taikhoan, 10);
            RoundControl(btn_thoat, 10);
            RoundControl(btn_an, 10);
            textbox.SetPlaceholder(txt_taikhoan, "Tài khoản");
            textbox.SetPlaceholder(txt_matkhau, "Mật khẩu");
            int startY = (this.ClientSize.Height * 3 / 4) - (pnl_dangnhap.Height / 2); // Đặt panel tại height/4 từ dưới lên
            if (startY > this.ClientSize.Height - pnl_dangnhap.Height) // Đảm bảo không ra ngoài form
            {
                startY = this.ClientSize.Height - pnl_dangnhap.Height;
            }
            pnl_dangnhap.Location = new Point((this.ClientSize.Width - pnl_dangnhap.Width) / 2, startY);
            // Vị trí đích (giữa form theo chiều dọc)
            targetY = (this.ClientSize.Height - pnl_dangnhap.Height) / 2;
            currentY = startY;
            timer = new Timer();
            timer.Interval = 10; // Thời gian mỗi lần tick (ms)
            timer.Tick += Timer_Tick;

            // Bắt đầu animation khi form load
            this.Load += (s, e) => timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Tăng độ mờ dần
            opacity += 0.05;
            if (opacity > 1.0) opacity = 1.0;

            // Di chuyển panel lên
            currentY -= 3; // Tốc độ di chuyển
            if (currentY <= targetY)
            {
                currentY = targetY; // Đảm bảo không vượt quá vị trí đích
                if (opacity >= 1.0) timer.Stop(); // Dừng khi đến vị trí và fade-in hoàn tất
            }

            // Cập nhật vị trí
            pnl_dangnhap.Location = new Point((this.ClientSize.Width - pnl_dangnhap.Width) / 2, currentY);
            pnl_dangnhap.Invalidate(); // Yêu cầu vẽ lại để áp dụng độ mờ
        }

        // bo tròn các góc của panel 
        private void RoundPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel.Region = new Region(path);
        }

        // bo tròn các góc của form
        private void RoundForm(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);
        }

        // Method to round the corners of a control
        private void RoundControl(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            control.Region = new Region(path);
        }
        private void btn_an_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ShakeControl(Control control)
        {
            Timer shakeTimer = new Timer();
            int shakeCount = 0;
            int originalX = control.Location.X;
            int offset = 3; // Độ lệch trái phải

            shakeTimer.Interval = 50; // Tốc độ rung
            shakeTimer.Tick += (s, e) =>
            {
                int direction = (shakeCount % 2 == 0) ? offset : -offset;
                control.Location = new Point(originalX + direction, control.Location.Y);
                shakeCount++;

                if (shakeCount > 6) // Rung 3 lần (6 bước)
                {
                    shakeTimer.Stop();
                    shakeTimer.Dispose();
                    control.Location = new Point(originalX, control.Location.Y); // Trả về vị trí ban đầu
                }
            };
            shakeTimer.Start();
        }
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            string username = txt_taikhoan.Text.Trim();
            string password = txt_matkhau.Text.Trim();

            // Kiểm tra nếu thông tin bị bỏ trống
            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password))
            {
                ShakeControl(txt_taikhoan);
                ShakeControl(txt_matkhau);
                return;
            }
            else if (string.IsNullOrWhiteSpace(username))
            {
                ShakeControl(txt_taikhoan);
                return;
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                ShakeControl(txt_matkhau);
                return;
            }

            try
            {
                Connection conn = new Connection();
                if (conn.moKetnoi())
                {
                    // Câu lệnh SQL kiểm tra thông tin đăng nhập
                    string sql = "SELECT COUNT(*) FROM Taikhoan WHERE tenTaikhoan = @username AND matKhau = @password";
                    using (SqlCommand cmd = new SqlCommand(sql, conn.conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        // Thực thi câu lệnh SQL
                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            // Đăng nhập thành công
                            pnl_dangnhap.Visible = false; // Ẩn panel đăng nhập

                            Thuvien thuvien = new Thuvien();
                            thuvien.Show();
                            this.Hide();
                        }
                        else
                            // Đăng nhập thất bại
                            ShakeControl(pnl_dangnhap); // Rung panel đăng nhập
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_thoat_Leave(object sender, EventArgs e)
        {
            btn_an.BackColor = Color.FromArgb(30, 30, 30); 
        }

        private void btn_thoat_Enter(object sender, EventArgs e)
        {
            btn_thoat.BackColor = Color.Red;
        }

        private void pnl_dangnhap_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path;
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, pnl_dangnhap.Width - 1, pnl_dangnhap.Height - 1);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Tạo shadow trắng mờ phía dưới
            using (path = new GraphicsPath())
            {
                Rectangle shadowRect = new Rectangle(5, pnl_dangnhap.Height - 20, pnl_dangnhap.Width - 1, 30);
                path.AddEllipse(shadowRect);
                using (PathGradientBrush brush = new PathGradientBrush(path))
                {
                    brush.CenterColor = Color.FromArgb(60, Color.White);
                    brush.SurroundColors = new[] { Color.Transparent };
                    g.FillPath(brush, path);
                }
            }
        }

        private void Dangnhap_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
            }
        }

        private void Dangnhap_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Dangnhap_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }
    }
}
