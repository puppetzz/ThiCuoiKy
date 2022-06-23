using _102200337_TruongVanMinhHieu.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _102200337_TruongVanMinhHieu.DTO;

namespace _102200337_TruongVanMinhHieu.View {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            setHocPhanComboBox();
            sortComboBox.Items.AddRange(new string[] {
                "Mã sinh viên",
                "Tên sinh viên",
                "Lớp sinh hoạt"
            });
        }

        private void setHocPhanComboBox() {
            hocPhanComboBox.Items.Clear();
            hocPhanComboBox.Items.Add(new CBBItem {
                Value = "0",
                Text = "ALL"
            }); 
            hocPhanComboBox.Items.AddRange(QLSVBLL.Instance.GetAllLopHocPhan().ToArray());
        }

        public void ShowDTG() {
            int index = 1;
            CBBItem item = (CBBItem)hocPhanComboBox.SelectedItem;
            List<SinhVienViewDTO> sv = QLSVBLL.Instance
                .GetSinhVienViewByLopSinhHoat(item.Value, searchTextBox.Text.ToString());
            foreach (SinhVienViewDTO data in sv) {
                data.STT = index++;
            }

            dataGridView1.DataSource = sv;
        }

        private void hocPhanComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            ShowDTG();
        }

        private void seachButton_Click(object sender, EventArgs e) {
            ShowDTG();
        }

        private void delButton_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows) {
                QLSVBLL.Instance.DeleteSinhVien(row.Cells["MSSV"].Value.ToString());
            }
            ShowDTG();
        }

        private void sortButton_Click(object sender, EventArgs e) {
            if (hocPhanComboBox.SelectedIndex == -1)
                return;
            int index = 1;
            CBBItem item = (CBBItem)hocPhanComboBox.SelectedItem;
            List<SinhVienViewDTO> sv = QLSVBLL.Instance
                .sort(item.Value, searchTextBox.Text.ToString(), sortComboBox.SelectedItem.ToString());

            foreach (SinhVienViewDTO data in sv) {
                data.STT = index++;
            }
            dataGridView1.DataSource = sv;
        }
        
        private void addButton_Click(object sender, EventArgs e) {
            DetailForm detailForm = new DetailForm();
            detailForm.d = ShowDTG;
            detailForm.Show();
        }

        private void updateButton_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count != 1)
                return;

            DetailForm detailForm = new DetailForm(dataGridView1.SelectedRows[0].Cells["MSSV"].Value.ToString());
            detailForm.d = ShowDTG;
            detailForm.Show();
        }
    }
}
