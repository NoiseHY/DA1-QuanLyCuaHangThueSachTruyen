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
    public class DAL_TacGia:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getTacGia()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from tacgia", _con);
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
            string sql = "select count (*) from tacgia where tacgiaID =N'" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themTacgia(DTO_TacGia dTO_TacGia)
        {
            string sql = "insert into tacgia values (N'" + dTO_TacGia.maTG + "', N'" + dTO_TacGia.tenTG + "', N'" + dTO_TacGia.quoctich + "', '" +dTO_TacGia.namsinh + "' )";
            thucthisql(sql); return true;
        }
        public bool suaTacgia(DTO_TacGia dTO_TacGia)
        {
            string sql = "UPDATE tacgia SET tacgiaID = N'" + dTO_TacGia.maTG + "', tenDaydu = N'" + dTO_TacGia.tenTG + "', quoctich = N'" + dTO_TacGia.quoctich + "', namsinh = '" + dTO_TacGia.namsinh + "' WHERE tacgiaID = N'" + dTO_TacGia.maTG + "'";
            thucthisql(sql); return true;
        }
        public bool xoaTacgia(string ma)
        {
            string sql = "delete from tacgia where tacgiaID = N'" + ma + "'";
            thucthisql(sql); return true;
        }
    }
}
