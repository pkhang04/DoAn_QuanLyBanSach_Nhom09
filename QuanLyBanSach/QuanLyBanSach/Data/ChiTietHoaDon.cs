using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.Data
{
    public class ChiTietHoaDon
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int SachID { get; set; }
        public int SoLuongBan { get; set; }
        public int DonGiaBan { get; set; }

        public virtual HoaDon HoaDon { get; set; } = null!;
        public virtual Sach Sach { get; set; } = null!;
    }
}
