using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DMK
    {
        public string username { get; set; }
        public string mkc { get; set; }
        public string NLmkc { get; set; }
        public string mkm { get; set; }
        public string NLmkm { get; set; }
        public DTO_DMK() { }
        public DTO_DMK(string username,string mkc,string NLmkc, string mkm, string NLmkm)
        {
            this.username = username;
            this.mkc = mkc;
            this.NLmkc = NLmkc;
            this.mkm = mkm;
            this.NLmkm = NLmkm;
        }
    }
}
