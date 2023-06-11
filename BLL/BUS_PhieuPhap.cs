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
    public class BUS_PhieuPhap
    {
        DAL_PhieuNhap phieuNhap = new DAL_PhieuNhap();
        
        public DataTable getPhieunhap()
        {
            
            return phieuNhap.getPhieunhap();    
        }
        public DataTable getCT(string ID)
        {
            
            return phieuNhap.getCT(ID);
        }
        public DataTable getMaNhap()
        {
           
            return phieuNhap.getMaNhap();
        }
        public DataTable getMaNCC()
        {
           
            return phieuNhap.getMaNCC();
        }
        public DataTable gettenNCC(string ID)
        {
            
            return phieuNhap.gettenNCC(ID);
        }
       
        public int ktraNhap(string manhap)
        {
           
            return phieuNhap.ktraNhap(manhap);
        }
        public bool themNhap(DTO_PhieuNhap dTO_PhieuNhap)
        {
           
            return phieuNhap.themNhap(dTO_PhieuNhap);
        }
        public bool suaNhap(DTO_PhieuNhap dTO_PhieuNhap)
        {
            return phieuNhap.suaNhap(dTO_PhieuNhap);
        }
        public bool xoaNhap(string xoa)
        {
            return phieuNhap.xoaNhap(xoa);
        }
    }
}
