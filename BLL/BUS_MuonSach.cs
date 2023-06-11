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
    public class BUS_MuonSach
    {
        DAL_MuonSach DAL_MuonSach = new DAL_MuonSach();
        public DataTable getDocGia()
        {
            return DAL_MuonSach.getDocGia();
        }
        public DataTable getTBDG(string ma)
        {
            return DAL_MuonSach.getTBDG(ma);
        }
        public DataTable getHD()
        {
            return DAL_MuonSach.getHD();
        }
        public int ktra(string maHD)
        {
            return DAL_MuonSach.ktra(maHD);
        }
        public bool themHD(DTO_MuonSach dTO_MuonSach)
        {
            return DAL_MuonSach.themHD(dTO_MuonSach);
        }
        public bool xoa(string ma)
        {
            return DAL_MuonSach.xoa(ma);
        }
        public bool CanhCaoVaCamMuonDocGia(string docgiaID)
        {
            return DAL_MuonSach.CanhCaoVaCamMuonDocGia(docgiaID);
        }
        public int trangthai(string maHD)
        {
            return DAL_MuonSach.trangthai(maHD);
        }
    }
}
