using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BUS_Info
    {
        DAL_Info dAL_Info = new DAL_Info();
        public DataTable geten()
        {
            
            
            return dAL_Info.geten();


        }
    }
}
