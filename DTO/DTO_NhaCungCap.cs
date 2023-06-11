using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhaCungCap
    {
        public string maNCC { get; set; }
        public string tenCC { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        public DTO_NhaCungCap() { }
        public DTO_NhaCungCap(string maNCC, string tenCC, string diachi, string sdt, string email)
        {
            this.maNCC = maNCC;
            this.tenCC = tenCC;
            this.diachi = diachi;
            this.sdt = sdt;
            this.email = email;
        }
    }
}
