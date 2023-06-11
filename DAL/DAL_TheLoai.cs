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
    public class DAL_TheLoai:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getTL()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from theloai", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public int ktra(string ma)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from theloai where theloaiID =N'" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public int ktraT(string ma)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from theloai where tenTheloai =N'" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        void thucthiSQL(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
        public bool themTL(DTO_TheLoai dTO_TheLoai)
        {
            string sql = "insert into theloai values(N'" + dTO_TheLoai.maTL + "', N'" + dTO_TheLoai.tenTl + "', N'" + dTO_TheLoai.mota + "')";
            thucthiSQL(sql);
            return true;
        }
        public bool suaTL(DTO_TheLoai dTO_TheLoai)
        {
            string sql = "update theloai set theloaiID = N'" + dTO_TheLoai.maTL + "',tenTheloai= N'" + dTO_TheLoai.tenTl + "',motaTheloai= N'" + dTO_TheLoai.mota + "' where theloaiID = N'" + dTO_TheLoai.maTL + "'";
            thucthiSQL(sql);
            return true;
        }
        public bool xoaTL(string ma)
        {
            string sql = "delete from theloai where theloaiID = N'" + ma + "'";
            thucthiSQL(sql);
            return true;
        }
    }
}
