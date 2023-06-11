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
    public class DAL_TraSach:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        void thucthisql(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
        public bool sua(DTO_TraSach dTO_TraSach)
        {
            string sql = "update ctMuontra set soluongSachTra = '"+dTO_TraSach.slt+ "' where muontraID=N'"+dTO_TraSach.ma+"'";
            thucthisql(sql); return true;
        }
        public DataTable getSachMuon(string ma)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM ctMuontra JOIN muontra ON ctMuontra.muontraID = muontra.muontraID WHERE muontra.docgiaID = '"+ma+"'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;

        }
        public DataTable getsltra(string ma)
        {
            DataTable dt = new DataTable();
            _con.Open();
            string query = "SELECT soluongSachMuon FROM ctMuontra WHERE ctMuontraID = N'" + ma + "'";
            cmd = new SqlCommand(query, _con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public bool CapNhatSoLuong(DTO_TraSach dTO_TraSach)
        {
            _con.Open();
            string updateQuery = "UPDATE ctMuontra SET soluongSachTra = soluongSachTra + @SoLuong WHERE ctMuontraID = @Ma";
            SqlCommand cmd = new SqlCommand(updateQuery, _con);
            cmd.Parameters.AddWithValue("@SoLuong", dTO_TraSach.slt);
            cmd.Parameters.AddWithValue("@Ma", dTO_TraSach.ma);
            cmd.ExecuteNonQuery();
            _con.Close();
            return true;
        }
        public bool CapNhat(DTO_CTMuonSach dTO_CTMuonSach)
        {
            _con.Open();
            string updateQuery = "update sach set soluong = soluong + @SoLuong where sachID = @MaSach";
            SqlCommand cmd = new SqlCommand(updateQuery, _con);
            cmd.Parameters.AddWithValue("@SoLuong", dTO_CTMuonSach.slm);
            cmd.Parameters.AddWithValue("@MaSach", dTO_CTMuonSach.maS);
            cmd.ExecuteNonQuery();
            _con.Close();
            return true;
        }
    }
}
