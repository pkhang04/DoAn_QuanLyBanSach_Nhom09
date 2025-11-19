using QuanLyBanSach.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }
        QLBHDbContext context = new QLBHDbContext();
        int id;
        string imageName = "no-image.jpg";
        string imageFolder = Application.StartupPath.Replace("bin\\Debug\\net9.0-windows", "Image");
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            cboNhaXuatBan.Enabled = giaTri;
            cboTacGia.Enabled = giaTri;
            cboTheLoai.Enabled = giaTri;
            txtTenSach.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            
        }
        public void LayTheLoaiVaoComboBox()
        {
            cboTheLoai.DataSource = context.TheLoai.ToList();
            cboTheLoai.ValueMember = "ID";
            cboTheLoai.DisplayMember = "TenTheLoai";
        }

        public void LayNhaXuatBanVaoComboBox()
        {
            cboNhaXuatBan.DataSource = context.NhaXuatBan.ToList();
            cboNhaXuatBan.ValueMember = "ID";
            cboNhaXuatBan.DisplayMember = "TenNhaXuatBan";
        }
        public void LayTacGiaVaoComboBox()
        {
            cboTacGia.DataSource = context.TacGia.ToList();
            cboTacGia.ValueMember = "ID";
            cboTacGia.DisplayMember = "TenTacGia";
        }
        private void frmSach_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            LayTheLoaiVaoComboBox();
            LayNhaXuatBanVaoComboBox();
            LayTacGiaVaoComboBox();

            var sp = context.Sach.Select(r => new
            {
                r.ID,
                r.TheLoaiID,
                r.TheLoai.TenTheLoai,
                r.NhaXuatBanID,
                r.NhaXuatBan.TenNhaXuatBan,
                r.TacGiaID,
                r.TacGia.TenTacGia,
                r.TenSach,
                r.SoLuong,
                r.DonGia,
                r.HinhAnh
            }).ToList();
            dataGridView.DataSource = sp;

            cboTheLoai.DataBindings.Clear();
            cboTheLoai.DataBindings.Add("SelectedValue", sp, "TheLoaiID", false, DataSourceUpdateMode.Never);

            cboNhaXuatBan.DataBindings.Clear();
            cboNhaXuatBan.DataBindings.Add("SelectedValue", sp, "NhaXuatBanID", false, DataSourceUpdateMode.Never);

            cboTacGia.DataBindings.Clear();
            cboTacGia.DataBindings.Add("SelectedValue", sp, "TacGiaID", false, DataSourceUpdateMode.Never);

            txtTenSach.DataBindings.Clear();
            txtTenSach.DataBindings.Add("Text", sp, "TenSach", false, DataSourceUpdateMode.Never);

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", sp, "SoLuong", false, DataSourceUpdateMode.Never);

            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", sp, "DonGia", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", sp, "HinhAnh", false, DataSourceUpdateMode.Never);
            hinhAnh.Format += (s, e) =>
            {
                e.Value = Path.Combine(imageFolder, e.Value?.ToString() ?? "");
            };
            picHinhAnh.DataBindings.Add(hinhAnh);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var s = context.Sach

                .Select(r => new
                {
                    r.ID,
                    r.TheLoaiID,
                    r.TheLoai.TenTheLoai,
                    r.NhaXuatBanID,
                    r.NhaXuatBan.TenNhaXuatBan,
                    r.TacGiaID,
                    r.TacGia.TenTacGia,
                    r.TenSach,
                    r.SoLuong,
                    r.DonGia,
                    r.HinhAnh
                })
                .Where(r => r.TenSach.Contains(txtTuKhoa.Text) || r.TenTheLoai.Contains(txtTuKhoa.Text) || r.TenNhaXuatBan.Contains(txtTuKhoa.Text) || r.TenTacGia.Contains(txtTuKhoa.Text))
                .ToList();

            dataGridView.DataSource = s;
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            id = 0;
            cboTheLoai.Text = "";
            cboNhaXuatBan.Text = "";
            cboTacGia.Text = "";
            txtTenSach.Clear();

            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            picHinhAnh.Image = null;
            cboTheLoai.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                BatTatChucNang(true);
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                cboTheLoai.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa sản phẩm " + txtTenSach.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                    Sach s = context.Sach.Find(id)!;
                    if (s != null)
                    {
                        // Xóa hình ảnh (nếu có) 
                        if (!string.IsNullOrEmpty(s.HinhAnh))
                        {
                            string imagePath = Path.Combine(imageFolder, s.HinhAnh);
                            if (File.Exists(imagePath))
                            {
                                System.GC.Collect();
                                System.GC.WaitForPendingFinalizers();
                                File.Delete(imagePath);
                            }
                        }
                        context.Sach.Remove(s);
                        context.SaveChanges();
                    }
                    frmSach_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTheLoai.Text))
                MessageBox.Show("Vui lòng chọn thể loại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboNhaXuatBan.Text))
                MessageBox.Show("Vui lòng chọn nhà xuất bản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboTacGia.Text))
                MessageBox.Show("Vui lòng chọn tác giả.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenSach.Text))
                MessageBox.Show("Vui lòng nhập tên sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuong.Value <= 0)
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGia.Value <= 0)
                MessageBox.Show("Đơn giá sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id == 0)
                {
                    Sach s = new Sach();
                    s.TheLoaiID = Convert.ToInt32(cboTheLoai.SelectedValue?.ToString());
                    s.NhaXuatBanID = Convert.ToInt32(cboNhaXuatBan.SelectedValue?.ToString());
                    s.TacGiaID = Convert.ToInt32(cboTacGia.SelectedValue?.ToString());
                    s.TenSach = txtTenSach.Text;
                    s.DonGia = Convert.ToInt32(numDonGia.Value);
                    s.SoLuong = Convert.ToInt32(numSoLuong.Value);
                    s.HinhAnh = imageName;

                    context.Sach.Add(s);

                    context.SaveChanges();
                }
                else
                {
                    Sach s = context.Sach.Find(id)!;
                    if (s != null)
                    {
                        s.TheLoaiID = Convert.ToInt32(cboTheLoai.SelectedValue?.ToString());
                        s.NhaXuatBanID = Convert.ToInt32(cboNhaXuatBan.SelectedValue?.ToString());
                        s.TacGiaID = Convert.ToInt32(cboTacGia.SelectedValue?.ToString());
                        s.TenSach = txtTenSach.Text;
                        s.DonGia = Convert.ToInt32(numDonGia.Value);
                        s.SoLuong = Convert.ToInt32(numSoLuong.Value);
                        s.HinhAnh = imageName;
                        context.Sach.Update(s);

                        context.SaveChanges();
                    }
                }
                frmSach_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmSach_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                string imagePath = Path.Combine(imageFolder, e.Value?.ToString() ?? "");
                if (File.Exists(imagePath))
                {
                    Image image = Image.FromFile(imagePath);
                    image = new Bitmap(image, 24, 24);
                    e.Value = image;
                }
            }
        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            return;
        }
    }
}
