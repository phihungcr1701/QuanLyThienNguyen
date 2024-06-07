using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyThienNguyen.Models
{
    public partial class PBL3Context : DbContext
    {
        public PBL3Context()
        {
        }

        public PBL3Context(DbContextOptions<PBL3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<ChiTietUngHo> ChiTietUngHo { get; set; }
        public virtual DbSet<DonViUngHo> DonViUngHo { get; set; }
        public virtual DbSet<DotUngHo> DotUngHo { get; set; }
        public virtual DbSet<HinhThucUngHo> HinhThucUngHo { get; set; }
        public virtual DbSet<HoDan> HoDan { get; set; }
        public virtual DbSet<ThanhVienDvuh> ThanhVienDvuh { get; set; }
        public virtual DbSet<ThongKe> ThongKe { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=.\\SQLEXPRESS;initial catalog=PBL3;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChiTietUngHo>(entity =>
            {
                entity.HasKey(e => e.MaCtuh)
                    .HasName("PK__ChiTietU__1E4FFE8734A36696");

                entity.Property(e => e.MaCtuh)
                    .HasColumnName("MaCTUH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnhHoatDong).HasColumnType("image");

                entity.Property(e => e.MaDuh)
                    .IsRequired()
                    .HasColumnName("MaDUH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaDvuh)
                    .IsRequired()
                    .HasColumnName("MaDVUH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaHd)
                    .IsRequired()
                    .HasColumnName("MaHD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaHtuh)
                    .IsRequired()
                    .HasColumnName("MaHTUH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MoTa).HasMaxLength(1000);

                entity.Property(e => e.SoLuongNuh).HasColumnName("SoLuongNUH");

                entity.Property(e => e.SoLuongUh).HasColumnName("SoLuongUH");

                entity.Property(e => e.TênHoatDong).HasMaxLength(50);

                entity.HasOne(d => d.MaDuhNavigation)
                    .WithMany(p => p.ChiTietUngHo)
                    .HasForeignKey(d => d.MaDuh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietUn__MaDUH__5AEE82B9");

                entity.HasOne(d => d.MaDvuhNavigation)
                    .WithMany(p => p.ChiTietUngHo)
                    .HasForeignKey(d => d.MaDvuh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietUn__MaDVU__59FA5E80");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.ChiTietUngHo)
                    .HasForeignKey(d => d.MaHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietUng__MaHD__5BE2A6F2");

                entity.HasOne(d => d.MaHtuhNavigation)
                    .WithMany(p => p.ChiTietUngHo)
                    .HasForeignKey(d => d.MaHtuh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietUn__MaHTU__5CD6CB2B");
            });

            modelBuilder.Entity<DonViUngHo>(entity =>
            {
                entity.HasKey(e => e.MaDvuh)
                    .HasName("PK__DonViUng__36ECCC7A77EC3ED4");

                entity.Property(e => e.MaDvuh)
                    .HasColumnName("MaDVUH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChiDonVi)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SdtdonVi)
                    .IsRequired()
                    .HasColumnName("SDTDonVi")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TenDonVi)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DotUngHo>(entity =>
            {
                entity.HasKey(e => e.MaDuh)
                    .HasName("PK__DotUngHo__3D8962EB04DCDBDE");

                entity.Property(e => e.MaDuh)
                    .HasColumnName("MaDUH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgayBatDau).HasColumnType("date");

                entity.Property(e => e.NgayKetThuc).HasColumnType("date");
            });

            modelBuilder.Entity<HinhThucUngHo>(entity =>
            {
                entity.HasKey(e => e.MaHtuh)
                    .HasName("PK__HinhThuc__103810FFAE0BC1E2");

                entity.Property(e => e.MaHtuh)
                    .HasColumnName("MaHTUH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DonViTinh)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TenHtuh)
                    .IsRequired()
                    .HasColumnName("TenHTUH")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HoDan>(entity =>
            {
                entity.HasKey(e => e.MaHd)
                    .HasName("PK__HoDan__2725A6E02AE23CAF");

                entity.Property(e => e.MaHd)
                    .HasColumnName("MaHD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cccd)
                    .IsRequired()
                    .HasColumnName("CCCD")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DienGiaDinh).HasMaxLength(20);

                entity.Property(e => e.HoTenChuHo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sdt)
                    .IsRequired()
                    .HasColumnName("SDT")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ThanhVienDvuh>(entity =>
            {
                entity.HasKey(e => e.MaTvdvuh)
                    .HasName("PK__ThanhVie__F4A2BE0C7AD2E696");

                entity.ToTable("ThanhVienDVUH");

                entity.Property(e => e.MaTvdvuh)
                    .HasColumnName("MaTVDVUH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cccd)
                    .IsRequired()
                    .HasColumnName("CCCD")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaDvuh)
                    .IsRequired()
                    .HasColumnName("MaDVUH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sdt)
                    .IsRequired()
                    .HasColumnName("SDT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaDvuhNavigation)
                    .WithMany(p => p.ThanhVienDvuh)
                    .HasForeignKey(d => d.MaDvuh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThanhVien__MaDVU__4D94879B");
            });

            modelBuilder.Entity<ThongKe>(entity =>
            {
                entity.HasKey(e => e.MaTk)
                    .HasName("PK__ThongKe__27250070D71A76AD");

                entity.Property(e => e.MaTk)
                    .HasColumnName("MaTK")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaDvuh)
                    .IsRequired()
                    .HasColumnName("MaDVUH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaHtuh)
                    .IsRequired()
                    .HasColumnName("MaHTUH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SoDuUh).HasColumnName("SoDuUH");

                entity.Property(e => e.TongSoLuongUh).HasColumnName("TongSoLuongUH");

                entity.HasOne(d => d.MaDvuhNavigation)
                    .WithMany(p => p.ThongKe)
                    .HasForeignKey(d => d.MaDvuh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThongKe__MaDVUH__5441852A");

                entity.HasOne(d => d.MaHtuhNavigation)
                    .WithMany(p => p.ThongKe)
                    .HasForeignKey(d => d.MaHtuh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThongKe__MaHTUH__5535A963");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
