using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThongKe
    {
        public string nam { get; set; }
        public DTO_ThongKe() { }
        public DTO_ThongKe(string nam)
        {
            this.nam = nam;
        }
    }
}
