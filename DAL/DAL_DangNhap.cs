using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DAL
{
    public class DAL_DangNhap : DBConnect
    {      
        string username = "tên người dùng";
        string password = "mật khẩu";
        public DataTable getData(string username, string password)
        {
            _con.Open();
            string sql = "SELECT nguoidungID, tenphanQuyen FROM nguoidung JOIN phanQuyen ON nguoidung.phanQuyenID = phanQuyen.phanQuyenID WHERE tenNguoidung = @username AND matkhau = @password";
            SqlCommand command = new SqlCommand(sql, _con);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            DataTable dt = new DataTable();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                dt.Load(reader);
            }
            _con.Close();
            return dt;
        }
    }
}