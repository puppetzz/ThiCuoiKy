using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102200337_TruongVanMinhHieu.DTO {
    public class SinhVienViewDTO {
        public string MSSV { get; set; }
        public int STT { get; set; }
        public string TenSV { get; set; }
        public string LopSH { get; set; }
        public string TenHocPhan { get; set; }
        public double DiemBT { get; set; }
        public double DiemGK { get; set; }
        public double DiemCK { get; set; }
        public double TongKet { get; set; }
        public DateTime NgayThi { get; set; }
    }
}
