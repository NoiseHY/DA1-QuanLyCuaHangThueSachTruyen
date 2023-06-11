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
    public class BUS_TimKiemSach
    {
        DAL_TimKiemSach DAL_TimKiemSach = new DAL_TimKiemSach();
        public DataTable getSach(DTO_TimKiemSach dTO_TimKiemSach)
        {
            
            return DAL_TimKiemSach.getSach(dTO_TimKiemSach);
        }
        public DataTable getNgay(DTO_TimKiemSach dTO_TimKiemSach)
        {
            
            return DAL_TimKiemSach.getNgay(dTO_TimKiemSach);
        }
        public DataTable getTG(DTO_TimKiemSach dTO_TimKiemSach)
        {
           
            return DAL_TimKiemSach.getTG(dTO_TimKiemSach);
        }
        public DataTable getNN(DTO_TimKiemSach dTO_TimKiemSach)
        {
           
            return DAL_TimKiemSach.getNN(dTO_TimKiemSach);
        }
        public DataTable getNXB(DTO_TimKiemSach dTO_TimKiemSach)
        {
            
            return DAL_TimKiemSach.getNXB(dTO_TimKiemSach);
        }
        public DataTable getTen(DTO_TimKiemSach dTO_TimKiemSach)
        {
            
            return DAL_TimKiemSach.getTen(dTO_TimKiemSach);
        }
        public DataTable getTL(DTO_TimKiemSach dTO_TimKiemSach)
        {
            
            return DAL_TimKiemSach.getTL(dTO_TimKiemSach);
        }
        public DataTable getSl(int so)
        {
            
            return DAL_TimKiemSach.getSl(so);
        }
        public DataTable getST(float so)
        {
            
            return DAL_TimKiemSach.getST(so);
        }
        public DataTable getTC()
        {
            
            return DAL_TimKiemSach.getTC();
        }
    }
}
