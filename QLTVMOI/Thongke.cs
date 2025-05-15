using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;

namespace QLTVMOI
{
    public partial class Thongke : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private Thuvien thuvienForm;
        private Timer panelSlideTimer;
        private bool isSlidingDown = false; // Trạng thái trượt xuống
        private Panel targetPanel = null; // Panel mục tiêu để trượt
        private bool sach;
        private bool muontra;
        private bool report;
        private bool isMaximized = false;
        public Thongke()
        {
            InitializeComponent();
            InitializePanelSlide();
            mns_congcu.Renderer = new MyRenderer();
            cbb_dieukienloc.Visible = false;
            RoundForm(20);
            RoundControl(dtp_thang, 10);
            RoundControl(btn_sach, 10);
            RoundControl(btn_thoat, 10);
            RoundControl(btn_an, 10);
            RoundControl(btn_muontra, 10);
            RoundControl(btn_dongldl, 10);
            RoundControl(btn_dongtktq, 10);
            RoundControl(mns_congcu, 10);
            RoundControl(txt_muontrongthang, 10);
            RoundControl(txt_tongdausach, 10);
            RoundControl(txt_tongcuonsach, 10);
            RoundControl(txt_tongsachdangmuon, 10);
            RoundControl(txt_tongsachconlai, 10);
            RoundControl(txt_tongluotmuon, 10);
            RoundControl(btn_report, 10);
            RoundControl(btn_reportmuontra, 10);
            RoundControl(btn_reportsach, 10);
            loaddulieu(dgv_hienthi);
        }
        private void loaddulieu(DataGridView dgv)
        {
            Connection conn = new Connection();
            string sql = "";
            if (dgv == dgv_hienthi)
            {
                sql = "SELECT idSach, TenSach, TheLoai, Tentacgia, NhaXuatBan, NamXuatBan, SoLuong FROM Sach;";
            }
            else if (dgv == dgv_danhsachmuontra)
            {
                sql = "SELECT pm.idPhieuMuon, pm.TenDocGia, pm.SDT, pm.DiaChi, pm.NgayMuon, pm.NgayTra, pm.TinhTrangGiaoDich, s.idSach, s.TenSach " +
                              "FROM PhieuMuon pm " +
                              "INNER JOIN ChiTietPhieuMuon ctp ON pm.idPhieuMuon = ctp.idPhieuMuon " +
                              "INNER JOIN Sach s ON ctp.idSach = s.idSach " +
                              "ORDER BY pm.idPhieuMuon;";
            }
            if (conn.moKetnoi())
            {
                try
                {
                    SqlDataReader rdr = conn.truyvan(sql);
                    DataTable dt = new DataTable();
                    dt.Load(rdr);
                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    rdr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
                finally
                {
                    conn.dongKetnoi();
                }
            }
            else
            {
                MessageBox.Show("Không thể kết nối cơ sở dữ liệu!");
            }
        }
        private void InitializePanelSlide()
        {
            panelSlideTimer = new Timer();
            panelSlideTimer.Interval = 15; // Tần suất cập nhật
            panelSlideTimer.Tick += PanelSlideTimer_Tick; // Gắn sự kiện Tick
        }
        private void PanelSlideTimer_Tick(object sender, EventArgs e)
        {
            if (isSlidingDown)
            {
                // Trượt xuống
                if (targetPanel.Height < targetPanel.MaximumSize.Height)
                {
                    targetPanel.Height += 10; // Tăng chiều cao
                }
                else
                {
                    panelSlideTimer.Stop(); // Dừng khi đạt chiều cao tối đa
                }
            }
            else
            {
                // Trượt lên
                if (targetPanel.Height > targetPanel.MinimumSize.Height)
                {
                    targetPanel.Height -= 10; // Giảm chiều cao
                }
                else
                {
                    panelSlideTimer.Stop(); // Dừng khi đạt chiều cao tối thiểu
                }
            }
        }
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

        // Method to round the corners of the form
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
        private void quanLyThưViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (thuvienForm == null || thuvienForm.IsDisposed)
            {
                thuvienForm = new Thuvien();
            }
            thuvienForm.Show();
            thuvienForm.HandleMenuStripAction("quanLyThuvien");
            this.Hide();
        }

        private void quanLySachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (thuvienForm == null || thuvienForm.IsDisposed)
            {
                thuvienForm = new Thuvien();
            }

            thuvienForm.Show();
            thuvienForm.HandleMenuStripAction("quanLySach");
            this.Hide();
        }

        private int LayGiaTriTuSQL(string sql)
        {
            int result = 0;
            Connection conn = new Connection();
            if (conn.moKetnoi())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn.conn);
                    object value = cmd.ExecuteScalar();
                    if (value != null && value != DBNull.Value)
                    {
                        result = Convert.ToInt32(value);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.dongKetnoi();
                }
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        private void Thongke_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qltvDataSet2.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.qltvDataSet2.Sach);
            string sqlTongsoluotmuon = "select COUNT(idPhieumuon) from Phieumuon";
            string sqlTongdausach = "SELECT COUNT(*) FROM Sach";
            // Lấy tổng số cuốn sách
            string sqlTongSoSach = "SELECT SUM(SoLuong) FROM Sach";
            // Lấy tổng số sách đang mượn
            string sqlSachDangMuon = "SELECT COUNT(*) FROM ChiTietPhieuMuon ct " +
                                     "INNER JOIN PhieuMuon pm ON ct.idPhieuMuon = pm.idPhieuMuon " +
                                     "WHERE pm.TinhTrangGiaoDich = N'Đang mượn'";
            // Lấy tháng và năm từ DateTimePicker
            int selectedMonth = dtp_thang.Value.Month;
            int selectedYear = dtp_thang.Value.Year;

            // Câu lệnh SQL để đếm số lượng người mượn trong tháng
            string sql = "SELECT COUNT(DISTINCT TenDocGia) " +
                         "FROM PhieuMuon " +
                         "WHERE MONTH(NgayMuon) = @Month AND YEAR(NgayMuon) = @Year";

            int soNguoiMuon = LaySoNguoiMuon(sql, selectedMonth, selectedYear);
            int tongSoSach = LayGiaTriTuSQL(sqlTongSoSach);
            int sachDangMuon = LayGiaTriTuSQL(sqlSachDangMuon);
            int tongDausach = LayGiaTriTuSQL(sqlTongdausach);
            int tongLuotMuon = LayGiaTriTuSQL(sqlTongsoluotmuon);

            // Tính số sách còn lại
            int sachConLai = tongSoSach - sachDangMuon;

            // Gán giá trị vào các Label
            txt_muontrongthang.Text = "Số người mượn trong tháng: " + Convert.ToString(soNguoiMuon);
            txt_tongdausach.Text = "Tổng đầu sách.: " + tongDausach;
            txt_tongcuonsach.Text = "Tổng số sách: " + tongSoSach;
            txt_tongsachdangmuon.Text = "Tổng sách đang mượn: " + sachDangMuon;
            txt_tongsachconlai.Text = "Số sách còn lại: " + sachConLai;
            txt_tongluotmuon.Text = "Tổng lượt mượn: " + tongLuotMuon;
            rdb_sach_CheckedChanged(sender, e);
        }
        private void caiĐatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_an_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Thongke_Shown(object sender, FormClosedEventArgs e)
        {
            // Đảm bảo thực hiện sau khi form hiển thị xong
            this.BeginInvoke(new Action(() =>
            {
                this.Bounds = Screen.FromHandle(this.Handle).WorkingArea;
            }));
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Dangnhap dn = new Dangnhap();
            dn.Show();
            this.Hide();
        }

        private void btn_dongldl_Click(object sender, EventArgs e)
        {
            pnl_locdulieu.Visible = false;
        }

        private void btn_dongtktq_Click(object sender, EventArgs e)
        {
            pnl_thongketongquan.Visible = false;
        }

        private void mươnSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (thuvienForm == null || thuvienForm.IsDisposed)
            {
                thuvienForm = new Thuvien();
            }

            thuvienForm.Show();
            thuvienForm.HandleMenuStripAction("muonSach");
            this.Hide();
        }

        private void traSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (thuvienForm == null || thuvienForm.IsDisposed)
            {
                thuvienForm = new Thuvien();
            }

            thuvienForm.Show();
            thuvienForm.HandleMenuStripAction("traSach");
            this.Hide();
        }
        private int LaySoNguoiMuon(string sql, int month, int year)
        {
            int result = 0;
            Connection conn = new Connection();
            if (conn.moKetnoi())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn.conn);
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);

                    object value = cmd.ExecuteScalar();
                    if (value != null && value != DBNull.Value)
                    {
                        result = Convert.ToInt32(value);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.dongKetnoi();
                }
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        private void dtp_thang_ValueChanged(object sender, EventArgs e)
        {
            // Lấy tháng và năm từ DateTimePicker
            int selectedMonth = dtp_thang.Value.Month;
            int selectedYear = dtp_thang.Value.Year;

            // Câu lệnh SQL để đếm số lượng người mượn trong tháng
            string sql = "SELECT COUNT(DISTINCT TenDocGia) " +
                         "FROM PhieuMuon " +
                         "WHERE MONTH(NgayMuon) = @Month AND YEAR(NgayMuon) = @Year";

            // Thực hiện truy vấn
            int soNguoiMuon = LaySoNguoiMuon(sql, selectedMonth, selectedYear);

            // Hiển thị kết quả
            txt_muontrongthang.Text = "Số người mượn trong tháng: " + Convert.ToString(soNguoiMuon);
        }

        private void locDưLiêuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pnl_locdulieu.Visible)
            {
                pnl_locdulieu.Visible = true;
            }
        }

        private void thôngKêTôngQuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pnl_thongketongquan.Visible)
            {
                pnl_thongketongquan.Visible = true;
            }
        }

        private void btn_muontra_Click(object sender, EventArgs e)
        {
            muontra = !muontra;
            timerMuontra.Start(); // Bắt đầu bộ đếm thời gian
        }

        private void timerMuontra_Tick(object sender, EventArgs e)
        {
            if (muontra && pnl_muontra.Height < pnl_muontra.MaximumSize.Height)
            {
                pnl_muontra.Height += 10; // Tăng chiều cao
            }
            else if (!muontra && pnl_muontra.Height > pnl_muontra.MinimumSize.Height)
            {
                pnl_muontra.Height -= 10; // Giảm chiều cao
            }
        }

        private void btn_sach_Click(object sender, EventArgs e)
        {
            sach = !sach;
            timerSach.Start(); // Bắt đầu bộ đếm thời gian
        }

        private void timerSach_Tick(object sender, EventArgs e)
        {
            if (sach && pnl_sach.Height < pnl_sach.MaximumSize.Height)
            {
                pnl_sach.Height += 10; // Tăng chiều cao
            }
            else if (!sach && pnl_sach.Height > pnl_sach.MinimumSize.Height)
            {
                pnl_sach.Height -= 10; // Giảm chiều cao
            }
        }

        private void rdb_sach_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_sach.Checked)
            {
                if(pnl_muontra.Height == pnl_muontra.MaximumSize.Height)
                {
                    btn_muontra_Click(sender, e);
                }
                btn_muontra.Enabled = false;
                btn_sach.Enabled = true;
                dgv_hienthi.Visible = true;
                dgv_danhsachmuontra.Visible = false;
                if(cbb_sach.SelectedItem != null)
                {
                    if (cbb_sach.SelectedItem.ToString() == "Theo số lượng")
                    {
                        Locdulieu(cbb_sach.SelectedItem.ToString(), dgv_hienthi);
                    }
                    else
                    {
                        Locdulieu(cbb_dieukienloc.SelectedItem.ToString(), dgv_hienthi);
                    }
                }
                else
                {
                    loaddulieu(dgv_hienthi);
                    cbb_dieukienloc.Visible = true;
                }
            }
            else
            {
                if (pnl_sach.Height == pnl_sach.MaximumSize.Height)
                {
                    btn_sach_Click(sender, e);
                }
                btn_muontra.Enabled = true;
                btn_sach.Enabled = false;
                dgv_hienthi.Visible = false;
                dgv_danhsachmuontra.Visible = true;
                if (cbb_muontra.SelectedItem != null)
                {
                    cbb_muontra_SelectionChangeCommitted(sender, e);
                }
                else
                {
                    loaddulieu(dgv_danhsachmuontra);
                }
            }
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            report = !report;
            timerReport.Start(); // Bắt đầu bộ đếm thời gian
        }

        private void timerReport_Tick(object sender, EventArgs e)
        {
            if(report && pnl_report.Height < pnl_report.MaximumSize.Height)
            {
                pnl_report.Height += 10; // Tăng chiều cao
            }
            else if (!report && pnl_report.Height > pnl_report.MinimumSize.Height)
            {
                pnl_report.Height -= 10; // Giảm chiều cao
            }
        }

        private void btn_reportsach_Click(object sender, EventArgs e)
        {
            Report rp = new Report("dssach");
            rp.ShowDialog();
        }

        private void btn_reportmuontra_Click(object sender, EventArgs e)
        {
            Report rp = new Report("dsmuontra");
            rp.ShowDialog();
        }

        private void pnl_congcu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void GanItemcbb(string selectedValue) 
        {
            string sql = "";
            if (selectedValue == "Theo thể loại")
            {
                sql = "SELECT DISTINCT Theloai FROM Sach";
            }
            else if (selectedValue == "Theo tác giả")
            {
                sql = "SELECT DISTINCT Tentacgia FROM Sach";
            }
            else if (selectedValue == "Theo nhà xuất bản")
            {
                sql = "SELECT DISTINCT Nhaxuatban FROM Sach";
            }
            else if (selectedValue == "Theo năm xuất bản")
            {
                sql = "SELECT DISTINCT Namxuatban FROM Sach";
            }
            Connection conn = new Connection();
            if (conn.moKetnoi())
            {
                try
                {
                    SqlDataReader rdr = conn.truyvan(sql);
                    // Xóa các mục hiện tại trong ComboBox
                    cbb_dieukienloc.Items.Clear();
                    // Duyệt qua kết quả và thêm vào ComboBox
                    while (rdr.Read())
                    {
                        cbb_dieukienloc.Items.Add(rdr[0].ToString());
                    }
                    rdr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu gán: " + ex.Message);
                }
                finally
                {
                    conn.dongKetnoi();
                }
            }
            else
            {
                MessageBox.Show("Không thể kết nối cơ sở dữ liệu!");
            }

        }
        
        private void Locdulieu(string SelectedValue, DataGridView dgv)
        {
            string selectedValue = "";
            if (dgv == dgv_hienthi)
            {
                selectedValue = cbb_sach.SelectedItem?.ToString() ?? "";  
            }
            string sql = "";
            string tencolumn = "";
            if (SelectedValue == "Theo số lượng")
            {
                sql = "select * from Sach order by Soluong asc";
                cbb_dieukienloc.Items.Clear();
            }
            else if (selectedValue == "Theo thể loại")
            {
                tencolumn = "Theloai";
            }
            else if (selectedValue == "Theo tác giả")
            {
                tencolumn = "Tentacgia";
            }
            else if (selectedValue == "Theo nhà xuất bản")
            {
                tencolumn = "Nhaxuatban";
            }
            else if (selectedValue == "Theo năm xuất bản")
            {
                tencolumn = "Namxuatban";
            }
            else if(SelectedValue == "Đang mượn" || SelectedValue == "Đã trả")
            {
                tencolumn = "TinhTrangGiaoDich";
            }

            if (SelectedValue == "Người mượn nhiều nhất")
            {
                sql = "SELECT TOP 1 WITH TIES pm.TenDocGia, pm.SDT, pm.DiaChi, COUNT(ct.idSach) AS SoLuong " +
                       "FROM PhieuMuon pm " +
                       "JOIN ChiTietPhieuMuon ct ON pm.idPhieuMuon = ct.idPhieuMuon " +
                       "GROUP BY pm.TenDocGia, pm.SDT, pm.DiaChi " +
                       "ORDER BY SoLuong DESC ";
            }
            else if (SelectedValue == "Đang mượn" || SelectedValue == "Đã trả")
            {
                sql = "SELECT pm.idPhieuMuon, pm.TenDocGia, pm.SDT, pm.DiaChi, pm.NgayMuon, pm.NgayTra, pm.TinhTrangGiaoDich, s.Tensach " +
                    "FROM PhieuMuon pm " +
                    "INNER JOIN ChiTietPhieuMuon ctp ON pm.idPhieuMuon = ctp.idPhieuMuon " +
                    "INNER JOIN Sach s ON ctp.idSach = s.idSach " +
                    "WHERE pm.TinhTrangGiaoDich = N'" + SelectedValue.Trim() + "' " +
                    "ORDER BY pm.idPhieuMuon;";
            }
            else if(!string.IsNullOrEmpty(tencolumn)) 
            {
                sql = "SELECT * FROM Sach WHERE " + tencolumn + " = N'" + SelectedValue + "'";
            }

            Connection conn = new Connection();
            if (conn.moKetnoi())
            {
                try
                {
                    SqlDataReader rdr = conn.truyvan(sql);
                    DataTable dt = new DataTable();
                    dt.Load(rdr);
                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    rdr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu lọc: " + ex.Message);
                }
                finally
                {
                    conn.dongKetnoi();
                }
            }
            else
            {
                MessageBox.Show("Không thể kết nối cơ sở dữ liệu!");
            }

        }
        private void cbb_sach_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedValue = cbb_sach.SelectedItem.ToString();
            if (selectedValue == "Theo số lượng")
            {
                Locdulieu(selectedValue, dgv_hienthi);
            }
            else
            {
                GanItemcbb(selectedValue);
            }
        }

        private void cbb_dieukienloc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string SelectedValue = cbb_dieukienloc.SelectedItem.ToString();
            Locdulieu(SelectedValue, dgv_hienthi);
        }

        private void cbb_muontra_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedValue = cbb_muontra.SelectedItem.ToString();
            if(selectedValue == "Người mượn nhiều nhất")
            {
                cln_mapm.Visible = false;
                cln_tinhtrang.Visible = false;
                cln_ngaymuon.Visible = false;
                cln_ngaytra.Visible = false;
                cln_tensachmt.Visible = false;
                cln_soluongmt.Visible = true;
            }
            else
            {
                cln_mapm.Visible = true;
                cln_tinhtrang.Visible = true;
                cln_ngaymuon.Visible = true;
                cln_ngaytra.Visible = true;
                cln_tensachmt.Visible = true;
                cln_soluongmt.Visible = false;
            }
            Locdulieu(selectedValue, dgv_danhsachmuontra);
        }

        private void chinhSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string chinhSach = @"
Chính sách thư viện:
1. Chính sách mượn sách:
   - Mỗi người dùng được mượn tối đa 5 cuốn sách trong 14 ngày.
   - Phí phạt: 5.000 VNĐ/ngày nếu trả sách trễ hạn.

2. Chính sách trả sách:
   - Sách phải được trả đúng hạn và trong tình trạng nguyên vẹn.
   - Người dùng chịu trách nhiệm nếu sách bị hư hỏng hoặc mất.

3. Chính sách sử dụng tài liệu:
   - Không được sao chép hoặc sử dụng tài liệu trái phép.
   - Tài liệu tham khảo chỉ được sử dụng tại chỗ.

4. Chính sách thành viên:
   - Người dùng cần đăng ký thành viên để sử dụng dịch vụ.
   - Thành viên phải cung cấp thông tin chính xác và cập nhật.

5. Chính sách bảo mật thông tin:
   - Thư viện cam kết bảo mật thông tin cá nhân của người dùng.
    - Thông tin cá nhân sẽ không được chia sẻ cho bên thứ ba mà không có sự đồng ý của người dùng.
6. Chính sách hỗ trợ:
    - Thư viện cung cấp dịch vụ hỗ trợ người dùng trong việc tìm kiếm tài liệu.
    - Người dùng có thể liên hệ với nhân viên thư viện để được hỗ trợ thêm.
";
            MessageBox.Show(chinhSach, "Chính sách thư viện", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangnhap dn = new Dangnhap();
            dn.Show();
            this.Hide();
        }
    }
}
