using _102200337_TruongVanMinhHieu.BLL;
using _102200337_TruongVanMinhHieu.DTO;
using _102200337_TruongVanMinhHieu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _102200337_TruongVanMinhHieu.View {
    public partial class DetailForm : Form {
        public delegate void MyDel();
        public MyDel d;

        private string _maSinhVien;
        public DetailForm(string maSinhVien = "") {
            InitializeComponent();
            setLopSH();
            setHocPhan();
            _maSinhVien = maSinhVien;
            GUI();
        }

        private void GUI() {
            MessageBox.Show(_maSinhVien);
            if (QLSVBLL.Instance.IsAdd(_maSinhVien))
                return;

            SinhVien sinhVien = QLSVBLL.Instance.GetSinhVienByMSSV(_maSinhVien);

            MSSVTextBox.Text = _maSinhVien;
            MSSVTextBox.Enabled = false;
            nameTextBox.Text = sinhVien.TenSinhVien;
            lopSHComboBox.Text = sinhVien.LopSinhHoat;
            hocPhanComboBox.Text = sinhVien.HocPhan.TenHocPhan;
            maleRadioButton.Checked = sinhVien.GioiTinh;
            femaleRadioButton.Checked = !sinhVien.GioiTinh;
            dateTimePicker1.Value = sinhVien.NgayThi;
            diemBTTextBox.Text = sinhVien.DiemBaiTap.ToString();
            diemGKTextBox.Text = sinhVien.DiemGiuaKy.ToString();
            diemCKextBox.Text = sinhVien.DiemCuoiKy.ToString();
            TongKetTextBox.Enabled = false;
            TongKetTextBox.Text = (sinhVien.DiemBaiTap * 0.2 + sinhVien.DiemGiuaKy * 0.2 + sinhVien.DiemCuoiKy * 0.3).ToString();
        }

        private void setLopSH() {
            lopSHComboBox.Items.Clear();
            lopSHComboBox.Items.AddRange(QLSVBLL.Instance.GetALLLSH().Distinct().ToArray());
        }

        private void setHocPhan() {
            hocPhanComboBox.Items.Clear();
            hocPhanComboBox.Items.AddRange(QLSVBLL.Instance.GetAllLopHocPhan().ToArray());
        }

        private void okButton_Click(object sender, EventArgs e) {
            CBBItem item = (CBBItem)hocPhanComboBox.SelectedItem;
            SinhVien sinhVien = new SinhVien {
                MaSinhVien = MSSVTextBox.Text,
                TenSinhVien = nameTextBox.Text,
                LopSinhHoat = lopSHComboBox.Text,
                GioiTinh = maleRadioButton.Checked,
                DiemBaiTap = Convert.ToDouble(diemBTTextBox.Text),
                DiemCuoiKy = Convert.ToDouble(diemCKextBox.Text),
                DiemGiuaKy = Convert.ToDouble(diemGKTextBox.Text),
                NgayThi = dateTimePicker1.Value,
                MaHocPhan = item.Value,
            };
            QLSVBLL.Instance.ExcuteDatabase(sinhVien);
            d();
            this.Dispose();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Dispose();
        }
    }
}
