using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TacGia
    {
        public string maTG { get; set; }
        public string tenTG { get; set; }
        public int namsinh { get; set; }
        public string quoctich { get; set; }
        public DTO_TacGia() { }
        public DTO_TacGia(string maTG, string tenTG, int namsinh, string quoctich)
        {
            this.maTG = maTG;
            this.tenTG = tenTG;
            this.namsinh = namsinh;
            this.quoctich = quoctich;
        }
    }
}
