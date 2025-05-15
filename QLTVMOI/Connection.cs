using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVMOI
{
    internal class Connection : IDisposable
    {
        private string strConn = "server = LAPTOP-225OTEK8\\SQLEXPRESS;" +
         "database=qltv;" +
         "Integrated Security=True;";
        // Tạo các thành phần SQL Server Provider
        public SqlConnection conn { get; set; }
        public SqlCommand cmd { get; set; }
        public SqlDataReader dr { get; set; }
        //Constructors
        public Connection()
        {
            conn = new SqlConnection(strConn);
            cmd = null;
            dr = null;
        }
        //Methods
        //Mở kết nối đến nguồn dữ liệu
        public bool moKetnoi()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Đóng kết nối đến nguồn dữ liệu
        public bool dongKetnoi()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Đổ dữ liệu từ CSDL -> DataReader -> Client đọc
        public SqlDataReader truyvan(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            return dr;
        }
        public int capnhat(string nonsql)
        {
            cmd = new SqlCommand(nonsql, conn);
            return cmd.ExecuteNonQuery();
        }
        public void Dispose()
        {
            if (dr != null)
            {
                dr.Dispose();
            }

            if (cmd != null)
            {
                cmd.Dispose();
            }

            if (conn != null)
            {
                conn.Dispose();
            }
        }
    }
}
