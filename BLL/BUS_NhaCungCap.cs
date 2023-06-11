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
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap DAL_NhaCungCap = new DAL_NhaCungCap();
        public DataTable getNCC()
        {
            
            return DAL_NhaCungCap.getNCC();
        }
        
        public int ktra(string ma)
        {
            
            return DAL_NhaCungCap.ktra(ma);
        }
        public bool them(DTO_NhaCungCap dTO_NhaCungCap)
        {
            return DAL_NhaCungCap.them(dTO_NhaCungCap);
        }
        public bool sua(DTO_NhaCungCap dTO_NhaCungCap)
        {
            return DAL_NhaCungCap.sua(dTO_NhaCungCap);
        }
        public bool xoa(string ma)
        {
            return DAL_NhaCungCap.xoa(ma);
        }
    }
}
