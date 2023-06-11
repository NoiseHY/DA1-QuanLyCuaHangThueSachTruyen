using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class BUS_ThuVien
    {
        DAL_ThuVien dalthuVien = new DAL_ThuVien();
        public DataTable getSach()
        {
            return dalthuVien.getThuVien();
        }
        public DataTable gettenTL(string maTL)
        {
            return dalthuVien.gettenTL(maTL);
        }
        public DataTable gettenTG(string maTG)
        {
            return dalthuVien.gettenTG(maTG);
        }
        public DataTable gettenNXB(string maNXB)
        {
            return dalthuVien.gettenNXB(maNXB);
        }
        public DataTable getTL()
        {
            return dalthuVien.getTL();
        }
        public DataTable getTG()
        {
            return dalthuVien.getTG();
        }
        public DataTable getNXB()
        {
            return dalthuVien.getNXB();
        }
        public int ktra(string ma)
        {
            return dalthuVien.ktra(ma);
        }
        public bool themSach(DTO_ThuVien thuVien)
        {
            return dalthuVien.themSach(thuVien);
        }
        public bool suaSach(DTO_ThuVien thuVien)
        {
            return dalthuVien.suaSach(thuVien);
        }
        public bool xoaSach(string maSach)
        {
            return dalthuVien.xoaSach(maSach);
        }
    }
}
