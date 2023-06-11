using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThuVien
    {
        public string maSach { get; set; }
        public string tenSach { get; set; }
        public string soTrang { get; set; }
        public float giaTien { get; set; }
        public DateTime ngayXB { get; set; }
        public int soluong { get; set; }
        public string ngonNgu { get; set; }
        public string maTL { get; set; }
        public string maTG { get; set; }
        public string maNXB { get; set; }
        public DTO_ThuVien() { }    
        public DTO_ThuVien(string maSach, string tenSach, string soTrang, float giaTien, DateTime ngayXB, int soluong, string ngonNgu, string maTL, string maTG, string maNXB)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.soTrang = soTrang;
            this.giaTien = giaTien;
            this.ngayXB = ngayXB;
            this.soluong = soluong;
            this.ngonNgu = ngonNgu;
            this.maTL = maTL;
            this.maTG = maTG;
            this.maNXB = maNXB;
        }
    }
}
