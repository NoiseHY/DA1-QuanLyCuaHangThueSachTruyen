using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Reflection.Emit;

namespace DAL
{
    public class DAL_CTMuonSach:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getTV()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from sach", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getSachMuon(string ma)
        {
            DataTable dt = new DataTable();
            _con.Open();
            string query = "SELECT * FROM ctMuontra WHERE muontraID = N'" + ma + "'";
            cmd = new SqlCommand(query, _con);
            da = new SqlDataAdapter(cmd);
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
        public int ktra(string ma)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from ctMuontra where ctMuontraID =N'" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }

        public bool them(DTO_CTMuonSach dTO_CTMuonSach)
        {
            string sql = "insert into ctMuontra values(N'" + dTO_CTMuonSach.ma + "', N'" + dTO_CTMuonSach.maCT + "', N'" + dTO_CTMuonSach.maS + "', '" +dTO_CTMuonSach.slm + "', '')";
            thucthiSQL(sql);
            return true;
        }
       
        public bool xoa(string ma)
        {
            string sql = "delete from ctMuontra where ctMuontraID = N'" + ma + "'";
            thucthiSQL(sql);
            return true;
        }
        
        public DataTable getsl(string ma)
        {
            DataTable dt = new DataTable();
            _con.Open();
            string query = "SELECT soluong FROM sach WHERE [sachID] = N'" + ma + "'";
            cmd = new SqlCommand(query, _con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public bool CapNhatSoLuong(DTO_CTMuonSach dTO_CTMuonSach)
        {
            _con.Open();
            string updateQuery = "update sach set soluong = soluong - @SoLuong where sachID = @MaSach";
            SqlCommand cmd = new SqlCommand(updateQuery, _con);
            cmd.Parameters.AddWithValue("@SoLuong", dTO_CTMuonSach.slm);
            cmd.Parameters.AddWithValue("@MaSach", dTO_CTMuonSach.maS);
            cmd.ExecuteNonQuery();
            _con.Close();
            return true;
        }
        public DataTable InReport(string maHD)
        {
            _con.Open();
            string query = "select * from ctMuontra where muontraID = N'" + maHD + "'";
            cmd = new SqlCommand(query, _con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            _con.Close();
            return dt;
        }



    }
}
