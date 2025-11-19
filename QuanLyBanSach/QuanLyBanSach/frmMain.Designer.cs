namespace QuanLyBanSach
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            mnuNhaXuatBan = new ToolStripMenuItem();
            mnuTacGia = new ToolStripMenuItem();
            mnuSach = new ToolStripMenuItem();
            mnuTheLoai = new ToolStripMenuItem();
            mnuHoaDon = new ToolStripMenuItem();
            mnuBaoCaoThongKe = new ToolStripMenuItem();
            mnuThongKeSanPham = new ToolStripMenuItem();
            mnuThongKeDoanhThu = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuThongTinPhanMem = new ToolStripMenuItem();
            mnuHuongDanSuDung = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuBaoCaoThongKe, mnuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1082, 57);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.AutoSize = false;
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuThoat });
            mnuHeThong.Image = Properties.Resources.gears;
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(150, 53);
            mnuHeThong.Text = "Hệ thống";
            mnuHeThong.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(224, 34);
            mnuDangNhap.Text = "Đăng nhập";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(224, 34);
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(224, 34);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.AutoSize = false;
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuNhanVien, mnuKhachHang, mnuNhaXuatBan, mnuTacGia, mnuSach, mnuTheLoai, mnuHoaDon });
            mnuQuanLy.Image = Properties.Resources.workplace;
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(150, 53);
            mnuQuanLy.Text = "Quản lý";
            mnuQuanLy.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(270, 34);
            mnuNhanVien.Text = "Nhân viên...";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(270, 34);
            mnuKhachHang.Text = "Khách hàng...";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuNhaXuatBan
            // 
            mnuNhaXuatBan.Name = "mnuNhaXuatBan";
            mnuNhaXuatBan.Size = new Size(270, 34);
            mnuNhaXuatBan.Text = "Nhà xuất bản...";
            mnuNhaXuatBan.Click += mnuNhaXuatBan_Click;
            // 
            // mnuTacGia
            // 
            mnuTacGia.Name = "mnuTacGia";
            mnuTacGia.Size = new Size(270, 34);
            mnuTacGia.Text = "Tác giả...";
            mnuTacGia.Click += mnuTacGia_Click;
            // 
            // mnuSach
            // 
            mnuSach.Name = "mnuSach";
            mnuSach.Size = new Size(270, 34);
            mnuSach.Text = "Sách";
            mnuSach.Click += mnuSach_Click;
            // 
            // mnuTheLoai
            // 
            mnuTheLoai.Name = "mnuTheLoai";
            mnuTheLoai.Size = new Size(270, 34);
            mnuTheLoai.Text = "Thể loại...";
            mnuTheLoai.Click += mnuTheLoai_Click;
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(270, 34);
            mnuHoaDon.Text = "Hóa đơn...";
            mnuHoaDon.Click += mnuHoaDon_Click;
            // 
            // mnuBaoCaoThongKe
            // 
            mnuBaoCaoThongKe.AutoSize = false;
            mnuBaoCaoThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeSanPham, mnuThongKeDoanhThu });
            mnuBaoCaoThongKe.Image = Properties.Resources.document_edit;
            mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            mnuBaoCaoThongKe.Size = new Size(182, 53);
            mnuBaoCaoThongKe.Text = "Báo cáo - Thống kê";
            mnuBaoCaoThongKe.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // mnuThongKeSanPham
            // 
            mnuThongKeSanPham.Name = "mnuThongKeSanPham";
            mnuThongKeSanPham.Size = new Size(287, 34);
            mnuThongKeSanPham.Text = "Thống kê sản phẩm...";
            // 
            // mnuThongKeDoanhThu
            // 
            mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            mnuThongKeDoanhThu.Size = new Size(287, 34);
            mnuThongKeDoanhThu.Text = "Thống kê doanh thu...";
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.AutoSize = false;
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuThongTinPhanMem, mnuHuongDanSuDung });
            mnuTroGiup.Image = Properties.Resources.wrench;
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(150, 53);
            mnuTroGiup.Text = "Trợ giúp";
            mnuTroGiup.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // mnuThongTinPhanMem
            // 
            mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
            mnuThongTinPhanMem.Size = new Size(346, 34);
            mnuThongTinPhanMem.Text = "Thông tin phần mềm...";
            // 
            // mnuHuongDanSuDung
            // 
            mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            mnuHuongDanSuDung.ShortcutKeys = Keys.Control | Keys.F1;
            mnuHuongDanSuDung.Size = new Size(346, 34);
            mnuHuongDanSuDung.Text = "Hướng dẫn sử dụng";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, lblLienKet });
            statusStrip1.Location = new Point(0, 578);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1082, 32);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(148, 25);
            lblTrangThai.Text = "Chưa đăng nhập.";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(686, 25);
            toolStripStatusLabel1.Spring = true;
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(187, 25);
            lblLienKet.Text = "© Khoa CNTT - ĐHAG";
            lblLienKet.Click += lblLienKet_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 610);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblLienKet;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuBaoCaoThongKe;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuNhaXuatBan;
        private ToolStripMenuItem mnuTacGia;
        private ToolStripMenuItem mnuSach;
        private ToolStripMenuItem mnuTheLoai;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripMenuItem mnuThongKeSanPham;
        private ToolStripMenuItem mnuThongKeDoanhThu;
        private ToolStripMenuItem mnuThongTinPhanMem;
        private ToolStripMenuItem mnuHuongDanSuDung;
    }
}