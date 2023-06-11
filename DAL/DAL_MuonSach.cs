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
    public class DAL_MuonSach:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getDocGia( )
        {
            _con.Open();
            da = new SqlDataAdapter("select * from docgia", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getTBDG(string ma)
        {
            _con.Open();
            da = new SqlDataAdapter("select * from docgia where docgiaID = N'"+ma+"'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;

        }
        public DataTable getHD()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from muontra ", _con);
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
        public int ktra(string maHD)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from muontra where muontraID =N'" + maHD.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        
        public bool themHD(DTO_MuonSach dTO_MuonSach)
        {
            string ngayM = string.Format("{0}/{1}/{2}", dTO_MuonSach.ngayMuon.Year, dTO_MuonSach.ngayMuon.Month, dTO_MuonSach.ngayMuon.Day);
            string ngayT = string.Format("{0}/{1}/{2}", dTO_MuonSach.ngayTra.Year, dTO_MuonSach.ngayTra.Month, dTO_MuonSach.ngayTra.Day);
            string sql = "insert into muontra values(N'" + dTO_MuonSach.ma + "', N'" + dTO_MuonSach.maDG + "', '" +ngayM + "', '" + ngayT + "')";
            thucthiSQL(sql);
            return true;
        }
        public bool xoa(string ma)
        {
            string sql = "delete from muontra where muontraID = N'" + ma + "'";
            thucthiSQL(sql);
            return true;
        }
        public bool CanhCaoVaCamMuonDocGia(string docgiaID)
        {
            //
            bool success = false;
            try
            {
                _con.Open();

                // Kiểm tra trạng thái cảnh cáo của độc giả
                SqlCommand checkCmd = new SqlCommand("SELECT daCanhCao FROM docgia WHERE docgiaID = @docgiaID", _con);
                // Thêm tham số
                checkCmd.Parameters.AddWithValue("@docgiaID", docgiaID);
                bool daCanhCao = (bool)checkCmd.ExecuteScalar();

                if (daCanhCao)
                {
                    // Đã cảnh cáo trước đó, thực hiện cấm mượn
                    SqlCommand cmd = new SqlCommand("UPDATE docgia SET biCamMuon = 1 WHERE docgiaID = @docgiaID", _con);
                    cmd.Parameters.AddWithValue("@docgiaID", docgiaID);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    // Chưa cảnh cáo trước đó, thực hiện cảnh cáo
                    SqlCommand cmd = new SqlCommand("UPDATE docgia SET daCanhCao = 1 WHERE docgiaID = @docgiaID", _con);
                    cmd.Parameters.AddWithValue("@docgiaID", docgiaID);
                    cmd.ExecuteNonQuery();
                }

                success = true;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần thiết
            }
            finally
            {
                _con.Close();
            }
            return success;
        }
        //
        public int trangthai(string maHD)
        {
            _con.Open();

            int status = 2;

            string sql = "SELECT daCanhCao, biCamMuon FROM docgia WHERE docgiaID = @DocGiaID";
            cmd = new SqlCommand(sql, _con);
            cmd.Parameters.AddWithValue("@DocGiaID", maHD.Trim());

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                bool daCanhCao = (bool)reader["daCanhCao"];
                bool biCamMuon = (bool)reader["biCamMuon"];

                if (daCanhCao)
                {
                    status = 0;
                }

                if (biCamMuon)
                {
                    status = 1;
                }
            }

            reader.Close();
            _con.Close();

            return status;
        }


    }
}
