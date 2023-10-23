using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAn_Quan_Ly_Ban_May_Tinh
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<PhieuXuatHang> PhieuXuatHangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.MaHH)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.MAChiTietHD)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.MaHang)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.TenHang)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.LoaiHang)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.LoaiMatHang)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithRequired(e => e.HangHoa)
                .HasForeignKey(e => e.MaHH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHoaDo)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.SoHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithRequired(e => e.HoaDon)
                .HasForeignKey(e => e.MaHD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.PhieuXuatHangs)
                .WithRequired(e => e.HoaDon)
                .HasForeignKey(e => e.MAHD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.TenKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.DiaChi)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.PhieuXuatHangs)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuXuatHang>()
                .Property(e => e.SoPhieu)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuXuatHang>()
                .Property(e => e.MAKH)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuXuatHang>()
                .Property(e => e.MAHD)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuXuatHang>()
                .Property(e => e.MaPX)
                .IsUnicode(false);
        }
    }
}
