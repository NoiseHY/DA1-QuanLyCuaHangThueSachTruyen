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
    public class DAL_PhieuNhap:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getPhieunhap()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from phieunhap", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getCT(string ID)
        {
            _con.Open();
            da = new SqlDataAdapter($"select * from ctPhieunhap where phieunhapID = N'" + ID + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getMaNhap()
        {
            _con.Open();
            da = new SqlDataAdapter($"select * from phieunhap ", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getMaNCC()
        {
            _con.Open();
            da = new SqlDataAdapter($"select * from nhacungcap ", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        
        public DataTable gettenNCC(string ID)
        {
            _con.Open();
            da = new SqlDataAdapter($"select * from nhacungcap where nhacungcapID = N'" + ID + "'", _con);
            dt = new DataTable();
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
        public int ktraNhap(string manhap)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from phieunhap where phieunhapID =N'" + manhap.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themNhap(DTO_PhieuNhap dTO_PhieuNhap)
        {          
            string ngayHT = string.Format("{0}/{1}/{2}", dTO_PhieuNhap.ngayNhap.Year, dTO_PhieuNhap.ngayNhap.Month, dTO_PhieuNhap.ngayNhap.Day);
            string sql = "insert into phieunhap values(N'" + dTO_PhieuNhap.maNhap + "', N'" + dTO_PhieuNhap.maNCC + "', '" + ngayHT + "', '" + dTO_PhieuNhap.tongtien + "')";
            thucthiSQL(sql);
            return true;
        }
        
        public bool suaNhap(DTO_PhieuNhap dTO_PhieuNhap)
        {
            string ngayHT = string.Format("{0}/{1}/{2}", dTO_PhieuNhap.ngayNhap.Year, dTO_PhieuNhap.ngayNhap.Month, dTO_PhieuNhap.ngayNhap.Day);
            string sql = "update phieunhap set phieunhapID = N'" + dTO_PhieuNhap.maNhap + "', nhacungcapID = N'" + dTO_PhieuNhap.maNCC + "', ngayNhaphoadon = '" + ngayHT + "', tongsotien='" + dTO_PhieuNhap.tongtien + "'where phieunhapID = N'" + dTO_PhieuNhap + "'";
            thucthiSQL(sql);
            return true;
        }
        public bool xoaNhap(string xoa)
        {
            string sql = "delete from phieunhap where phieunhapID = N'" + xoa + "'";
            thucthiSQL(sql);
            return true;
        }
    }
}
