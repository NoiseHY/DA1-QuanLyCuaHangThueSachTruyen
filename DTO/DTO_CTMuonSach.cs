using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTMuonSach
    {
        public string ma { get; set; }
        public string maCT { get; set; }
        public string maS { get; set; }
        public int slm { get; set; }
        public DTO_CTMuonSach(string ma, string maCT, string maS, int slm)
        {
            this.ma = ma;
            this.maCT = maCT;
            this.maS = maS;
            this.slm = slm;
        }
    }
}
