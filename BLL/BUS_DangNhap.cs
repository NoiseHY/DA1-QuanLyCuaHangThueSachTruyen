using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;
using System.Drawing;

namespace BLL
{
    public class BUS_DangNhap
    {
        DAL_DangNhap DAL_DangNhap = new DAL_DangNhap();
        public DataTable getData(string username, string password)
        {
            
            return DAL_DangNhap.getData(username, password);
        }
    }
}
