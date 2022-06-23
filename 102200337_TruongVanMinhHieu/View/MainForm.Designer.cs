namespace _102200337_TruongVanMinhHieu.View {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.hocPhanComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LopSH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemBT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemGK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongKet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.seachButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học Phần";
            // 
            // hocPhanComboBox
            // 
            this.hocPhanComboBox.FormattingEnabled = true;
            this.hocPhanComboBox.Location = new System.Drawing.Point(172, 31);
            this.hocPhanComboBox.Name = "hocPhanComboBox";
            this.hocPhanComboBox.Size = new System.Drawing.Size(252, 32);
            this.hocPhanComboBox.TabIndex = 1;
            this.hocPhanComboBox.SelectedIndexChanged += new System.EventHandler(this.hocPhanComboBox_SelectedIndexChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(747, 34);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(237, 29);
            this.searchTextBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.STT,
            this.TenSV,
            this.LopSH,
            this.TenHocPhan,
            this.DiemBT,
            this.DiemGK,
            this.DiemCK,
            this.TongKet,
            this.NgayThi});
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1651, 364);
            this.dataGridView1.TabIndex = 3;
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "Mã Số Sinh Viên";
            this.MSSV.MinimumWidth = 9;
            this.MSSV.Name = "MSSV";
            this.MSSV.Visible = false;
            this.MSSV.Width = 175;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 9;
            this.STT.Name = "STT";
            this.STT.Width = 175;
            // 
            // TenSV
            // 
            this.TenSV.DataPropertyName = "TenSV";
            this.TenSV.HeaderText = "Tên SV";
            this.TenSV.MinimumWidth = 9;
            this.TenSV.Name = "TenSV";
            this.TenSV.Width = 175;
            // 
            // LopSH
            // 
            this.LopSH.DataPropertyName = "LopSH";
            this.LopSH.HeaderText = "Lớp SH";
            this.LopSH.MinimumWidth = 9;
            this.LopSH.Name = "LopSH";
            this.LopSH.Width = 175;
            // 
            // TenHocPhan
            // 
            this.TenHocPhan.DataPropertyName = "TenHocPhan";
            this.TenHocPhan.HeaderText = "Tên Học Phần";
            this.TenHocPhan.MinimumWidth = 9;
            this.TenHocPhan.Name = "TenHocPhan";
            this.TenHocPhan.Width = 175;
            // 
            // DiemBT
            // 
            this.DiemBT.DataPropertyName = "DiemBT";
            this.DiemBT.HeaderText = "Điểm BT";
            this.DiemBT.MinimumWidth = 9;
            this.DiemBT.Name = "DiemBT";
            this.DiemBT.Width = 175;
            // 
            // DiemGK
            // 
            this.DiemGK.DataPropertyName = "DiemGK";
            this.DiemGK.HeaderText = "Điểm GK";
            this.DiemGK.MinimumWidth = 9;
            this.DiemGK.Name = "DiemGK";
            this.DiemGK.Width = 175;
            // 
            // DiemCK
            // 
            this.DiemCK.DataPropertyName = "DiemCK";
            this.DiemCK.HeaderText = "Điểm CK";
            this.DiemCK.MinimumWidth = 9;
            this.DiemCK.Name = "DiemCK";
            this.DiemCK.Width = 175;
            // 
            // TongKet
            // 
            this.TongKet.DataPropertyName = "TongKet";
            this.TongKet.HeaderText = "Tổng Kết";
            this.TongKet.MinimumWidth = 9;
            this.TongKet.Name = "TongKet";
            this.TongKet.Width = 175;
            // 
            // NgayThi
            // 
            this.NgayThi.DataPropertyName = "NgayThi";
            this.NgayThi.HeaderText = "NgayThi";
            this.NgayThi.MinimumWidth = 9;
            this.NgayThi.Name = "NgayThi";
            this.NgayThi.Width = 175;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(70, 478);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(141, 41);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(273, 478);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(141, 41);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(481, 478);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(141, 41);
            this.delButton.TabIndex = 8;
            this.delButton.Text = "Del";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(683, 478);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(141, 41);
            this.sortButton.TabIndex = 9;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // sortComboBox
            // 
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Location = new System.Drawing.Point(881, 483);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(252, 32);
            this.sortComboBox.TabIndex = 10;
            // 
            // seachButton
            // 
            this.seachButton.Location = new System.Drawing.Point(1009, 29);
            this.seachButton.Name = "seachButton";
            this.seachButton.Size = new System.Drawing.Size(141, 41);
            this.seachButton.TabIndex = 11;
            this.seachButton.Text = "Search";
            this.seachButton.UseVisualStyleBackColor = true;
            this.seachButton.Click += new System.EventHandler(this.seachButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1675, 561);
            this.Controls.Add(this.seachButton);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.hocPhanComboBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hocPhanComboBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LopSH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemGK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongKet;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThi;
        private System.Windows.Forms.Button seachButton;
    }
}