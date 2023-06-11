using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace BLL
{
    public class BUS_NguoiDung
    {
        // Lấy dữ liệu từ DAL lên
        DAL_NguoiDung dalnd = new DAL_NguoiDung();
        public DataTable getNguoiDung()
        {
            return dalnd.getNguoiDung();
        }
        public int ktra(string ma)
        {
            return dalnd.ktra(ma);
        }
        public int ktraND(string maND)
        {
            
            return dalnd.ktraND(maND);
        }
        public bool themND(DTO_NguoiDung nguoiDung)
        {
            return dalnd.themND(nguoiDung);
        }
        public bool xoaND(string nguoiDung)
        {
            return dalnd.xoaND(nguoiDung);
        }
        public bool suaND(DTO_NguoiDung nguoiDung)
        {
            return dalnd.suaND(nguoiDung);
        }
    }
}
