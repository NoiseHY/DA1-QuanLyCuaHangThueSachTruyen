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
    public class DAL_CTNhap:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        void thucthiSQL(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
        public DataTable getData(string ma)
        {
            _con.Open();
            da = new SqlDataAdapter($"select * from dbo.ctPhieunhap where [phieunhapID] = '" +ma+"'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getSach()
        {
            _con.Open();
            da = new SqlDataAdapter($"select sachID, tenSach, soluong, ngonngu from sach where soluong <= 10", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getMasach()
        {
            _con.Open();
            da = new SqlDataAdapter($"select * from sach ", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        
        public int ktractNhap(string mactnhap)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from ctPhieunhap where ctPhieunhapID =N'" + mactnhap.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }

        public bool themctNhap(DTO_CTNhap dTO_CTNhap)
        {
            string sql = "insert into ctPhieunhap values(N'" + dTO_CTNhap.ctmaNhap + "', N'" + dTO_CTNhap.maNhap + "', N'" + dTO_CTNhap.maSach + "', '" + dTO_CTNhap.sl + "', '" + dTO_CTNhap.gia + "')";
            thucthiSQL(sql);
            return true;
        }
        public bool xoactNhap(string xoa)
        {
            string sql = "delete from ctPhieunhap where ctPhieunhapID = N'" + xoa + "'";
            thucthiSQL(sql);
            return true;
        }
        public bool cnSL(string ma, int soluong)
        {
            _con.Open();
            string updateSoLuongQuery = "UPDATE sach SET soluong = soluong + @SoLuong WHERE sachID = @MaSach";
            SqlCommand cmd = new SqlCommand(updateSoLuongQuery, _con);
            cmd.Parameters.AddWithValue("@SoLuong", soluong);
            cmd.Parameters.AddWithValue("@MaSach", ma);
            cmd.ExecuteNonQuery();
            _con.Close();
            return true;
        }

        public bool cnTT(string ma, float tt)
        {
            _con.Open();
            string updateTongTienQuery = "UPDATE phieunhap SET tongsotien = tongsotien + @TongTien WHERE phieunhapID = @MaPhieuNhap";
            SqlCommand cmd = new SqlCommand(updateTongTienQuery, _con);
            cmd.Parameters.AddWithValue("@TongTien", tt);
            cmd.Parameters.AddWithValue("@MaPhieuNhap", ma);
            cmd.ExecuteNonQuery();
            _con.Close();
            return true;
        }


        //
        
    }
}
