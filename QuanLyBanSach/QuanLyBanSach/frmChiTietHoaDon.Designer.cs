namespace QuanLyBanSach
{
    partial class frmChiTietHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            cboNhanVien = new ComboBox();
            cboKhachHang = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cboSach = new ComboBox();
            numDonGiaBan = new NumericUpDown();
            numSoLuongBan = new NumericUpDown();
            btnXoa = new Button();
            btnXacNhanBan = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            btnInHoaDon = new Button();
            btnLuuHoaDon = new Button();
            btnThoat = new Button();
            ID = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1113, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(panel1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 150);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1113, 458);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết hóa đơn";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXacNhanBan);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(numSoLuongBan);
            panel1.Controls.Add(numDonGiaBan);
            panel1.Controls.Add(cboSach);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1107, 126);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 46);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên lập (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 97);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 1;
            label2.Text = "Khách hàng (*):";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(229, 46);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(314, 33);
            cboNhanVien.TabIndex = 2;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(229, 97);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(314, 33);
            cboKhachHang.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 7);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 0;
            label3.Text = "Tên sách (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 48);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 1;
            label4.Text = "Đơn giá bán (*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(499, 48);
            label5.Name = "label5";
            label5.Size = new Size(147, 25);
            label5.TabIndex = 2;
            label5.Text = "Số lượng bán (*):";
            // 
            // cboSach
            // 
            cboSach.FormattingEnabled = true;
            cboSach.Location = new Point(162, 7);
            cboSach.Name = "cboSach";
            cboSach.Size = new Size(314, 33);
            cboSach.TabIndex = 4;
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Location = new Point(197, 48);
            numDonGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(279, 31);
            numDonGiaBan.TabIndex = 11;
            numDonGiaBan.ThousandsSeparator = true;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Location = new Point(652, 48);
            numSoLuongBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(266, 31);
            numSoLuongBan.TabIndex = 12;
            numSoLuongBan.ThousandsSeparator = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(947, 63);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(140, 41);
            btnXoa.TabIndex = 27;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.Location = new Point(947, 16);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(140, 41);
            btnXacNhanBan.TabIndex = 28;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnLuuHoaDon);
            panel2.Controls.Add(btnInHoaDon);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 383);
            panel2.Name = "panel2";
            panel2.Size = new Size(1107, 72);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, TenSach, DonGiaBan, SoLuongBan, ThanhTien });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 153);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1107, 230);
            dataGridView1.TabIndex = 2;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(377, 22);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(132, 41);
            btnInHoaDon.TabIndex = 29;
            btnInHoaDon.Text = "In hóa đơn...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.Location = new Point(530, 22);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(147, 41);
            btnLuuHoaDon.TabIndex = 28;
            btnLuuHoaDon.Text = "Lưu hóa đơn...";
            btnLuuHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(702, 22);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(102, 41);
            btnThoat.TabIndex = 30;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 60;
            // 
            // TenSach
            // 
            TenSach.DataPropertyName = "TenSach";
            TenSach.HeaderText = "Tên sách";
            TenSach.MinimumWidth = 8;
            TenSach.Name = "TenSach";
            TenSach.ReadOnly = true;
            // 
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            DonGiaBan.DefaultCellStyle = dataGridViewCellStyle4;
            DonGiaBan.HeaderText = "Đơn giá bán";
            DonGiaBan.MinimumWidth = 8;
            DonGiaBan.Name = "DonGiaBan";
            DonGiaBan.ReadOnly = true;
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            SoLuongBan.DefaultCellStyle = dataGridViewCellStyle5;
            SoLuongBan.HeaderText = "Số lượng bán";
            SoLuongBan.MinimumWidth = 8;
            SoLuongBan.Name = "SoLuongBan";
            SoLuongBan.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Blue;
            dataGridViewCellStyle6.Format = "N0";
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle6;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 8;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // frmChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 608);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmChiTietHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết hóa đơn";
            Load += frmChiTietHoaDon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboSach;
        private ComboBox cboKhachHang;
        private ComboBox cboNhanVien;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private NumericUpDown numDonGiaBan;
        private NumericUpDown numSoLuongBan;
        private Button btnXacNhanBan;
        private Button btnXoa;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btnInHoaDon;
        private Button btnLuuHoaDon;
        private Button btnThoat;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}