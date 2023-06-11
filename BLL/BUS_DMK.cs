using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BUS_DMK
    {
        DAL_DMK DAL_DMK = new DAL_DMK();
        public bool doiMK(DTO_DMK dTO_DMK)
        {
            return DAL_DMK.DoiMatKhau(dTO_DMK);
        }
        public bool checkMK(DTO_DMK dto_DMK)
        {
            if (dto_DMK.mkc == dto_DMK.NLmkc)
                return true;
            else
                return false;
        }
        public bool checkMKM(DTO_DMK dto_DMK)
        {
            if (dto_DMK.mkm == dto_DMK.NLmkm)
                return true;
            else
                return false;
        }
    }
}
