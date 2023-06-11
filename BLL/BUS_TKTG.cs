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
    public class BUS_TKTG
    {
        DAL_TKTG DAL_TKTG = new DAL_TKTG();
        public DataTable getTG(DTO_TKTG dTO_TKTG)
        {
            
            return DAL_TKTG.getTG(dTO_TKTG);
        }

        public DataTable getTen(DTO_TKTG dTO_TKTG)
        {
            
            return DAL_TKTG.getTen(dTO_TKTG);
        }
        public DataTable getQt(DTO_TKTG dTO_TKTG)
        {
            
            return DAL_TKTG.getQt(dTO_TKTG);
        }
        public DataTable getNamS(int nam)
        {
            
            return DAL_TKTG.getNamS(nam);
        }
        public DataTable getNamM(int nam)
        {
            
            return DAL_TKTG.getNamM(nam);
        }
        public DataTable getTC()
        {
            
            return DAL_TKTG.getTC();
        }
    }
}
