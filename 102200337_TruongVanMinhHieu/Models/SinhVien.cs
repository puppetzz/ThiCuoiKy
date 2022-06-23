using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102200337_TruongVanMinhHieu.Models {
    public class SinhVien {
        [Key]
        public string MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
        public string LopSinhHoat { get; set; }
        public bool GioiTinh { get; set; }
        public double DiemBaiTap { get; set; }
        public double DiemGiuaKy { get; set; }
        public double DiemCuoiKy { get; set; }
        public DateTime NgayThi { get; set; }

        public string MaHocPhan { get; set; }
        [ForeignKey("MaHocPhan")]
        public virtual HocPhan HocPhan { get; set; }
    }
}
