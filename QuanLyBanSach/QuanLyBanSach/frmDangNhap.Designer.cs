namespace QuanLyBanSach
{
    partial class frmDangNhap
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnHuyBo = new Button();
            pictureBox1 = new PictureBox();
            chkHienMatKhau = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(664, 66);
            label1.Name = "label1";
            label1.Size = new Size(207, 36);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(616, 138);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(616, 227);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(625, 166);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(283, 31);
            txtTenDangNhap.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(625, 255);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(283, 31);
            txtMatKhau.TabIndex = 5;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(618, 343);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(141, 49);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(778, 343);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(141, 49);
            btnHuyBo.TabIndex = 7;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.shop;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(526, 526);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Location = new Point(628, 302);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(178, 29);
            chkHienMatKhau.TabIndex = 9;
            chkHienMatKhau.Text = "Hiển thị mật khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 526);
            Controls.Add(chkHienMatKhau);
            Controls.Add(pictureBox1);
            Controls.Add(btnHuyBo);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += frmDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnDangNhap;
        private Button btnHuyBo;
        private PictureBox pictureBox1;
        private CheckBox chkHienMatKhau;
        public TextBox txtTenDangNhap;
        public TextBox txtMatKhau;
    }
}