using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhaXuatBan
    {
        public string maNXB { get; set; }
        public string tenNXB { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        public DTO_NhaXuatBan() { }
        public DTO_NhaXuatBan(string maNXB, string tenNXB, string diachi, string sdt, string email)
        {
            this.maNXB = maNXB;
            this.tenNXB = tenNXB;
            this.diachi = diachi;
            this.sdt = sdt;
            this.email = email;
        }
    }
}
