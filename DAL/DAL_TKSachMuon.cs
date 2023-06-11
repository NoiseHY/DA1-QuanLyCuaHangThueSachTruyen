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
    public class DAL_TKSachMuon:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable get(DTO_TKSachMuon dTO_TKSachMuon)
        {
            _con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[muontra] WHERE [muontraID] = N'" + dTO_TKSachMuon.MaChinh + "'", _con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getNgayM(DTO_TKSachMuon dTO_TKSachMuon)
        {
            _con.Open();
            string ngay = string.Format("{0}/{1}/{2}", dTO_TKSachMuon.Ngay.Year, dTO_TKSachMuon.Ngay.Month, dTO_TKSachMuon.Ngay.Day);
            SqlCommand cmd = new SqlCommand("SELECT * FROM muontra WHERE ngayMuonsach = @Ngay", _con);
            cmd.Parameters.AddWithValue("@Ngay", Convert.ToDateTime(ngay));
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getNgayT(DTO_TKSachMuon dTO_TKSachMuon)
        {
            _con.Open();
            string ngay = string.Format("{0}/{1}/{2}", dTO_TKSachMuon.ngayT.Year, dTO_TKSachMuon.ngayT.Month, dTO_TKSachMuon.ngayT.Day);
            SqlCommand cmd = new SqlCommand("SELECT * FROM muontra WHERE ngayTrasach = @Ngay", _con);
            cmd.Parameters.AddWithValue("@Ngay", Convert.ToDateTime(dTO_TKSachMuon.Ngay));
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getCT(DTO_TKSachMuon dTO_TKSachMuon)
        {
            _con.Open();
            da = new SqlDataAdapter($"SELECT * FROM ctMuontra WHERE ctMuontraID = N'" + dTO_TKSachMuon.MaChinh + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getDG(DTO_TKSachMuon dTO_TKSachMuon)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM muontra WHERE docgiaID = N'" + dTO_TKSachMuon.MaChinh + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getMasach(DTO_TKSachMuon dTO_TKSachMuon)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM ctMuontra WHERE sachID = N'" + dTO_TKSachMuon.MaChinh + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
       
        public DataTable getSlm(int so)
        {
            _con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ctMuontra WHERE soluongSachMuon = @gia", _con);
            cmd.Parameters.AddWithValue("@gia", so);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getSlt(float so)
        {
            _con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ctMuontra WHERE soluongSachTra = @gia", _con);
            cmd.Parameters.AddWithValue("@gia", so);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getTC()
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT muontra.muontraID, muontra.docgiaID, muontra.ngayMuonsach, muontra.ngayTrasach, \r\n    ctMuontra.sachID, \r\n    ctMuontra.soluongSachMuon, ctMuontra.soluongSachTra FROM muontra JOIN ctMuontra ON muontra.muontraID = ctMuontra.muontraID ORDER BY muontra.ngayMuonsach DESC", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
    }
}
