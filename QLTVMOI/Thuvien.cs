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

namespace QLTVMOI
{
    public partial class Thuvien : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private List<int> dsidsachmuon = new List<int>();
        private List<int> selectedBooks = new List<int>(); // Lưu trữ idSach đã được chọn
        private PlaceholderTextBox textbox = new PlaceholderTextBox();
        private bool isMaximized = false;
        public Thuvien()
        {
            InitializeComponent();
            mnt_congcu.Renderer = new MyRenderer();
            lbl_hienloi.Text = "";
            pnl_muonsach.Location = pnl_quanlysach.Location;
            pnl_trasach.Location = pnl_quanlysach.Location;
            pnl_quanlythuvien.Location = pnl_quanlysach.Location;
            textbox.SetPlaceholder(txt_tim, "tìm kiếm");
            textbox.SetPlaceholder(txt_tentacgia, "Tên tác giả");
            textbox.SetPlaceholder(txt_theloai, "Thể loại");
            textbox.SetPlaceholder(txt_tensach, "Tên sách");
            textbox.SetPlaceholder(txt_nhaxuatban, "Nhà xuất bản");
            textbox.SetPlaceholder(txt_namxuatban, "Năm xuất bản");
            textbox.SetPlaceholder(txt_soluong, "Số lượng");
            textbox.SetPlaceholder(txt_tennguoimuon, "Tên người mượn");
            textbox.SetPlaceholder(txt_sdt, "Số điện thoại");
            textbox.SetPlaceholder(txt_diachi, "Địa chỉ");
            textbox.SetPlaceholder(txt_diachinm, "Địa chỉ");
            textbox.SetPlaceholder(txt_ngaymuonsach, "Ngày mượn sách");
            textbox.SetPlaceholder(txt_ngaytrasach, "Ngày trả sách");
            textbox.SetPlaceholder(txt_SoDT, "Số điện thoại");
            textbox.SetPlaceholder(txt_nguoimuon, "Tên người mượn");
            RoundForm(30);
            RoundControl(mnt_congcu, 10);
            RoundControl(btn_them, 10);
            RoundControl(btn_xoa, 10);
            RoundControl(btn_chinhsua, 10);
            RoundControl(btn_xacnhanmuon, 10);
            RoundControl(btn_xacnhantra, 10);
            RoundControl(btn_thoat, 10);
            RoundControl(btn_an, 10);
            RoundControl(btn_lichsumuon, 10);
            RoundControl(btn_chonsach, 10);
            RoundControl(txt_tim, 10);
            RoundControl(txt_namxuatban, 10);
            RoundControl(txt_nhaxuatban, 10);
            RoundControl(txt_soluong, 10);
            RoundControl(txt_tensach, 10);
            RoundControl(txt_tentacgia, 10);
            RoundControl(txt_theloai, 10);
            RoundControl(txt_diachi, 10);
            RoundControl(txt_tennguoimuon, 10);
            RoundControl(txt_sdt, 10);
            RoundControl(rtb_sachmuon, 10);
            RoundControl(txt_SoDT, 10);
            RoundControl(txt_ngaymuonsach, 10);
            RoundControl(txt_ngaytrasach, 10);
            RoundControl(txt_diachinm, 10);
            RoundControl(txt_nguoimuon, 10);
            RoundControl(txt_ngaymuon, 10);
            RoundControl(mnt_congcu, 10);
            ngayhientai(txt_ngaymuon);
        }

        private void btn_an_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Dangnhap dn = new Dangnhap();
            dn.Show();
            this.Hide();
        }
        public void HandleMenuStripAction(string action)
        {
            switch (action)
            {
                case "quanLyThuvien":
                    quanLyThưViênToolStripMenuItem_Click(null, EventArgs.Empty);
                    break;
                case "quanLySach":
                    quanLySachToolStripMenuItem_Click(null, EventArgs.Empty);
                    break;
                case "muonSach":
                    mươnSachToolStripMenuItem_Click(null, EventArgs.Empty);
                    break;
                case "traSach":
                    traSachToolStripMenuItem_Click(null, EventArgs.Empty);
                    break;
                default:
                    MessageBox.Show("Hành động không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
        public void ngayhientai(System.Windows.Forms.TextBox x)
        {
            x.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        public void loaddulieu(DataGridView dgv)
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
        private void Thuvien_Load(object sender, EventArgs e)
        {
            dgv_hienthi.ClearSelection();
            dgv_danhsachmuontra.ClearSelection();
            loaddulieu(dgv_hienthi);
            quanLyThưViênToolStripMenuItem_Click(null, EventArgs.Empty);
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

        private void SlidePanels(Panel currentPanel, Panel newPanel)
        {
            if (newPanel == null) return;

            Timer slideTimer = new Timer();
            int speed = 15;
            int targetPositionNew = 0; // Vị trí đích cho panel mới
            int targetPositionOld = -currentPanel?.Width ?? 0; // Vị trí đích cho panel cũ (ra ngoài màn hình)

            // Đặt vị trí ban đầu cho panel mới
            newPanel.Left = -newPanel.Width;
            newPanel.Visible = true;

            slideTimer.Interval = 15;
            slideTimer.Tick += (s, e) =>
            {
                bool isCurrentPanelDone = true;
                bool isNewPanelDone = true;

                // Trượt panel cũ ra ngoài
                if (currentPanel != null && currentPanel.Left > targetPositionOld)
                {
                    currentPanel.Left -= speed;
                    isCurrentPanelDone = false;
                }

                // Trượt panel mới vào
                if (newPanel.Left < targetPositionNew)
                {
                    newPanel.Left += speed;
                    isNewPanelDone = false;
                }

                // Dừng khi cả hai hoàn tất
                if (isCurrentPanelDone && isNewPanelDone)
                {
                    slideTimer.Stop();
                    slideTimer.Dispose();
                    if (currentPanel != null) currentPanel.Visible = false;
                }
            };

            slideTimer.Start();
        }
        private Panel GetCurrentVisiblePanel()
        {
            if (pnl_quanlysach.Visible && pnl_quanlysach.Left == 0) return pnl_quanlysach;
            if (pnl_muonsach.Visible && pnl_muonsach.Left == 0) return pnl_muonsach;
            if (pnl_trasach.Visible && pnl_trasach.Left == 0) return pnl_trasach;
            if (pnl_quanlythuvien.Visible && pnl_quanlythuvien.Left == 0) return pnl_quanlythuvien;
            return null;
        }
        private void Thuvien_Shown(object sender, EventArgs e)
        {

        }
        private void quanLyThưViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pnl_quanlythuvien.Visible)
            {
                Panel currentPanel = GetCurrentVisiblePanel();
                SlidePanels(currentPanel, pnl_quanlythuvien);
                
                pnl_quanlythuvien.Visible = true;
                pnl_quanlysach.Visible = false;
                pnl_muonsach.Visible = false;
                pnl_trasach.Visible = false;
                cln_muon.Visible = false;
                dgv_hienthi.Visible = true;
                dgv_danhsachmuontra.Visible = false;
                loaddulieu(dgv_hienthi);
            }
        }

        private void quanLySachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pnl_quanlysach.Visible)
            {
                Panel currentPanel = GetCurrentVisiblePanel();
                SlidePanels(currentPanel, pnl_quanlysach);
                // Cập nhật trạng thái
                pnl_quanlythuvien.Visible = false;
                pnl_muonsach.Visible = false;
                pnl_trasach.Visible = false;
                dgv_hienthi.Visible = true;
                dgv_danhsachmuontra.Visible = false;
                cln_muon.Visible = false;
                
                loaddulieu(dgv_hienthi);
                dgv_hienthi.ClearSelection();
            }
        }

        private void mươnSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pnl_muonsach.Visible)
            {
                Panel currentPanel = GetCurrentVisiblePanel();
                SlidePanels(currentPanel, pnl_muonsach);
                
                // Cập nhật dữ liệu và trạng thái
                pnl_quanlythuvien.Visible = false;
                pnl_quanlysach.Visible = false;
                pnl_trasach.Visible = false;
                dgv_hienthi.Visible = true;
                dgv_danhsachmuontra.Visible = false;
                lbl_hienloi.Text = "";
                cln_muon.Visible = true;
                loaddulieu(dgv_hienthi);
            }
        }

        private void traSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pnl_trasach.Visible)
            {
                Panel currentPanel = GetCurrentVisiblePanel();
                SlidePanels(currentPanel, pnl_trasach);
                
                // Cập nhật dữ liệu và trạng thái
                pnl_quanlythuvien.Visible = false;
                pnl_muonsach.Visible = false;
                pnl_quanlysach.Visible = false;
                cln_muon.Visible = false;
                dgv_danhsachmuontra.Visible = true;
                dgv_hienthi.Visible = false;
                loaddulieu(dgv_danhsachmuontra);
            }
        }

        private void thôngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongke tk = new Thongke();
            tk.Show();
            this.Hide();
        }

        private void caiĐatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void TimKiem(DataGridView dgv)
        {
            // Lưu trạng thái checkbox trước khi tải lại dữ liệu
            if (dgv == dgv_hienthi)
            {
                foreach (DataGridViewRow row in dgv_hienthi.Rows)
                {
                    if (row.Cells["cln_muon"] is DataGridViewCheckBoxCell chk && chk.Value != null)
                    {
                        int idSach = Convert.ToInt32(row.Cells["cln_masach"].Value);

                        // Nếu checkbox được chọn, thêm idSach vào danh sách
                        if ((bool)chk.Value)
                        {
                            if (!selectedBooks.Contains(idSach))
                            {
                                selectedBooks.Add(idSach);
                            }
                        }
                        // Nếu checkbox bị bỏ chọn, xóa idSach khỏi danh sách
                        else
                        {
                            selectedBooks.Remove(idSach);
                        }
                    }
                }
            }

            if (string.IsNullOrEmpty(txt_tim.Text))
            {
                if (dgv == dgv_hienthi)
                {
                    loaddulieu(dgv_hienthi);
                    RestoreCheckboxState();
                    return;
                }
                else if (dgv == dgv_danhsachmuontra)
                {
                    loaddulieu(dgv_danhsachmuontra);
                    return;
                }
            }
            else
            {
                Connection conn = new Connection();
                if (conn.moKetnoi())
                {
                    string sql = "";
                    string kt;
                    if (dgv == dgv_hienthi)
                    {
                        sql = "SELECT idSach, TenSach, TheLoai, Tentacgia, NhaXuatBan, NamXuatBan, SoLuong FROM Sach WHERE TenSach LIKE @TenSach";
                        kt = "@Tensach";
                    }
                    else
                    {
                        sql = "SELECT pm.idPhieuMuon, pm.TenDocGia, pm.SDT, pm.DiaChi, pm.NgayMuon, pm.NgayTra, pm.TinhTrangGiaoDich, s.idSach, s.TenSach " +
                                     "FROM PhieuMuon pm " +
                                     "INNER JOIN ChiTietPhieuMuon ctp ON pm.idPhieuMuon = ctp.idPhieuMuon " +
                                     "INNER JOIN Sach s ON ctp.idSach = s.idSach " +
                                     "WHERE pm.TenDocGia LIKE @TenDocGia";
                        kt = "@TenDocGia";
                    }
                    SqlCommand cmd = new SqlCommand(sql, conn.conn);
                    cmd.Parameters.AddWithValue(kt, "%" + txt_tim.Text + "%");
                    SqlDataReader rdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rdr);
                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    rdr.Close();
                }
                else
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu!");
                }
            }
            // Khôi phục trạng thái checkbox sau khi tải lại dữ liệu
            RestoreCheckboxState();
        }
        private void RestoreCheckboxState()
        {
            foreach (DataGridViewRow row in dgv_hienthi.Rows)
            {
                if (row.Cells["cln_masach"] != null && row.Cells["cln_muon"] is DataGridViewCheckBoxCell chk)
                {
                    int idSach = Convert.ToInt32(row.Cells["cln_masach"].Value);
                    chk.Value = selectedBooks.Contains(idSach); // Đặt trạng thái checkbox dựa trên danh sách đã lưu
                }
            }
        }
        private void txt_tim_TextChanged(object sender, EventArgs e)
        {
            if (dgv_hienthi.Visible == true || dgv_danhsachmuontra.Visible == false)
            {
                TimKiem(dgv_hienthi);
            }
            else if (dgv_hienthi.Visible == false || dgv_danhsachmuontra.Visible == true)
            {
                TimKiem(dgv_danhsachmuontra);
            }
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void Checkmuonsach(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Không tính Header
            {
                DataGridViewRow row = dgv_hienthi.Rows[e.RowIndex];
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["cln_muon"]; // "cln_muon" là tên cột checkbox

                bool isChecked = chk.Value != null && (bool)chk.Value;

                // Đảo ngược trạng thái checkbox
                chk.Value = !isChecked;

                // Lấy idSach từ cột "cln_masach"
                int idSach = Convert.ToInt32(row.Cells["cln_masach"].Value);
                // Thêm hoặc xóa idSach khỏi danh sách selectedBooks
                if (pnl_muonsach.Visible == true)
                {
                    if (!isChecked)
                    {
                        if (!selectedBooks.Contains(idSach))
                        {
                            selectedBooks.Add(idSach);
                        }
                    }
                    else
                    {
                        selectedBooks.Remove(idSach);
                    }
                }
            }
        }

        private void dgv_hienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Checkmuonsach(e);
            if (e.RowIndex >= 0) // tránh lỗi click header
            {
                DataGridViewRow row = dgv_hienthi.Rows[e.RowIndex];
                int soLuong = Convert.ToInt32(row.Cells["cln_soluong"].Value); // "SoLuong" là tên cột chứa số lượng
                if (soLuong == 0)
                    dgv_hienthi.ClearSelection(); // bỏ chọn dòng đó
            }
        }
        
        private void btn_chonsach_Click(object sender, EventArgs e)
        {
            dgv_danhsachmuontra.Visible = false;
            dgv_hienthi.Visible = true;
            loaddulieu(dgv_hienthi);
        }
        public void InsertMuonSach(int idsach, int idphieumuon)
        {
            Connection conn = new Connection();
            if (conn.moKetnoi())
            {
                string sql = "INSERT INTO ChiTietPhieuMuon (idPhieuMuon, idSach) VALUES (@idPhieuMuon, @idSach); " +
                    "UPDATE Sach SET Soluong = Soluong - 1 WHERE idSach = @idSach AND Soluong > 0";
                SqlCommand cmd = new SqlCommand(sql, conn.conn);
                cmd.Parameters.AddWithValue("@idPhieuMuon", idphieumuon); // Thay thế bằng giá trị thực tế
                cmd.Parameters.AddWithValue("@idSach", idsach);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    conn.dongKetnoi();
                }
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến CSDL!");
            }
        }
        private void btn_xacnhanmuon_Click(object sender, EventArgs e)
        {
            if (dgv_danhsachmuontra.Visible == true)
            {
                dgv_danhsachmuontra.Visible = false;
                dgv_hienthi.Visible = true;
            }
            //Sửa phân idphieumuon
            int idphieumuon = 0;
            string tennguoimuon = txt_tennguoimuon.Text;
            string sdt = txt_sdt.Text;
            string diachi = txt_diachi.Text;
            DateTime ngaymuon = DateTime.Now;
            if (tennguoimuon == "" || sdt == "" || diachi == "")
            {
                lbl_hienloi.Text = "Vui lòng nhập đầy đủ thông tin!";
                return;
            }
            dsidsachmuon.Clear(); // Xóa dữ liệu cũ để reset
            // Kiểm tra ô checkbox nào được chọn không
            foreach (DataGridViewRow row in dgv_hienthi.Rows)
            {
                // Lấy giá trị của ô checkbox
                bool isChecked = Convert.ToBoolean(row.Cells["cln_muon"].Value);
                // Nếu ô checkbox được chọn, lấy giá trị của cột "cln_masach", thêm vào danh sách mượn
                if (isChecked)
                {
                    int idsach = Convert.ToInt32(row.Cells["cln_masach"].Value);
                    dsidsachmuon.Add(idsach);
                }
            }
            // Kiểm tra xem có sách nào được chọn không
            if (dsidsachmuon.Count == 0)
            {
                lbl_hienloi.Text = "Vui lòng chọn sách!";
                return;
            }
            else
            {
                Connection conn = new Connection();
                // Thêm phiếu mượn mới
                if (conn.moKetnoi())
                {
                    string sql = "INSERT INTO PhieuMuon (TenDocGia, SDT, DiaChi, NgayMuon, NgayTra, TinhTrangGiaoDich) " +
                    "OUTPUT INSERTED.idPhieuMuon " +
                    "VALUES (@TenDocGia, @SDT, @DiaChi, @NgayMuon, NULL, @TinhTrangGiaoDich);";
                    SqlCommand cmd = new SqlCommand(sql, conn.conn);
                    cmd.Parameters.AddWithValue("@TenDocGia", tennguoimuon);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@DiaChi", diachi);
                    cmd.Parameters.AddWithValue("@NgayMuon", ngaymuon);
                    cmd.Parameters.AddWithValue("@TinhTrangGiaoDich", "Đang mượn");
                    idphieumuon = Convert.ToInt32(cmd.ExecuteScalar());
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể kết nối đến CSDL!");
                }
                // Sau khi lấy xong, bạn insert lần lượt vào CSDL
                foreach (int idsach in dsidsachmuon)
                {
                    InsertMuonSach(idsach, idphieumuon); // Thêm phiếu mượn
                }
            }
            // Xác nhận mượn, load lại dữ liệu rồi chuyển sang dgv_danhsachmuontra
            lbl_hienloi.Text = "Mượn sách thành công!";
            txt_tennguoimuon.Text = "";
            txt_sdt.Text = "";
            txt_diachi.Text = "";
            txt_ngaymuon.Text = "";
            loaddulieu(dgv_danhsachmuontra);
            dgv_hienthi.Visible = false;
            dgv_danhsachmuontra.Visible = true;
        }

        private void btn_lichsumuon_Click(object sender, EventArgs e)
        {
            dgv_danhsachmuontra.Visible = true;
            dgv_hienthi.Visible = false;
            loaddulieu(dgv_danhsachmuontra);
            lbl_hienloi.Text = "";
        }
        private string GetSachMuon(int idPhieuMuon)
        {
            Connection conn = new Connection();
            string sachMuon = "";
            if (conn.moKetnoi())
            {
                string query = @"
                    SELECT s.Tensach
                    FROM ChiTietPhieuMuon ctp
                    INNER JOIN Sach s ON ctp.idSach = s.idSach
                    WHERE ctp.idPhieuMuon = " + idPhieuMuon;

                var reader = conn.truyvan(query);
                while (reader.Read())
                {
                    sachMuon += reader["Tensach"].ToString() + Environment.NewLine;
                }
                conn.dongKetnoi();
            }
            return sachMuon.Trim();
        }

        private void dgv_danhsachmuontra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo người dùng chọn một hàng hợp lệ
            {
                DataGridViewRow row = dgv_danhsachmuontra.Rows[e.RowIndex];

                // Gán dữ liệu từ hàng được chọn vào các control, xử lý null an toàn
                txt_nguoimuon.Text = row.Cells["TenDocGia"].Value?.ToString() ?? "";
                txt_SoDT.Text = row.Cells["SDT"].Value?.ToString() ?? "";
                txt_diachinm.Text = row.Cells["Diachi"].Value?.ToString() ?? "";
                txt_ngaymuonsach.Text = row.Cells["NgayMuon"].Value?.ToString() ?? "";
                txt_ngaytrasach.Text = row.Cells["NgayTra"].Value?.ToString() ?? ""; // Xử lý giá trị null
                if (int.TryParse(row.Cells["id"].Value?.ToString(), out int idPhieuMuon))
                {
                    rtb_sachmuon.Text = GetSachMuon(idPhieuMuon);
                }
                else
                {
                    rtb_sachmuon.Text = "";
                }
            }
        }

        private void btn_xacnhantra_Click(object sender, EventArgs e)
        {
            if (dgv_danhsachmuontra.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hàng để xác nhận trả sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy id từ hàng được chọn
            int idPhieuMuon;
            try
            {
                idPhieuMuon = Convert.ToInt32(dgv_danhsachmuontra.SelectedRows[0].Cells["id"].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể lấy thông tin id từ hàng được chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kết nối cơ sở dữ liệu và cập nhật tình trạng giao dịch
            Connection conn = new Connection();
            if (!conn.moKetnoi())
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Cập nhật tình trạng giao dịch thành "Đã trả" và ngày trả
                string queryUpdatePhieuMuon = @"
                UPDATE PhieuMuon 
                SET TinhTrangGiaoDich = N'Đã trả', NgayTra = GETDATE() 
                WHERE idPhieuMuon = @idPhieuMuon";
                SqlCommand cmdUpdatePhieuMuon = new SqlCommand(queryUpdatePhieuMuon, conn.conn);
                cmdUpdatePhieuMuon.Parameters.AddWithValue("@idPhieuMuon", idPhieuMuon);

                int rowsAffected = cmdUpdatePhieuMuon.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    // Lấy danh sách idSach từ ChiTietPhieuMuon dựa trên idPhieuMuon
                    string queryGetSach = "SELECT idSach FROM ChiTietPhieuMuon WHERE idPhieuMuon = @idPhieuMuon";
                    SqlCommand cmdGetSach = new SqlCommand(queryGetSach, conn.conn);
                    cmdGetSach.Parameters.AddWithValue("@idPhieuMuon", idPhieuMuon);

                    SqlDataReader reader = cmdGetSach.ExecuteReader();
                    List<int> idSachList = new List<int>();
                    while (reader.Read())
                    {
                        idSachList.Add(Convert.ToInt32(reader["idSach"]));
                    }
                    reader.Close();

                    // Tăng số lượng sách trong bảng Sach
                    foreach (int idSach in idSachList)
                    {
                        string queryUpdateSach = "UPDATE Sach SET Soluong = Soluong + 1 WHERE idSach = @idSach";
                        SqlCommand cmdUpdateSach = new SqlCommand(queryUpdateSach, conn.conn);
                        cmdUpdateSach.Parameters.AddWithValue("@idSach", idSach);
                        cmdUpdateSach.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cập nhật tình trạng giao dịch, ngày trả và số lượng sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddulieu(dgv_danhsachmuontra); // Tải lại dữ liệu sau khi cập nhật
                }
                else
                {
                    MessageBox.Show("Không có bản ghi nào được cập nhật. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật tình trạng giao dịch: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.dongKetnoi();
            }
        }

        private void pnl_congcu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string tenSach = txt_tensach.Text.Trim();
            string theLoai = txt_theloai.Text.Trim();
            string tenTacGia = txt_tentacgia.Text.Trim();
            string nhaXuatBan = txt_nhaxuatban.Text.Trim();
            string namXuatBanText = txt_namxuatban.Text.Trim();
            string soLuongText = txt_soluong.Text.Trim();

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(tenSach) || string.IsNullOrEmpty(theLoai) || string.IsNullOrEmpty(tenTacGia) ||
                string.IsNullOrEmpty(nhaXuatBan) || string.IsNullOrEmpty(namXuatBanText) || string.IsNullOrEmpty(soLuongText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(namXuatBanText, out int namXuatBan) || !int.TryParse(soLuongText, out int soLuong))
            {
                MessageBox.Show("Năm xuất bản và số lượng phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm dữ liệu vào cơ sở dữ liệu
            Connection conn = new Connection();
            if (conn.moKetnoi())
            {
                try
                {
                    string sql = @"
            INSERT INTO Sach (Tensach, Theloai, Tentacgia, Nhaxuatban, Namxuatban, Soluong)
            VALUES (@Tensach, @Theloai, @Tentacgia, @Nhaxuatban, @Namxuatban, @Soluong)";
                    SqlCommand cmd = new SqlCommand(sql, conn.conn);
                    cmd.Parameters.AddWithValue("@Tensach", tenSach);
                    cmd.Parameters.AddWithValue("@Theloai", theLoai);
                    cmd.Parameters.AddWithValue("@Tentacgia", tenTacGia);
                    cmd.Parameters.AddWithValue("@Nhaxuatban", nhaXuatBan);
                    cmd.Parameters.AddWithValue("@Namxuatban", namXuatBan);
                    cmd.Parameters.AddWithValue("@Soluong", soLuong);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa dữ liệu trong các TextBox sau khi thêm thành công
                    txt_tensach.Text = "";
                    txt_theloai.Text = "";
                    txt_tentacgia.Text = "";
                    txt_nhaxuatban.Text = "";
                    txt_namxuatban.Text = "";
                    txt_soluong.Text = "";

                    // Cập nhật lại DataGridView
                    loaddulieu(dgv_hienthi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dgv_hienthi.ClearSelection();
        }   

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_hienthi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy idSach từ hàng được chọn
            int idSach;
            try
            {
                idSach = Convert.ToInt32(dgv_hienthi.SelectedRows[0].Cells["cln_masach"].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể lấy thông tin từ hàng được chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xác nhận xóa
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            // Xóa dữ liệu khỏi cơ sở dữ liệu
            Connection conn = new Connection();
            if (conn.moKetnoi())
            {
                try
                {
                    string sql = "DELETE FROM Sach WHERE idSach = @idSach";
                    SqlCommand cmd = new SqlCommand(sql, conn.conn);
                    cmd.Parameters.AddWithValue("@idSach", idSach);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Cập nhật lại DataGridView
                        loaddulieu(dgv_hienthi);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dgv_hienthi.ClearSelection();
        }

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
            if (btn_chinhsua.Text == "Lưu")
            {
                // Kiểm tra xem có hàng nào được chọn không
                if (dgv_hienthi.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một hàng để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy idSach từ hàng được chọn
                int idSach;
                try
                {
                    idSach = Convert.ToInt32(dgv_hienthi.SelectedRows[0].Cells["cln_masach"].Value);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể lấy thông tin từ hàng được chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy dữ liệu từ các TextBox
                string tenSach = txt_tensach.Text.Trim();
                string theLoai = txt_theloai.Text.Trim();
                string tenTacGia = txt_tentacgia.Text.Trim();
                string nhaXuatBan = txt_nhaxuatban.Text.Trim();
                string namXuatBanText = txt_namxuatban.Text.Trim();
                string soLuongText = txt_soluong.Text.Trim();

                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(tenSach) || string.IsNullOrEmpty(theLoai) || string.IsNullOrEmpty(tenTacGia) ||
                    string.IsNullOrEmpty(nhaXuatBan) || string.IsNullOrEmpty(namXuatBanText) || string.IsNullOrEmpty(soLuongText))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(namXuatBanText, out int namXuatBan) || !int.TryParse(soLuongText, out int soLuong))
                {
                    MessageBox.Show("Năm xuất bản và số lượng phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật dữ liệu trong cơ sở dữ liệu
                Connection conn = new Connection();
                if (conn.moKetnoi())
                {
                    try
                    {
                        string sql = @"
                UPDATE Sach
                SET Tensach = @Tensach, Theloai = @Theloai, Tentacgia = @Tentacgia,
                    Nhaxuatban = @Nhaxuatban, Namxuatban = @Namxuatban, Soluong = @Soluong
                WHERE idSach = @idSach";
                        SqlCommand cmd = new SqlCommand(sql, conn.conn);
                        cmd.Parameters.AddWithValue("@Tensach", tenSach);
                        cmd.Parameters.AddWithValue("@Theloai", theLoai);
                        cmd.Parameters.AddWithValue("@Tentacgia", tenTacGia);
                        cmd.Parameters.AddWithValue("@Nhaxuatban", nhaXuatBan);
                        cmd.Parameters.AddWithValue("@Namxuatban", namXuatBan);
                        cmd.Parameters.AddWithValue("@Soluong", soLuong);
                        cmd.Parameters.AddWithValue("@idSach", idSach);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cập nhật sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Cập nhật lại DataGridView
                        loaddulieu(dgv_hienthi);

                        // Đặt lại trạng thái của nút
                        btn_chinhsua.Text = "Chỉnh sửa";

                        // Xóa dữ liệu trong các TextBox
                        txt_tensach.Text = "";
                        txt_theloai.Text = "";
                        txt_tentacgia.Text = "";
                        txt_nhaxuatban.Text = "";
                        txt_namxuatban.Text = "";
                        txt_soluong.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            dgv_hienthi.ClearSelection(); // Bỏ chọn tất cả các hàng trong DataGridView
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

        private void dgv_hienthi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_hienthi.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dgv_hienthi.SelectedRows[0];

                // Đưa dữ liệu từ hàng được chọn lên các TextBox
                txt_tensach.Text = selectedRow.Cells["cln_tensach"].Value.ToString();
                txt_theloai.Text = selectedRow.Cells["cln_theloai"].Value.ToString();
                txt_tentacgia.Text = selectedRow.Cells["cln_tacgia"].Value.ToString();
                txt_nhaxuatban.Text = selectedRow.Cells["cln_nhaxb"].Value.ToString();
                txt_namxuatban.Text = selectedRow.Cells["cln_nxb"].Value.ToString();
                txt_soluong.Text = selectedRow.Cells["cln_soluong"].Value.ToString();

                // Thay đổi văn bản của nút btn_chinhsua thành "Lưu"
                btn_chinhsua.Text = "Lưu";
            }
            else
            {
                // Nếu không có hàng nào được chọn, đặt lại văn bản thành "Chỉnh sửa"
                btn_chinhsua.Text = "Chỉnh sửa";

                // Xóa dữ liệu trong các TextBox
                textbox.SetPlaceholder(txt_tensach, "Tên sách");
                textbox.SetPlaceholder(txt_tentacgia, "Tên tác giả");
                textbox.SetPlaceholder(txt_theloai, "Thể loại");
                textbox.SetPlaceholder(txt_nhaxuatban, "Nhà xuất bản");
                textbox.SetPlaceholder(txt_namxuatban, "Năm xuất bản");
                textbox.SetPlaceholder(txt_soluong, "Số lượng");
            }
        }
    }
}
