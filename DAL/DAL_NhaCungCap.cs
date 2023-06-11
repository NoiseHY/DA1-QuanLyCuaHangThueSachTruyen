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
    public class DAL_NhaCungCap:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getNCC()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from nhacungcap", _con);
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
            string sql = "select count (*) from nhacungcap where nhacungcapID =N'" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool them(DTO_NhaCungCap dTO_NhaCungCap)
        {
            string sql = "insert into nhacungcap values (N'" + dTO_NhaCungCap.maNCC + "', N'" + dTO_NhaCungCap.tenCC + "', N'" + dTO_NhaCungCap.diachi + "', '" + dTO_NhaCungCap.sdt + "', '" + dTO_NhaCungCap.email + "' )";
            thucthisql(sql); return true;
        }
        public bool sua(DTO_NhaCungCap dTO_NhaCungCap)
        {
            string sql = "UPDATE nhacungcap SET nhacungcapID = N'" + dTO_NhaCungCap.maNCC + "', tenNhacungcap = N'" +   dTO_NhaCungCap.tenCC + "', diachi = N'" + dTO_NhaCungCap.diachi + "', sodienthoai = '" + dTO_NhaCungCap.sdt + "',email = '" + dTO_NhaCungCap.email + "' WHERE nhacungcapID = N'" + dTO_NhaCungCap.maNCC + "'";
            thucthisql(sql); return true;
        }
        public bool xoa(string ma)
        {
            string sql = "delete from nhacungcap where nhacungcapID = N'" + ma + "'";
            thucthisql(sql); return true;
        }

    }
}
