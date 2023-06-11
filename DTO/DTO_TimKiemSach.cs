using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DTO
{
    public class DTO_TimKiemSach
    {
        public string MaChinh { get; set; }
        public DateTime Ngay { get; set; }

        public DTO_TimKiemSach() { }

        public DTO_TimKiemSach(string maChinh, DateTime ngay)
        {
            MaChinh = maChinh;
            Ngay = ngay;
        }
    }
}
