using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TKPN
    {
        public string MaChinh { get; set; }
        public DateTime NgayNhap { get; set; }
        
        public DTO_TKPN() { }

        public DTO_TKPN(string maChinh, DateTime ngayNhap)
        {
            MaChinh = maChinh;
            NgayNhap = ngayNhap;
        }
    }
}
