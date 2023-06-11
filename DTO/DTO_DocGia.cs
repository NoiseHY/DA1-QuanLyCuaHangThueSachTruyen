using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DocGia
    {
        public string maDocgia { get; set; }
        public string tenDocgia { get; set; }
        public string diachi { get; set; }
        public string email { get; set; }
        public string sdt { get; set; }
        public DateTime ngaysinh { get; set; }
        // Hàm khởi tạo không tham số
        public DTO_DocGia()
        {

        }
        // Hàm khởi tạo có đối số
        public DTO_DocGia(string maDocgia, string tenDocgia, string diachi, string email, string sdt, DateTime ngaysinh)
        {
            this.maDocgia = maDocgia;
            this.tenDocgia = tenDocgia;
            this.diachi = diachi;
            this.email = email;
            this.sdt = sdt;
            this.ngaysinh = ngaysinh;
        }  
    }
}
