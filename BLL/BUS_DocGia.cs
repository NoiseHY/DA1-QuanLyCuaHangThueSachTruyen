using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;


namespace BLL
{
    public class BUS_DocGia
    {
        DAL_DocGia dalDocgia = new DAL_DocGia();
        public DataTable getDocGia()
        {
            return dalDocgia.getDocGia();
        }
        public int ktra(string ma)
        {
            return dalDocgia.ktra(ma);
        }
        public bool themDocgia(DTO_DocGia docGia)
        {
            return dalDocgia.themDocgia(docGia);
        }
        public bool xoaDocgia(string ma)
        {
            return dalDocgia.xoaDocgia(ma) ;
        }
        public bool suaDocgia(DTO_DocGia docGia)
        {
            return dalDocgia.suaDocgia(docGia) ;
        }
    }
}
