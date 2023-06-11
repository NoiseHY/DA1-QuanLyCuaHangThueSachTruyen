using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTNhap
    {
        public string ctmaNhap { get; set; }
        public string maNhap { get; set; }

        public string maSach { get; set; }
        public int sl { get; set; }
        public float gia { get; set; }
        public DTO_CTNhap(string ctmaNhap,string maNhap ,string maSach, int sl, float gia)
        {
            this.ctmaNhap = ctmaNhap;
            this.maNhap = maNhap;
            this.maSach = maSach;
            this.sl = sl;
            this.gia = gia;
        }
    }
}
