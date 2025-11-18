namespace QuanLyBanSach
{
    partial class frmTacGia
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
            btnTimKiem = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            toolStrip1 = new ToolStrip();
            txtTuKhoa = new ToolStripTextBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenTacGia = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            txtTenTacGia = new TextBox();
            label1 = new Label();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            groupBox1 = new GroupBox();
            txtDiaChi = new TextBox();
            label2 = new Label();
            btnSua = new Button();
            btnThem = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(88, 29);
            toolStripLabel1.Text = "Tìm kiếm:";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTuKhoa, btnTimKiem });
            toolStrip1.Location = new Point(3, 27);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(794, 34);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(200, 34);
            txtTuKhoa.KeyDown += txtTuKhoa_KeyDown;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, TenTacGia, DiaChi });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 61);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(794, 157);
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
            // TenTacGia
            // 
            TenTacGia.DataPropertyName = "TenTacGia";
            TenTacGia.HeaderText = "Tên tác giả";
            TenTacGia.MinimumWidth = 8;
            TenTacGia.Name = "TenTacGia";
            TenTacGia.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 8;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(toolStrip1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 229);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 221);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách tác giả";
            // 
            // txtTenTacGia
            // 
            txtTenTacGia.Location = new Point(183, 53);
            txtTenTacGia.Name = "txtTenTacGia";
            txtTenTacGia.Size = new Size(505, 31);
            txtTenTacGia.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 53);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 24;
            label1.Text = "Tên tác giả (*):";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(638, 158);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(102, 41);
            btnThoat.TabIndex = 23;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(530, 158);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(102, 41);
            btnHuyBo.TabIndex = 22;
            btnHuyBo.Text = "Hủy";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(422, 158);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(102, 41);
            btnLuu.TabIndex = 21;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(270, 158);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(102, 41);
            btnXoa.TabIndex = 20;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTenTacGia);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 229);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin tác giả";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(182, 103);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(505, 31);
            txtDiaChi.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 103);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 26;
            label2.Text = "Địa chỉ:";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(162, 158);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(102, 41);
            btnSua.TabIndex = 19;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(54, 158);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(102, 41);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // frmTacGia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmTacGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tác giả";
            Load += frmTacGia_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripButton btnTimKiem;
        private ToolStripLabel toolStripLabel1;
        private ToolStrip toolStrip1;
        private ToolStripTextBox txtTuKhoa;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private TextBox txtTenTacGia;
        private Label label1;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private GroupBox groupBox1;
        private TextBox txtDiaChi;
        private Label label2;
        private Button btnSua;
        private Button btnThem;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenTacGia;
        private DataGridViewTextBoxColumn DiaChi;
    }
}