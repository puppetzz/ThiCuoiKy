using _102200337_TruongVanMinhHieu.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace _102200337_TruongVanMinhHieu {
    public class DataContext : DbContext {
        public DataContext()
            : base("name=DataContext") {
        }

        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<HocPhan> HocPhan { get; set; }
    }
}