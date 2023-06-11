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
    public class DAL_Info:DBConnect
    {
        DataTable dt;
        SqlDataAdapter da;
        public DataTable geten()
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
