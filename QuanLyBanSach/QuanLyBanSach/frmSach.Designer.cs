namespace QuanLyBanSach
{
    partial class frmSach
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            toolStrip1 = new ToolStrip();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cboTheLoai = new ComboBox();
            cboNhaXuatBan = new ComboBox();
            cboTacGia = new ComboBox();
            txtTenSach = new TextBox();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            picHinhAnh = new PictureBox();
            toolStripLabel1 = new ToolStripLabel();
            txtTuKhoa = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            dataGridView2 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenTheLoai = new DataGridViewTextBoxColumn();
            TenNhaXuatBan = new DataGridViewTextBoxColumn();
            TenTacGia = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(txtTenSach);
            groupBox1.Controls.Add(cboTacGia);
            groupBox1.Controls.Add(cboNhaXuatBan);
            groupBox1.Controls.Add(cboTheLoai);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1158, 301);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(toolStrip1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 301);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1158, 239);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh mục sách";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTuKhoa, btnTimKiem });
            toolStrip1.Location = new Point(3, 27);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1152, 34);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1152, 175);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 48);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "Thể loại (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 96);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 1;
            label2.Text = "Nhà xuất bản (*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 185);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên sách (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 141);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 3;
            label4.Text = "Tác giả (*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(458, 38);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 4;
            label5.Text = "Đơn giá (*):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(458, 96);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 5;
            label6.Text = "Số lượng (*):";
            // 
            // cboTheLoai
            // 
            cboTheLoai.FormattingEnabled = true;
            cboTheLoai.Location = new Point(186, 45);
            cboTheLoai.Name = "cboTheLoai";
            cboTheLoai.Size = new Size(254, 33);
            cboTheLoai.TabIndex = 6;
            // 
            // cboNhaXuatBan
            // 
            cboNhaXuatBan.FormattingEnabled = true;
            cboNhaXuatBan.Location = new Point(186, 93);
            cboNhaXuatBan.Name = "cboNhaXuatBan";
            cboNhaXuatBan.Size = new Size(254, 33);
            cboNhaXuatBan.TabIndex = 7;
            // 
            // cboTacGia
            // 
            cboTacGia.FormattingEnabled = true;
            cboTacGia.Location = new Point(186, 141);
            cboTacGia.Name = "cboTacGia";
            cboTacGia.Size = new Size(254, 33);
            cboTacGia.TabIndex = 8;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(186, 185);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(570, 31);
            txtTenSach.TabIndex = 9;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(576, 38);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(180, 31);
            numDonGia.TabIndex = 10;
            numDonGia.ThousandsSeparator = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(576, 96);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(180, 31);
            numSoLuong.TabIndex = 11;
            numSoLuong.ThousandsSeparator = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(770, 243);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(102, 41);
            btnThoat.TabIndex = 29;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(662, 243);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(102, 41);
            btnHuyBo.TabIndex = 28;
            btnHuyBo.Text = "Hủy";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(554, 243);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(102, 41);
            btnLuu.TabIndex = 27;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(402, 243);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(102, 41);
            btnXoa.TabIndex = 26;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(294, 243);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(102, 41);
            btnSua.TabIndex = 25;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(186, 243);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(102, 41);
            btnThem.TabIndex = 24;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(837, 38);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(150, 171);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 30;
            picHinhAnh.TabStop = false;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(88, 29);
            toolStripLabel1.Text = "Tìm kiếm:";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(200, 34);
            txtTuKhoa.KeyDown += txtTuKhoa_KeyDown;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = Properties.Resources.view;
            btnTimKiem.ImageTransparentColor = Color.Magenta;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(69, 29);
            btnTimKiem.Text = "Tìm";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ID, TenTheLoai, TenNhaXuatBan, TenTacGia, TenSach, SoLuong, DonGia, HinhAnh });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 61);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1152, 175);
            dataGridView2.TabIndex = 2;
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
            // TenTheLoai
            // 
            TenTheLoai.DataPropertyName = "TenTheLoai";
            TenTheLoai.HeaderText = "Thể loại";
            TenTheLoai.MinimumWidth = 8;
            TenTheLoai.Name = "TenTheLoai";
            TenTheLoai.ReadOnly = true;
            // 
            // TenNhaXuatBan
            // 
            TenNhaXuatBan.DataPropertyName = "TenNhaXuatBan";
            TenNhaXuatBan.HeaderText = "Nhà xuất bản";
            TenNhaXuatBan.MinimumWidth = 8;
            TenNhaXuatBan.Name = "TenNhaXuatBan";
            TenNhaXuatBan.ReadOnly = true;
            // 
            // TenTacGia
            // 
            TenTacGia.DataPropertyName = "TenTacGia";
            TenTacGia.HeaderText = "Tác giả";
            TenTacGia.MinimumWidth = 8;
            TenTacGia.Name = "TenTacGia";
            TenTacGia.ReadOnly = true;
            // 
            // TenSach
            // 
            TenSach.DataPropertyName = "TenSach";
            TenSach.HeaderText = "Tên sách";
            TenSach.MinimumWidth = 8;
            TenSach.Name = "TenSach";
            TenSach.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            SoLuong.DefaultCellStyle = dataGridViewCellStyle7;
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 8;
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            DonGia.DefaultCellStyle = dataGridViewCellStyle8;
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 8;
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.MinimumWidth = 8;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.ReadOnly = true;
            // 
            // frmSach
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 540);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sách";
            Load += frmSach_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private NumericUpDown numSoLuong;
        private NumericUpDown numDonGia;
        private TextBox txtTenSach;
        private ComboBox cboTacGia;
        private ComboBox cboNhaXuatBan;
        private ComboBox cboTheLoai;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private PictureBox picHinhAnh;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btnTimKiem;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenTheLoai;
        private DataGridViewTextBoxColumn TenNhaXuatBan;
        private DataGridViewTextBoxColumn TenTacGia;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewImageColumn HinhAnh;
    }
}