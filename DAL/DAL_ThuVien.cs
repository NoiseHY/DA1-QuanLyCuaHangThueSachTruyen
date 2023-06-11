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
    public class DAL_ThuVien:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getThuVien()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from sach", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable gettenTL(string maTL)
        {
            _con.Open();
            da = new SqlDataAdapter($"select * from theloai where theloaiID =N'"+maTL+"'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable gettenNXB(string maMXB)
        {
            _con.Open();
            da = new SqlDataAdapter($"select * from nhaxuatban where nhaxuatbanID = N'"+maMXB+"'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable gettenTG(string maTG)
        {
            _con.Open();
            da = new SqlDataAdapter($"select * from tacgia where tacgiaID = N'"+maTG+"'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getTL()
        {
            _con.Open();
            da = new SqlDataAdapter($"select * from theloai ", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getNXB()
        {
            _con.Open();
            da = new SqlDataAdapter($"select * from nhaxuatban ", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getTG()
        {
            _con.Open();
            da = new SqlDataAdapter($"select * from tacgia ", _con);
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
        public int ktra(string maSach)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from sach where sachID =N'" + maSach.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themSach(DTO_ThuVien thuVien)
        {
            string ngay = string.Format("{0}/{1}/{2}", thuVien.ngayXB.Year, thuVien.ngayXB.Month, thuVien.ngayXB.Day);
            string sql = "insert into sach values(N'" + thuVien.maSach + "', N'" + thuVien.tenSach + "', '" + thuVien.soTrang + "', '" + thuVien.giaTien + "', '" + ngay + "', '" + thuVien.soluong + "', N'" + thuVien.maTL + "', N'" + thuVien.maTG + "', N'" + thuVien.maNXB + "', N'" + thuVien.ngonNgu + "')";
            thucthiSQL(sql);
            return true;
        }
        public bool suaSach(DTO_ThuVien thuVien)
        {
            string ngay = string.Format("{0}/{1}/{2}", thuVien.ngayXB.Year, thuVien.ngayXB.Month, thuVien.ngayXB.Day);
            string sql = "update sach set tenSach= N'" + thuVien.tenSach + "',sotrang= '" + thuVien.soTrang + "',giatien= '" + thuVien.giaTien + "',ngayxuatban= '" + ngay + "',soluong= '" + thuVien.soluong + "',theloaiID= N'" + thuVien.maTL + "',tacgiaID= N'" + thuVien.maTG + "',nhaxuatbanID= N'" + thuVien.maNXB + "',ngonngu= N'" + thuVien.ngonNgu + "' where sachID = N'" + thuVien.maSach + "'";
            thucthiSQL(sql);
            return true;
        }


        public bool xoaSach(string maSach)
        {
            string sql = "delete from sach where sachID = N'" + maSach + "'";
            thucthiSQL(sql);
            return true;    
        }
        void canhcao()
        {
            _con.Open();
        }
    }
}
