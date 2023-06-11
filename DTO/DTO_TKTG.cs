using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TKTG
    {
        public string tk { get; set; }
        public DTO_TKTG() { }
        public DTO_TKTG(string tk)
        {
            this.tk = tk;
        }
    }
}
