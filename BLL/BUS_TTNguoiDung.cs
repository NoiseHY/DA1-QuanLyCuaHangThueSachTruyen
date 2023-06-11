using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace BLL
{
    public class BUS_TTNguoiDung
    {
        DAL_TTNguoiDung DAL_TTNguoiDung = new DAL_TTNguoiDung();
        public DataTable getTT(string username)
        {
            
            return DAL_TTNguoiDung.getTT(username);
        }
        public bool suaTT(DTO_TTNguoiDung dTO_TTNguoiDung)
        {

            return DAL_TTNguoiDung.suaTT(dTO_TTNguoiDung);
        }
    }
}
