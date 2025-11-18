using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.Data
{
    public class NhaXuatBan
    {
        public int ID { get; set; }
        public string TenNhaXuatBan { get; set; } = null!;
        public string DiaChi { get; set; } = null!;

        public virtual ICollection<Sach> Sach { get; } = new List<Sach>();
    }
}
