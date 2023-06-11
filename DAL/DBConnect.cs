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
    // Dùng chung thì vứt vào DB connect

    public class DBConnect
    {
        protected SqlConnection _con = new SqlConnection(@"Data Source=Pc-NguyễnNam;Initial Catalog=quanlisach;Integrated Security=True");
        //          
    }
}
