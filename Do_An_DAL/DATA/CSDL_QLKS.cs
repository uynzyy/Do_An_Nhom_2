using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Do_An_DAL.DATA
{
    public partial class CSDL_QLKS : DbContext
    {
        public CSDL_QLKS()
            : base("name=CSDL_QLKS")
        {
        }

        public virtual DbSet<CHI_TIET_LICH_LAM_VIEC> CHI_TIET_LICH_LAM_VIEC { get; set; }
        public virtual DbSet<CHI_TIET_PHIEU_DAT_PHONG> CHI_TIET_PHIEU_DAT_PHONG { get; set; }
        public virtual DbSet<CHUC_VU> CHUC_VU { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACH_HANG> KHACH_HANG { get; set; }
        public virtual DbSet<LICH_LAM_VIEC> LICH_LAM_VIEC { get; set; }
        public virtual DbSet<LOAI_PHONG> LOAI_PHONG { get; set; }
        public virtual DbSet<NHAN_VIEN> NHAN_VIEN { get; set; }
        public virtual DbSet<PHIEU_DAT_PHONG> PHIEU_DAT_PHONG { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TIEN_NGHI> TIEN_NGHI { get; set; }
        public virtual DbSet<DataGridView_Tab3> DataGridView_Tab3 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHI_TIET_LICH_LAM_VIEC>()
                .Property(e => e.MA_NV)
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_LICH_LAM_VIEC>()
                .Property(e => e.MA_LICH)
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_PHIEU_DAT_PHONG>()
                .Property(e => e.SO_PHIEU_DAT_PHONG)
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_PHIEU_DAT_PHONG>()
                .Property(e => e.MA_PHONG)
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_PHIEU_DAT_PHONG>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.CHI_TIET_PHIEU_DAT_PHONG)
                .HasForeignKey(e => new { e.SO_PHIEU_DAT_PHONG, e.MA_PHONG })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUC_VU>()
                .Property(e => e.MA_CV)
                .IsUnicode(false);

            modelBuilder.Entity<CHUC_VU>()
                .HasMany(e => e.NHAN_VIEN)
                .WithRequired(e => e.CHUC_VU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.SOHD)
                .IsFixedLength();

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MA_NV)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.SO_PHIEU_DAT_PHONG)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MA_PHONG)
                .IsUnicode(false);

            modelBuilder.Entity<KHACH_HANG>()
                .Property(e => e.MA_KH)
                .IsUnicode(false);

            modelBuilder.Entity<KHACH_HANG>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<KHACH_HANG>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<KHACH_HANG>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<KHACH_HANG>()
                .HasMany(e => e.PHIEU_DAT_PHONG)
                .WithRequired(e => e.KHACH_HANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LICH_LAM_VIEC>()
                .Property(e => e.MA_LICH)
                .IsUnicode(false);

            modelBuilder.Entity<LICH_LAM_VIEC>()
                .HasMany(e => e.CHI_TIET_LICH_LAM_VIEC)
                .WithRequired(e => e.LICH_LAM_VIEC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAI_PHONG>()
                .Property(e => e.MA_LOAI)
                .IsUnicode(false);

            modelBuilder.Entity<LOAI_PHONG>()
                .Property(e => e.GIA_THUE_PHONG)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LOAI_PHONG>()
                .HasMany(e => e.PHONGs)
                .WithRequired(e => e.LOAI_PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.MA_NV)
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.MA_CV)
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .HasMany(e => e.CHI_TIET_LICH_LAM_VIEC)
                .WithRequired(e => e.NHAN_VIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.NHAN_VIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEU_DAT_PHONG>()
                .Property(e => e.SO_PHIEU_DAT_PHONG)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_DAT_PHONG>()
                .Property(e => e.MA_KH)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_DAT_PHONG>()
                .Property(e => e.DATCOC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHIEU_DAT_PHONG>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHIEU_DAT_PHONG>()
                .HasMany(e => e.CHI_TIET_PHIEU_DAT_PHONG)
                .WithRequired(e => e.PHIEU_DAT_PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.MA_PHONG)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.SO_PHONG)
                .IsFixedLength();

            modelBuilder.Entity<PHONG>()
                .Property(e => e.MA_LOAI)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.CHI_TIET_PHIEU_DAT_PHONG)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.TIEN_NGHI)
                .WithMany(e => e.PHONGs)
                .Map(m => m.ToTable("CHI_TIET_PHONG").MapLeftKey("MA_PHONG").MapRightKey("MA_TN"));

            modelBuilder.Entity<TIEN_NGHI>()
                .Property(e => e.MA_TN)
                .IsUnicode(false);

            modelBuilder.Entity<TIEN_NGHI>()
                .Property(e => e.GiaTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DataGridView_Tab3>()
                .Property(e => e.SO_PHIEU_DAT_PHONG)
                .IsUnicode(false);

            modelBuilder.Entity<DataGridView_Tab3>()
                .Property(e => e.MA_KH)
                .IsUnicode(false);

            modelBuilder.Entity<DataGridView_Tab3>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<DataGridView_Tab3>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<DataGridView_Tab3>()
                .Property(e => e.MA_PHONG)
                .IsUnicode(false);

            modelBuilder.Entity<DataGridView_Tab3>()
                .Property(e => e.DATCOC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DataGridView_Tab3>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);
        }
    }
}
