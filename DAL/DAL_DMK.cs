using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DAL
{
    public class DAL_DMK:DBConnect
    {
        SqlCommand cmd;
        void thucthiSQL(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
        public bool DoiMatKhau(DTO_DMK dTO_DMK)
        {
            string sql = "UPDATE nguoidung SET matkhau = @matkhau WHERE tenNguoidung = @tenNguoidung";
            _con.Open();
            SqlCommand cmd = new SqlCommand(sql, _con);
            cmd.Parameters.AddWithValue("@matkhau", dTO_DMK.mkm);
            cmd.Parameters.AddWithValue("@tenNguoidung", dTO_DMK.username);
            int rowsAffected = cmd.ExecuteNonQuery();
            _con.Close();
            return rowsAffected > 0;//mật khẩu đã được cập nhật thành công trong CSDL, biểu thức rowsAffected > 0 sẽ trả về giá trị true.
        }

        public bool checkMK(DTO_DMK dto_DMK)
        {
            if (dto_DMK.mkc == dto_DMK.NLmkc)
                return true;
            else
                return false;
        }
        public bool checkMKM(DTO_DMK dto_DMK)
        {
            if (dto_DMK.mkm == dto_DMK.NLmkm)
                return true;
            else
                return false;
        }
        

    }
}
