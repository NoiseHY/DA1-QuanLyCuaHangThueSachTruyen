using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NguoiDung
    {
        public string maND { get; set; }
        public string tenND { get; set; }
        public string mkND { get; set; }
        public string hvtND { get; set; }
        public string sdt { get; set; }
        public string dcND { get; set; }
        public string emailND { get; set; }
        public string quyenND { get; set; }
        public DTO_NguoiDung() { }
        public DTO_NguoiDung(string maND, string tenND, string mkND, string hvtND, string sdt, string dcND, string emailND, string quyenND)
        {
            this.maND = maND;
            this.tenND = tenND;
            this.mkND = mkND;
            this.hvtND = hvtND;
            this.sdt = sdt;
            this.dcND = dcND;
            this.emailND = emailND;
            this.quyenND = quyenND;
        }
    }
}
