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
    public class BUS_TacGia
    {
        DAL_TacGia tacGia = new DAL_TacGia();
        public DataTable getTacGia()
        {
           
            return tacGia.getTacGia();
        }
        
        public int ktra(string ma)
        {
            
            return tacGia.ktra(ma);
        }
        public bool themTacgia(DTO_TacGia dTO_TacGia)
        {
            return tacGia.themTacgia(dTO_TacGia);
        }
        public bool suaTacgia(DTO_TacGia dTO_TacGia)
        {
            return tacGia.suaTacgia(dTO_TacGia);
        }
        public bool xoaTacgia(string ma)
        {
            return tacGia.xoaTacgia(ma);
        }
    }
}
