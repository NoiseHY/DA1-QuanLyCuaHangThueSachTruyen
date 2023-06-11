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
    public class BUS_TKPN
    {
        DAL_TKPN DAL_TKPN = new DAL_TKPN();
        public DataTable getID(DTO_TKPN dTO_TKPN)
        {
            
            return DAL_TKPN.getID(dTO_TKPN);
        }
        public DataTable getNgay(DTO_TKPN dTO_TKPN)
        {
            
            return DAL_TKPN.getNgay(dTO_TKPN);
        }
        public DataTable getCT(DTO_TKPN dTO_TKPN)
        {

            return DAL_TKPN.getCT(dTO_TKPN);
        }
        public DataTable getSach(DTO_TKPN dTO_TKPN)
        {
            
            return DAL_TKPN.getSach(dTO_TKPN);
        }
        public DataTable getNCC(DTO_TKPN dTO_TKPN)
        {
            
            return DAL_TKPN.getNCC(dTO_TKPN);
        }
        public DataTable getGia(float gia)
        {
            
            return DAL_TKPN.getGia(gia);
        }
        public DataTable getTC()
        {
           
            return DAL_TKPN.getTC();
        }
    }
}
