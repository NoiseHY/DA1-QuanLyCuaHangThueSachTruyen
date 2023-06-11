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
    public class BUS_TKSachMuon
    {
        DAL_TKSachMuon DAL_TKSachMuon = new DAL_TKSachMuon();
        public DataTable get(DTO_TKSachMuon dTO_TKSachMuon)
        {

            return DAL_TKSachMuon.get(dTO_TKSachMuon);
        }
        public DataTable getNgayM(DTO_TKSachMuon dTO_TKSachMuon)
        {

            return DAL_TKSachMuon.getNgayM(dTO_TKSachMuon);
        }
        public DataTable getNgayT(DTO_TKSachMuon dTO_TKSachMuon)
        {

            return DAL_TKSachMuon.getNgayT(dTO_TKSachMuon);
        }
        public DataTable getCT(DTO_TKSachMuon dTO_TKSachMuon)
        {

            return DAL_TKSachMuon.getCT(dTO_TKSachMuon);
        }
        public DataTable getDG(DTO_TKSachMuon dTO_TKSachMuon)
        {

            return DAL_TKSachMuon.getDG(dTO_TKSachMuon);
        }
        public DataTable getMasach(DTO_TKSachMuon dTO_TKSachMuon)
        {

            return DAL_TKSachMuon.getMasach(dTO_TKSachMuon);
        }

        public DataTable getSlm(int so)
        {

            return DAL_TKSachMuon.getSlm(so);
        }
        public DataTable getSlt(float so)
        {
            
            return DAL_TKSachMuon.getSlt(so);
        }
        public DataTable getTC()
        {
            
            return DAL_TKSachMuon.getTC();
        }
    }
}
