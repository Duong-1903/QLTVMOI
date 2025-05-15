using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVMOI
{
    public partial class Report : Form
    {
        private string _option;
        public Report(string option)
        {
            InitializeComponent();
            
        }
        private void loaddulieu(string sql, string reportDataSourceName)
        {
            Connection conn = new Connection();
            if (conn.moKetnoi())
            {
                try
                {
                    // Thực thi truy vấn và tải dữ liệu vào DataTable
                    SqlDataReader rdr = conn.truyvan(sql);
                    DataTable dt = new DataTable();
                    dt.Load(rdr);
                    rdr.Close();

                    // Thiết lập nguồn dữ liệu cho ReportViewer
                    ReportDataSource rds = new ReportDataSource(reportDataSourceName, dt);
                    //rpv_smt.LocalReport.DataSources.Clear(); // Xóa các nguồn dữ liệu cũ
                    rpv_smt.LocalReport.DataSources.Add(rds);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.dongKetnoi();
                }
            }
            else
            {
                MessageBox.Show("Không thể kết nối cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Report_Load(object sender, EventArgs e)
        {
            if (_option == "dssach")
            {
                try
                {
                    // Thiết lập tệp báo cáo
                    rpv_smt.LocalReport.ReportEmbeddedResource = "QLTVMOI.ReportSach.rdlc";

                    // Truy vấn SQL và tên nguồn dữ liệu
                    string query = "SELECT * FROM SACH";
                    string reportDataSourceName = "DataSetSach";
                    rpv_smt.LocalReport.DataSources.Clear();
                    // Gọi phương thức loaddulieu
                    loaddulieu(query, reportDataSourceName);
                    this.rpv_smt.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (_option == "dsmuontra")
            {
                try
                {
                    // Thiết lập tệp báo cáo
                    rpv_smt.LocalReport.ReportEmbeddedResource = "QLTVMOI.ReportMuon.rdlc";
                    // Truy vấn SQL và tên nguồn dữ liệu
                    string query1 = "SELECT pm.idPhieuMuon, pm.TenDocGia, pm.SDT, pm.DiaChi, format(pm.NgayMuon, 'dd/MM/yyyy') as NgayMuon, format(pm.NgayTra, 'dd/MM/yyyy') as NgayTra, pm.TinhTrangGiaoDich " +
                        "FROM PhieuMuon pm " +
                        "INNER JOIN ChiTietPhieuMuon ctp ON pm.idPhieuMuon = ctp.idPhieuMuon " +
                        "ORDER BY pm.idPhieuMuon;";
                    string query2 = "select Tensach from Sach s join ChiTietPhieuMuon ct on ct.idSach = s.idSach " +
                        "ORDER BY ct.idPhieuMuon;";
                    string reportDataSourceName1 = "DataSetMuontra";
                    string reportDataSourceName2 = "DataSetSach";
                    rpv_smt.LocalReport.DataSources.Clear();
                    // Gọi phương thức loaddulieu
                    loaddulieu(query1, reportDataSourceName1);
                    loaddulieu(query2, reportDataSourceName2);
                    this.rpv_smt.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
