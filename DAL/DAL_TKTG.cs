using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_TKTG:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getTG(DTO_TKTG dTO_TKTG)
        {
            _con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tacgia WHERE tacgiaID = N'"+dTO_TKTG.tk+"'", _con);           
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }

        public DataTable getTen(DTO_TKTG dTO_TKTG)
        {
            _con.Open();
            da = new SqlDataAdapter($"SELECT * FROM tacgia WHERE tenDaydu = N'" + dTO_TKTG.tk + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getQt(DTO_TKTG dTO_TKTG)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM tacgia WHERE quoctich = N'" + dTO_TKTG.tk + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getNamS(int nam)
        {
            _con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tacgia WHERE namSinh = @int", _con);
            cmd.Parameters.AddWithValue("@int", nam);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getNamM(int nam)
        {
            _con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tacgia WHERE namMat = @int", _con);
            cmd.Parameters.AddWithValue("@int", nam);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getTC()
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM tacgia ", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
    }
}
