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
    public class BUS_TheLoai
    {
        DAL_TheLoai DAL_TheLoai = new DAL_TheLoai();
        public DataTable getTL()
        {
            
            return DAL_TheLoai.getTL();
        }
        public int ktra(string ma)
        {
            
            return DAL_TheLoai.ktra(ma);
        }

        public bool themTL(DTO_TheLoai dTO_TheLoai)
        {
            
            return DAL_TheLoai.themTL(dTO_TheLoai);
        }
        public bool suaTL(DTO_TheLoai dTO_TheLoai)
        {

            return DAL_TheLoai.suaTL(dTO_TheLoai);
        }
        public bool xoaTL(string ma)
        {
            
            return DAL_TheLoai.xoaTL(ma);
        }
        public int ktraT(string ma)
        {
            
            return DAL_TheLoai.ktraT(ma);
        }
    }
}
