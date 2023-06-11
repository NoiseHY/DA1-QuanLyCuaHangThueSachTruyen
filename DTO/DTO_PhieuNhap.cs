using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuNhap
    {
        public string maNhap { get; set; }
        public string maNCC { get; set; }
        public DateTime ngayNhap { get; set; }
        public float tongtien { get; set; }
        public DTO_PhieuNhap() { }
        public DTO_PhieuNhap(string maNhap, string maNCC, DateTime ngayNhap, float tongtien)
        {
            this.maNhap = maNhap;
            this.maNCC = maNCC;
            this.maNhap = maNhap;
            this.ngayNhap = ngayNhap;  
            this.tongtien = tongtien;
        }
    }
}
