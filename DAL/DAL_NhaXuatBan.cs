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
    public class DAL_NhaXuatBan:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getNXB()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from nhaxuatban", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        void thucthisql(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();// Thực hiện lệnh SQL
            _con.Close();
        }
        public int ktra(string ma)
        {
            _con.Open();
            int i;
            string sql = "select count (*) from nhaxuatban where nhaxuatbanID =N'" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool them(DTO_NhaXuatBan dTO_NhaXuatBan)
        {
            string sql = "insert into nhaxuatban values (N'" + dTO_NhaXuatBan.maNXB + "', N'" + dTO_NhaXuatBan.tenNXB + "', N'" + dTO_NhaXuatBan.diachi + "', '" + dTO_NhaXuatBan.sdt + "', '" + dTO_NhaXuatBan.email + "' )";
            thucthisql(sql); return true;
        }
        public bool sua(DTO_NhaXuatBan dTO_NhaXuatBan)
        {
            string sql = "UPDATE nhaxuatban SET nhaxuatbanID = N'" + dTO_NhaXuatBan.maNXB + "', tenNhaxuatban = N'" + dTO_NhaXuatBan.tenNXB + "', diachi = N'" + dTO_NhaXuatBan.diachi + "', sodienthoai = '" + dTO_NhaXuatBan.sdt + "',email = '" + dTO_NhaXuatBan.email + "' WHERE nhaxuatbanID = N'" + dTO_NhaXuatBan.maNXB + "'";
            thucthisql(sql); return true;
        }
        public bool xoa(string ma)
        {
            string sql = "delete from nhaxuatban where nhaxuatbanID = N'" + ma + "'";
            thucthisql(sql); return true;
        }
    }
}
