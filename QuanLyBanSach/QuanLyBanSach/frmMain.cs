using QuanLyBanSach.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;
namespace QuanLyBanSach
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        QLBHDbContext context = new QLBHDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        frmNhaXuatBan? nhaXuatBan = null;
        frmTacGia? tacGia = null;
        frmTheLoai? theLoai = null;
        frmSach? sach = null;
        frmKhachHang? khachHang = null;
        frmNhanVien? nhanVien = null;
        frmHoaDon? hoaDon = null;
        string hoVaTenNhanVien = ""; // Lấy tên người dùng hiển thị vào thanh Status.
        frmDangNhap? dangNhap = null;

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaPhanQuyen();
            DangNhap();
        }
        private void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmDangNhap();
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.txtTenDangNhap.Text;
                string matKhau = dangNhap.txtMatKhau.Text;
                if (tenDangNhap.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    var nhanVien = context.NhanVien.Where(r => r.TenDangNhap == tenDangNhap).SingleOrDefault();
                    if (nhanVien == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        if (BC.Verify(matKhau, nhanVien.MatKhau))
                        {
                            hoVaTenNhanVien = nhanVien.HoVaTen;
                            if (nhanVien.QuyenHan == "Quản trị viên")
                                QuyenQuanLy();
                            else if (nhanVien.QuyenHan == "Quản lý sách")
                                QuyenNhanVienNhapSach();
                            else
                                ChuaPhanQuyen();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangNhap.txtMatKhau.Focus();
                            goto LamLai;
                        }
                    }
                }
            }
        }
        public void ChuaPhanQuyen()
        {
            // Sáng đăng nhập
            mnuDangNhap.Enabled = true;
            // Mờ tất cả
            mnuDangXuat.Enabled = false;

            mnuTheLoai.Enabled = false;
            mnuNhaXuatBan.Enabled = false;
            mnuTacGia.Enabled = false;
            mnuSach.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuHoaDon.Enabled = false;


            mnuThongKeSanPham.Enabled = false;
            mnuThongKeDoanhThu.Enabled = false;
            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Chưa đăng nhập.";
        }
        public void QuyenQuanLy()
        {
            // Mờ đăng nhập
            mnuDangNhap.Enabled = false;
            mnuDangXuat.Enabled = true;

            mnuTheLoai.Enabled = true;
            mnuNhaXuatBan.Enabled = true;
            mnuTacGia.Enabled = true;
            mnuSach.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = true;
            mnuHoaDon.Enabled = true;

            mnuThongKeSanPham.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;
            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Quản lý: " + hoVaTenNhanVien;
        }
        public void QuyenNhanVienNhapSach()
        {
            // Mờ đăng nhập
            mnuDangNhap.Enabled = false;
            // Mờ các chức năng nhân viên không được phép
            mnuTheLoai.Enabled = false;
            mnuNhaXuatBan.Enabled = false;
            mnuTacGia.Enabled = false;
            mnuNhanVien.Enabled = false;
            // Sáng đăng xuất và các chức năng nhân viên được phép
            mnuDangXuat.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuHoaDon.Enabled = true;
            mnuSach.Enabled = true;
            // Các chức năng không được phép
            mnuThongKeSanPham.Enabled = false;
            mnuThongKeDoanhThu.Enabled = false;
            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Nhân viên quản lý sách: " + hoVaTenNhanVien;
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaPhanQuyen();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
            else
                nhanVien.Activate();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            if (khachHang == null || khachHang.IsDisposed)
            {
                khachHang = new frmKhachHang();
                khachHang.MdiParent = this;
                khachHang.Show();
            }
            else
                khachHang.Activate();
        }

        private void mnuNhaXuatBan_Click(object sender, EventArgs e)
        {
            if (nhaXuatBan == null || nhaXuatBan.IsDisposed)
            {
                nhaXuatBan = new frmNhaXuatBan();
                nhaXuatBan.MdiParent = this;
                nhaXuatBan.Show();
            }
            else
                nhaXuatBan.Activate();
        }

        private void mnuTacGia_Click(object sender, EventArgs e)
        {
            if (tacGia == null || tacGia.IsDisposed)
            {
                tacGia = new frmTacGia();
                tacGia.MdiParent = this;
                tacGia.Show();
            }
            else
                tacGia.Activate();
        }

        private void mnuSach_Click(object sender, EventArgs e)
        {
            if (sach == null || sach.IsDisposed)
            {
                sach = new frmSach();
                sach.MdiParent = this;
                sach.Show();
            }
            else
                sach.Activate();
        }

        private void mnuTheLoai_Click(object sender, EventArgs e)
        {
            if (theLoai == null || theLoai.IsDisposed)
            {
                theLoai = new frmTheLoai();
                theLoai.MdiParent = this;
                theLoai.Show();
            }
            else
                theLoai.Activate();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            if (hoaDon == null || hoaDon.IsDisposed)
            {
                hoaDon = new frmHoaDon();
                hoaDon.MdiParent = this;
                hoaDon.Show();
            }
            else
                hoaDon.Activate();
        }

        private void lblLienKet_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://fit.agu.edu.vn";
            Process.Start(info);
        }
    }
}
