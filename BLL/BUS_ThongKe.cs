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
    public class BUS_ThongKe
    {
        DAL_ThongKe DAL_ThongKe = new DAL_ThongKe();
        public DataTable getSLm(DTO_ThongKe thongKe)
        {

            return DAL_ThongKe.getSLm(thongKe);
        }
        public DataTable getSLtra(DTO_ThongKe thongKe)
        {

            return DAL_ThongKe.getSLtra(thongKe);
        }
        public DataTable getTien(DTO_ThongKe dTO_ThongKe)
        {
            return DAL_ThongKe.getTien(dTO_ThongKe);
        }
    }
}
