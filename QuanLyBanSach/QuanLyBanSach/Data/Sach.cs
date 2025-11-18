using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.Data
{
    public class Sach
    {
        public int ID { get; set; }
        public int TheLoaiID { get; set; }
        public int NhaXuatBanID { get; set; }
        public int TacGiaID { get; set; }
        public string TenSach { get; set; } = null!;
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public string? HinhAnh { get; set; }


        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDon { get; } = new List<ChiTietHoaDon>();
        
        public virtual TheLoai TheLoai { get; set; } = null!;
        public virtual NhaXuatBan NhaXuatBan { get; set; } = null!;
        public virtual TacGia TacGia { get; set; } = null!;
    }
}
