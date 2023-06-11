using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MuonSach
    {
        public string ma { get; set; }
        public string maDG { get; set; }
        public DateTime ngayTra { get; set; }
        public DateTime ngayMuon { get; set; }
        public DTO_MuonSach(string ma, string maDG, DateTime ngayTra, DateTime ngayMuon)
        {
            this.ma = ma;
            this.maDG = maDG;
            this.ngayTra = ngayTra;
            this.ngayMuon = ngayMuon;
        }
    }
}
