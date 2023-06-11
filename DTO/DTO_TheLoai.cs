using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TheLoai
    {
        public string maTL { get; set; }
        public string tenTl { get; set; }
        public string mota { get; set; }
        public DTO_TheLoai() { }    
        public DTO_TheLoai(string maTL, string tenTl, string mota)
        {
            this.maTL = maTL;
            this.tenTl = tenTl;
            this.mota = mota;
        }
    }
}
