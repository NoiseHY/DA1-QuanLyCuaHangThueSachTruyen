using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_NguoiDung : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        // Hiển thị danh sách người dùng ra ngoài màn hình
        public DataTable getNguoiDung()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from nguoidung", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        void thucthiSQl(string sql)
        {
            try
            {
                _con.Open();
                cmd = new SqlCommand(sql, _con);
                cmd.ExecuteNonQuery();
                _con.Close();
            }
            catch
            {
                
            }
        }
        public int ktra(string maND)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from nguoidung where nguoidungID =N'" + maND.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public int ktraND(string maND)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from nguoidung where [tenNguoidung] =N'" + maND.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themND(DTO_NguoiDung nguoiDung)
        {
            string sql = "insert into nguoidung values(N'" + nguoiDung.maND + "', N'" + nguoiDung.tenND + "', N'" + nguoiDung.mkND + "', N'" + nguoiDung.emailND + "', N'" + nguoiDung.hvtND + "', '" + nguoiDung.sdt + "', N'" + nguoiDung.dcND + "', N'" + nguoiDung.quyenND + "')";
            thucthiSQl(sql);
            return true;
        }
        public bool suaND(DTO_NguoiDung nguoiDung)
        {
            string sql = "update nguoidung set tenNguoidung= N'" + nguoiDung.tenND + "',matkhau= '" + nguoiDung.mkND + "',email= '" + nguoiDung.emailND + "',tenDaydu= N'" + nguoiDung.hvtND + "',sodienthoai= '" + nguoiDung.sdt + "',diachi= N'" + nguoiDung.dcND +"',phanQuyenID= '" + nguoiDung.quyenND + "' where nguoidungID = N'"+nguoiDung.maND+"'";
            thucthiSQl(sql);
            return true;
        }
        public bool xoaND(string nguoiDung)
        {
            string sql = "delete from nguoidung where nguoidungID = N'" + nguoiDung + "'";
            thucthiSQl(sql);
            return true;
        }
    }
}
