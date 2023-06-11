using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DangNhap
    {
        public string username { get; set; }
        public string password { get; set; }
        public DTO_DangNhap() { }
        public DTO_DangNhap(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
