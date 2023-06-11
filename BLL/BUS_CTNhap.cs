using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class BUS_CTNhap
    {
        DAL_CTNhap DAL_CTNhap = new DAL_CTNhap();
        public DataTable getData(string ma)
        {
            
            return DAL_CTNhap.getData(ma);
        }
        public DataTable getSach()
        {
            
            return DAL_CTNhap.getSach();
        }
        public bool themctNhap(DTO_CTNhap dTO_CTNhap)
        {
            
            return DAL_CTNhap.themctNhap(dTO_CTNhap);
        }
        public DataTable getMasach()
        {

            return DAL_CTNhap.getMasach();
        }
       
        public int ktractNhap(string mactnhap)
        {

            return DAL_CTNhap.ktractNhap(mactnhap);
        }

        public bool xoactNhap(string xoa)
        {
            return DAL_CTNhap.xoactNhap(xoa);
        }
        public bool cnSL(string ma, int soluong)
        {
            return DAL_CTNhap.cnSL(ma, soluong);
        }
        public bool cnTT(string ma, float tt)
        {
            return DAL_CTNhap.cnTT(ma, tt);
        }
    }
}
