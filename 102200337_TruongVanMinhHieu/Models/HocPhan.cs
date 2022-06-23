using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102200337_TruongVanMinhHieu.Models {
    public class HocPhan {
        [Key]
        public string MaHocPhan { get; set; }
        public string TenHocPhan { get; set; }

        public virtual ICollection<SinhVien> sinhViens { get; set; }
    }
}
