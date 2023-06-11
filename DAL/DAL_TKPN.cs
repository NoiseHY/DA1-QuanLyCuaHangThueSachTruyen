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
    public class DAL_TKPN:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getID(DTO_TKPN dTO_TKPN)
        {
            _con.Open();
            SqlCommand cmd = new SqlCommand("select * from phieunhap where phieunhapID = N'" + dTO_TKPN.MaChinh + "'", _con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getNgay(DTO_TKPN dTO_TKPN)
        {
            string ngay = string.Format("{0}/{1}/{2}", dTO_TKPN.NgayNhap.Year, dTO_TKPN.NgayNhap.Month, dTO_TKPN.NgayNhap.Day);
            _con.Open();
            SqlCommand cmd = new SqlCommand("select * from phieunhap where ngayNhaphoadon = '" + ngay + "'", _con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getCT(DTO_TKPN dTO_TKPN)
        {
            _con.Open();
            da = new SqlDataAdapter($"SELECT * FROM ctPhieunhap WHERE ctPhieunhapID = N'"+dTO_TKPN.MaChinh+"'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getSach(DTO_TKPN dTO_TKPN)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM ctPhieunhap WHERE sachID = N'"+dTO_TKPN.MaChinh +"'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getNCC(DTO_TKPN dTO_TKPN)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM phieunhap WHERE nhacungcapID = N'"+dTO_TKPN.MaChinh +"'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getGia(float gia)
        {
            _con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ctPhieunhap WHERE giabanle = @gia", _con);
            cmd.Parameters.AddWithValue("@gia", gia);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getTC()
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT phieunhap.phieunhapID, phieunhap.nhacungcapID, phieunhap.ngayNhaphoadon, phieunhap.tongsotien, ctPhieunhap.soluong, ctPhieunhap.giabanle\r\nFROM phieunhap\r\nINNER JOIN ctPhieunhap ON phieunhap.phieunhapID = ctPhieunhap.phieunhapID ORDER BY phieunhap.phieunhapID, ctPhieunhap.sachID", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
    }
}
