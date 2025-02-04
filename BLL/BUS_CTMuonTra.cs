﻿using System;
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
    public class BUS_CTMuonTra
    {
        DAL_CTMuonSach DAL_CTMuonSach = new DAL_CTMuonSach();
        public DataTable getTV()
        {
            return DAL_CTMuonSach.getTV();
        }
        public DataTable getSachMuon(string ma)
        {
            return DAL_CTMuonSach.getSachMuon(ma);

        }
        public int ktra(string ma)
        {
            return DAL_CTMuonSach.ktra(ma);
        }
        public bool them(DTO_CTMuonSach dTO_CTMuonSach)
        {
            return DAL_CTMuonSach.them(dTO_CTMuonSach);
        }
        public bool xoa(string ma)
        {
            return DAL_CTMuonSach.xoa(ma);
        }
    }
}
