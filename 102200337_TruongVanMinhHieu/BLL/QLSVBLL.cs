using _102200337_TruongVanMinhHieu.DTO;
using _102200337_TruongVanMinhHieu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102200337_TruongVanMinhHieu.BLL {
    public class QLSVBLL {
        private DataContext _context;

        private static QLSVBLL _instance;
        public static QLSVBLL Instance {
            get {
                if (_instance == null)
                    _instance = new QLSVBLL();
                return _instance;
            }
            private set { }
        }

        private QLSVBLL() {
            _context = new DataContext();
        }

        public List<CBBItem> GetAllLopHocPhan() {
            List<CBBItem> result = _context.HocPhan
                .Select(h => new CBBItem {
                    Value = h.MaHocPhan,
                    Text = h.TenHocPhan
                }).ToList();
            return result;
        }
        

        public List<SinhVienViewDTO> GetSinhVienViewByLopSinhHoat(string maHocPhan, string searchText) {
            List<SinhVienViewDTO> result = new List<SinhVienViewDTO>();
            if (maHocPhan == "0") {
                result = _context.SinhViens
                .Where(s => (s.TenSinhVien + s.MaSinhVien).Contains(searchText))
                .Select(s => new SinhVienViewDTO {
                    MSSV = s.MaSinhVien,
                    TenSV = s.TenSinhVien,
                    LopSH = s.LopSinhHoat,
                    TenHocPhan = s.HocPhan.TenHocPhan,
                    DiemBT = s.DiemBaiTap,
                    DiemGK = s.DiemGiuaKy,
                    DiemCK = s.DiemCuoiKy,
                    TongKet = s.DiemBaiTap * 0.2 + s.DiemGiuaKy * 0.2 + s.DiemCuoiKy * 0.3,
                    NgayThi = s.NgayThi
                }).ToList();
            } else {
                result = _context.SinhViens
                .Where(s => s.HocPhan.MaHocPhan == maHocPhan
                && (s.TenSinhVien + s.MaSinhVien).Contains(searchText))
                .Select(s => new SinhVienViewDTO {
                    MSSV = s.MaSinhVien,
                    TenSV = s.TenSinhVien,
                    LopSH = s.LopSinhHoat,
                    TenHocPhan = s.HocPhan.TenHocPhan,
                    DiemBT = s.DiemBaiTap,
                    DiemGK = s.DiemGiuaKy,
                    DiemCK = s.DiemCuoiKy,
                    TongKet = s.DiemBaiTap * 0.2 + s.DiemGiuaKy * 0.2 + s.DiemCuoiKy * 0.3,
                    NgayThi = s.NgayThi
                }).ToList();
            }
            return result;
        }

        public double TinhDiemTongKet(double DiemBT, double DiemGK, double DiemCK) {
            return DiemBT * 0.2 + DiemGK * 0.2 * DiemCK * 0.3;
        }

        public void DeleteSinhVien(string maSinhVien) {
            var sinhVien = _context.SinhViens
                .FirstOrDefault(s => s.MaSinhVien == maSinhVien);

            if (sinhVien == null) 
                return;

            _context.SinhViens.Remove(sinhVien);
            _context.SaveChanges();
        }

        public List<SinhVienViewDTO> sort(string maHocPhan, string searchText, string option) {
            List<SinhVienViewDTO> result = GetSinhVienViewByLopSinhHoat(maHocPhan, searchText);

            if (option == "Mã sinh viên")
                result = result.OrderBy(r => r.MSSV).ToList();
            if (option == "Tên sinh viên")
                result = result.OrderBy(r => r.TenSV).ToList();
            if (option == "Lớp sinh hoạt")
                result = result.OrderBy(r => r.LopSH).ToList();
            return result;
        }

        public List<string> GetALLLSH() {
            var lsh = _context.SinhViens.Select(s => s.LopSinhHoat).ToList();
            return lsh;
        }

        public bool IsAdd(string maSinhVien) {
            Console.WriteLine(maSinhVien);
            if (_context.SinhViens.Any(s => s.MaSinhVien == maSinhVien))
                return false;
            return true;
        }

        public void ExcuteDatabase(SinhVien newSinhVien) {
            if (IsAdd(newSinhVien.MaSinhVien)) { 
                _context.SinhViens.Add(newSinhVien);
                _context.SaveChanges();
                return;
            }

            var sinhVien = _context.SinhViens
                .FirstOrDefault(s => s.MaSinhVien == newSinhVien.MaSinhVien);

            sinhVien.TenSinhVien = newSinhVien.TenSinhVien;
            sinhVien.LopSinhHoat = newSinhVien.LopSinhHoat;
            sinhVien.GioiTinh = newSinhVien.GioiTinh;
            sinhVien.DiemBaiTap = newSinhVien.DiemBaiTap;
            sinhVien.DiemGiuaKy = newSinhVien.DiemGiuaKy;
            sinhVien.DiemCuoiKy = newSinhVien.DiemCuoiKy;
            sinhVien.NgayThi = newSinhVien.NgayThi;
            sinhVien.MaHocPhan = newSinhVien.MaHocPhan;

            _context.SaveChanges();
        }

        public SinhVien GetSinhVienByMSSV(string MSSV) {
            var sinhVien = _context.SinhViens
                .FirstOrDefault(s => s.MaSinhVien == MSSV);
            return sinhVien;
        }
    }
}
