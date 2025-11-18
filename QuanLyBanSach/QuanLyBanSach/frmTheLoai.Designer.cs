namespace QuanLyBanSach
{
    partial class frmTheLoai
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
            groupBox2 = new GroupBox();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            txtTenTheLoai = new TextBox();
            toolStrip1 = new ToolStrip();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenTheLoai = new DataGridViewTextBoxColumn();
            toolStripLabel1 = new ToolStripLabel();
            txtTuKhoa = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTenTheLoai);
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
            groupBox1.Size = new Size(800, 174);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thể loại sách";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(toolStrip1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 174);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 276);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh mục thể loại sách";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(639, 115);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(102, 41);
            btnThoat.TabIndex = 23;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(531, 115);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(102, 41);
            btnHuyBo.TabIndex = 22;
            btnHuyBo.Text = "Hủy";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(423, 115);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(102, 41);
            btnLuu.TabIndex = 21;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(271, 115);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(102, 41);
            btnXoa.TabIndex = 20;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(163, 115);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(102, 41);
            btnSua.TabIndex = 19;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(55, 115);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(102, 41);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 53);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 24;
            label1.Text = "Tên thể loại sách (*):";
            // 
            // txtTenTheLoai
            // 
            txtTenTheLoai.Location = new Point(236, 53);
            txtTenTheLoai.Name = "txtTenTheLoai";
            txtTenTheLoai.Size = new Size(505, 31);
            txtTenTheLoai.TabIndex = 25;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, TenTheLoai });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 61);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(794, 212);
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
            // TenTheLoai
            // 
            TenTheLoai.DataPropertyName = "TenTheLoai";
            TenTheLoai.HeaderText = "Tên thể loại sách";
            TenTheLoai.MinimumWidth = 8;
            TenTheLoai.Name = "TenTheLoai";
            TenTheLoai.ReadOnly = true;
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
            // frmTheLoai
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmTheLoai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thể loại";
            Load += frmTheLoai_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenTheLoai;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenTheLoai;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btnTimKiem;
    }
}