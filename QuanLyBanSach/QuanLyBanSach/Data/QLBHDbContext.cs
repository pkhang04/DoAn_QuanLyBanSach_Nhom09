using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.Data
{
    public class QLBHDbContext : DbContext
    {
        public DbSet<TheLoai> TheLoai { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBan { get; set; }
        public DbSet<TacGia> TacGia { get; set; }
        public DbSet<Sach> Sach { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLBHConnection"].ConnectionString);
        }
    }
}
