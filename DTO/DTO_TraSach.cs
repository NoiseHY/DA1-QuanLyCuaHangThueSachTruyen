using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TraSach
    {
        public string ma { get; set; }

        public int slt { get; set; }
        public DTO_TraSach(string ma, int slt)
        {
            this.ma = ma;
            this.slt = slt;
        }
    }
}
