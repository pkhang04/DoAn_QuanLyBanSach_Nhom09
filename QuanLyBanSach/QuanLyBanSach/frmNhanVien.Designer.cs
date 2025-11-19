namespace QuanLyBanSach
{
    partial class frmNhanVien
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
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboQuyenHan = new ComboBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            txtDiaChi = new TextBox();
            txtDienThoai = new TextBox();
            txtHoVaTen = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTuKhoa = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(998, 307);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(703, 231);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(102, 41);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(595, 231);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(102, 41);
            btnHuyBo.TabIndex = 16;
            btnHuyBo.Text = "Hủy";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(487, 231);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(102, 41);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(335, 231);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(102, 41);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(227, 231);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(102, 41);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(119, 231);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(102, 41);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản trị viên", "Quản lý sách" });
            cboQuyenHan.Location = new Point(594, 159);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(191, 33);
            cboQuyenHan.TabIndex = 11;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(594, 109);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(191, 31);
            txtMatKhau.TabIndex = 10;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(594, 57);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(191, 31);
            txtTenDangNhap.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(147, 162);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(246, 31);
            txtDiaChi.TabIndex = 8;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(147, 106);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(246, 31);
            txtDienThoai.TabIndex = 7;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(147, 57);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(246, 31);
            txtHoVaTen.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(432, 162);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 5;
            label6.Text = "Quyền hạn (*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(432, 109);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 4;
            label5.Text = "Mật khẩu (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(432, 57);
            label4.Name = "label4";
            label4.Size = new Size(156, 25);
            label4.TabIndex = 3;
            label4.Text = "Tên đăng nhập (*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 162);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 109);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "Điện thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 57);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ tên (*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(toolStrip1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 307);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(998, 247);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi, TenDangNhap, QuyenHan });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 61);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(992, 183);
            dataGridView1.TabIndex = 1;
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
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ tên";
            HoVaTen.MinimumWidth = 8;
            HoVaTen.Name = "HoVaTen";
            HoVaTen.ReadOnly = true;
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 8;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 8;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.MinimumWidth = 8;
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.ReadOnly = true;
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.HeaderText = "Quyền hạn";
            QuyenHan.MinimumWidth = 8;
            QuyenHan.Name = "QuyenHan";
            QuyenHan.ReadOnly = true;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTuKhoa, btnTimKiem });
            toolStrip1.Location = new Point(3, 27);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(992, 34);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
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
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 554);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân viên";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btnTimKiem;
        private ComboBox cboQuyenHan;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private TextBox txtDiaChi;
        private TextBox txtDienThoai;
        private TextBox txtHoVaTen;
        private DataGridView dataGridView1;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
    }
}