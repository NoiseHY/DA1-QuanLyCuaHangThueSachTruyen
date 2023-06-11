using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_DocGia:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        // Hiển thị danh sách độc giả ra ngoài màn hình 
        public DataTable getDocGia()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from docgia", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        void thucthisql(string sql)
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
            string sql = "select count (*) from docgia where docgiaID =N'"+ma.Trim()+"'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close() ;
            return i;
        }
        public bool themDocgia(DTO_DocGia docgia)
        {
            string ngay = string.Format("{0}/{1}/{2}", docgia.ngaysinh.Year, docgia.ngaysinh.Month, docgia.ngaysinh.Day);
            string sql = "insert into docgia values (N'"+docgia.maDocgia+"', N'"+docgia.tenDocgia+"', N'"+docgia.diachi+"', '"+docgia.email+"', '"+docgia.sdt+"', '"+ngay+"' , '','')";
            thucthisql(sql); return true;
        }
        public bool suaDocgia(DTO_DocGia docgia)
        {
            string ngay = string.Format("{0}/{1}/{2}", docgia.ngaysinh.Year, docgia.ngaysinh.Month, docgia.ngaysinh.Day);
            string sql = "UPDATE docgia SET docgiaID =N'"+docgia.maDocgia+"', tenDaydu = N'" + docgia.tenDocgia + "', diachi = N'" + docgia.diachi + "', email = '" + docgia.email + "', sodienthoai = '" + docgia.sdt + "', ngaysinh = '" + ngay + "' , daCanhCao = '', biCamMuon ='' WHERE docgiaID = N'" + docgia.maDocgia + "'";
            thucthisql(sql); return true;   
        }
        public bool xoaDocgia(string ma)
        {
            string sql = "delete from docgia where docgiaID = N'" + ma + "'";
            thucthisql(sql); return true;   
        }
    }
}
