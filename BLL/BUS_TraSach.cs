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
    public class BUS_TraSach
    {
        DAL_TraSach DAL_TraSach = new DAL_TraSach();
        public bool sua(DTO_TraSach dTO_TraSach)
        {
            return DAL_TraSach.sua(dTO_TraSach);
        }
        public DataTable getSachMuon(string ma)
        {
            
            return DAL_TraSach.getSachMuon(ma);

        }
        public DataTable getsltra(string ma)
        {
            
            return DAL_TraSach.getsltra(ma);
        }
        public bool CapNhatSoLuong(DTO_TraSach dTO_TraSach)
        {

            return DAL_TraSach.CapNhatSoLuong(dTO_TraSach);
        }
    }
}
