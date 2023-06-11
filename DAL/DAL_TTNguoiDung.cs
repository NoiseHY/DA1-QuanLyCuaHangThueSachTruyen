using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_TTNguoiDung:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getTT(string username)
        {
            _con.Open();
            da = new SqlDataAdapter($"select tenNguoidung, tenDaydu, email, sodienthoai, diachi from nguoidung where tenNguoidung = N'"+username+"'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        void thucthiSQL(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
        public bool suaTT(DTO_TTNguoiDung dTO_TTNguoiDung)
        {
            string sql = "update nguoidung set tenDaydu = N'" + dTO_TTNguoiDung.tenDD + "',email= N'" + dTO_TTNguoiDung.email + "',sodienthoai= '" + dTO_TTNguoiDung.sdt + "', diachi = N'"+dTO_TTNguoiDung.diachi+"' where tenNguoidung = N'"+dTO_TTNguoiDung.tenuser+"'";
            thucthiSQL(sql);
            return true;
        }

    }
}
