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
    public class DAL_TimKiemSach:DBConnect
    {
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getSach(DTO_TimKiemSach dTO_TimKiemSach)
        {
            _con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM sach WHERE sachID = N'"+dTO_TimKiemSach.MaChinh+"'", _con);           
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getNgay(DTO_TimKiemSach dTO_TimKiemSach)
        {

            _con.Open();
            string ngay = string.Format("{0}/{1}/{2}", dTO_TimKiemSach.Ngay.Year, dTO_TimKiemSach.Ngay.Month, dTO_TimKiemSach.Ngay.Day);
            SqlCommand cmd = new SqlCommand("SELECT * FROM sach WHERE ngayxuatban = @Ngay", _con);
            cmd.Parameters.AddWithValue("@Ngay", Convert.ToDateTime(dTO_TimKiemSach.Ngay));
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getTG(DTO_TimKiemSach dTO_TimKiemSach)
        {
            _con.Open();
            da = new SqlDataAdapter($"SELECT * FROM sach WHERE tacgiaID = N'" + dTO_TimKiemSach.MaChinh + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getNN(DTO_TimKiemSach dTO_TimKiemSach)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM sach WHERE ngonngu = N'" + dTO_TimKiemSach.MaChinh + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getNXB(DTO_TimKiemSach dTO_TimKiemSach)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM sach WHERE nhaxuatbanID = N'" + dTO_TimKiemSach.MaChinh + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getTen(DTO_TimKiemSach dTO_TimKiemSach)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM sach WHERE tenSach like N'" + dTO_TimKiemSach.MaChinh + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getTL(DTO_TimKiemSach dTO_TimKiemSach)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM sach WHERE theloaiID = N'" + dTO_TimKiemSach.MaChinh + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getSl(int so)
        {
            _con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM sach WHERE soluong = @gia", _con);
            cmd.Parameters.AddWithValue("@gia", so);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getST(float so)
        {
            _con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM sach WHERE sotrang = @gia", _con);
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
            da = new SqlDataAdapter($"select * from sach", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
    }
}
