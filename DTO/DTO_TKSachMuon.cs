using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TKSachMuon
    {
        public string MaChinh { get; set; }
        public DateTime Ngay { get; set; }
        public DateTime ngayT { get; set; }
        public DTO_TKSachMuon() { }

       public DTO_TKSachMuon(string maChinh, DateTime ngay, DateTime ngayT)
        {
            MaChinh = maChinh;
            Ngay = ngay;
            this.ngayT = ngayT;
        }
    }
}
