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
    public class DAL_ThongKe : DBConnect
    {

        public DataTable getSLm(DTO_ThongKe thongKe)
        {
            _con.Open();
            string sqlQuery = "SELECT MONTH(ngayMuonsach) AS thang, SUM(soluongSachMuon) AS soluongmuon FROM ctMuontra INNER JOIN muontra ON ctMuontra.muontraID = muontra.muontraID WHERE YEAR(muontra.ngayMuonsach) = @year GROUP BY YEAR(muontra.ngayMuonsach), MONTH(muontra.ngayMuonsach)";
            SqlCommand command = new SqlCommand(sqlQuery, _con);
            command.Parameters.AddWithValue("@year", thongKe.nam);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            _con.Close();
            return dataTable;
        }

        public DataTable getSLtra(DTO_ThongKe thongKe)
        {
            _con.Open();
            string sqlQuery = "SELECT MONTH(ngayMuonsach) AS thang, SUM(soluongSachTra) AS soluongtra FROM ctMuontra INNER JOIN muontra ON ctMuontra.muontraID = muontra.muontraID WHERE YEAR(muontra.ngayMuonsach) = @year GROUP BY YEAR(muontra.ngayMuonsach), MONTH(muontra.ngayMuonsach)";
            SqlCommand command = new SqlCommand(sqlQuery, _con);
            command.Parameters.AddWithValue("@year", thongKe.nam);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            _con.Close();
            return dataTable;
        }



        //
        public DataTable getTien(DTO_ThongKe dTO_ThongKe)
        {
            _con.Open();
            string sqlQuery = "SELECT MONTH(ngayNhaphoadon) AS thang, SUM(tongsotien) AS tongtien_nhap FROM phieunhap WHERE YEAR(ngayNhaphoadon) = @nam GROUP BY YEAR(ngayNhaphoadon), MONTH(ngayNhaphoadon);";
            SqlCommand command = new SqlCommand(sqlQuery, _con);
            command.Parameters.AddWithValue("@nam", dTO_ThongKe.nam);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            _con.Close();
            return dataTable;
        }

    }
}