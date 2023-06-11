using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TTNguoiDung
    {
        public string tenuser { get; set; }
        public string tenDD { get; set; }
        public string email { get; set; }
        public string sdt { get; set; }
        public string diachi { get; set; }
        public DTO_TTNguoiDung() { }
        public DTO_TTNguoiDung( string tenuser,string tenDD, string email, string sdt, string diachi)
        {
            this.tenuser = tenuser;
            this.email = email;
            this.sdt = sdt;
            this.diachi = diachi;
            this.tenDD = tenDD;
        }
    }
}
