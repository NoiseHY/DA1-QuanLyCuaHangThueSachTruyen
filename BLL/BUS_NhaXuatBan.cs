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
    public class BUS_NhaXuatBan
    {
        DAL_NhaXuatBan DAL_NhaXuatBan = new DAL_NhaXuatBan();
        public DataTable getNXB()
        {
           
            return DAL_NhaXuatBan.getNXB();
        }
        
        public int ktra(string ma)
        {
           
            return DAL_NhaXuatBan.ktra(ma);
        }
        public bool them(DTO_NhaXuatBan dTO_NhaXuatBan)
        {
            return DAL_NhaXuatBan.them(dTO_NhaXuatBan);
        }
        public bool sua(DTO_NhaXuatBan dTO_NhaXuatBan)
        {
            return DAL_NhaXuatBan.sua(dTO_NhaXuatBan);
        }
        public bool xoa(string ma)
        {
            return DAL_NhaXuatBan.xoa(ma);
        }
    }
}
