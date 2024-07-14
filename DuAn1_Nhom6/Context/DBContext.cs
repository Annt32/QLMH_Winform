using System;
using System.Collections.Generic;
using DuAn1_Nhom6.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DuAn1_Nhom6.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Adminacc> Adminaccs { get; set; }

    public virtual DbSet<ChatLieu> ChatLieus { get; set; }

    public virtual DbSet<ChiTietSanPham> ChiTietSanPhams { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<HoaDonChiTietIn> HoaDonChiTietIns { get; set; }

    public virtual DbSet<HoaDonChiTietTt> HoaDonChiTietTts { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<KichCo> KichCos { get; set; }

    public virtual DbSet<MaShop> MaShops { get; set; }

    public virtual DbSet<NhaSanXuat> NhaSanXuats { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source= DESKTOP-PMB8531\\SQLEXPRESS ;Initial Catalog= Duan1_N6_Demo4;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Adminacc>(entity =>
        {
            entity.HasKey(e => e.MaAdmin).HasName("PK__Adminacc__49341E387DC1E886");
        });

        modelBuilder.Entity<ChatLieu>(entity =>
        {
            entity.HasKey(e => e.MaChatLieu).HasName("PK__ChatLieu__453995BC2DDA2B9B");
        });

        modelBuilder.Entity<ChiTietSanPham>(entity =>
        {
            entity.HasKey(e => e.MaCtsanPham).HasName("PK__ChiTietS__F525A43937E0A301");

            entity.HasOne(d => d.MaChatLieuNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSa__MaCha__4AB81AF0");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSa__MaSan__48CFD27E");

            entity.HasOne(d => d.MaSizeNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSa__MaSiz__49C3F6B7");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.IdhoaDon).HasName("PK__HoaDon__5B896F491DDB0FBF");

            entity.HasOne(d => d.IdkhachHangNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__IDKhachH__4E88ABD4");

            entity.HasOne(d => d.IdnhanVienNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__IDNhanVi__4D94879B");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.MaHoaDonCt).HasName("PK__HoaDonCh__38C56E84F1FBC483");

            entity.HasOne(d => d.IdhoaDonNavigation).WithMany(p => p.HoaDonChiTiets).HasConstraintName("FK__HoaDonChi__IDHoa__5165187F");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.HoaDonChiTiets).HasConstraintName("FK__HoaDonChi__MaSan__52593CB8");
        });

        modelBuilder.Entity<HoaDonChiTietIn>(entity =>
        {
            entity.HasKey(e => e.MaHoaDonCtin).HasName("PK__HoaDonCh__75AB72BFA8AB90E4");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.HoaDonChiTietIns).HasConstraintName("FK__HoaDonChi__MaSan__59063A47");
        });

        modelBuilder.Entity<HoaDonChiTietTt>(entity =>
        {
            entity.HasKey(e => e.MaHoaDonTt).HasName("PK__HoaDonCh__38FA00D30F3462D2");

            entity.HasOne(d => d.IdkhachHangNavigation).WithMany(p => p.HoaDonChiTietTts).HasConstraintName("FK__HoaDonChi__IDKha__5DCAEF64");

            entity.HasOne(d => d.IdnhanVienNavigation).WithMany(p => p.HoaDonChiTietTts).HasConstraintName("FK__HoaDonChi__IDNha__5CD6CB2B");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.HoaDonChiTietTts).HasConstraintName("FK__HoaDonChi__MaSan__5BE2A6F2");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.IdkhachHang).HasName("PK__KhachHan__5A7167B5289A458C");
        });

        modelBuilder.Entity<KichCo>(entity =>
        {
            entity.HasKey(e => e.MaSize).HasName("PK__KichCo__A787E7EDAF9FE769");
        });

        modelBuilder.Entity<MaShop>(entity =>
        {
            entity.HasKey(e => e.MaMayChu).HasName("PK__MaShop__F85497362F28B30F");
        });

        modelBuilder.Entity<NhaSanXuat>(entity =>
        {
            entity.HasKey(e => e.MaNhaSanXuat).HasName("PK__NhaSanXu__838C17A11ABFC39F");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.IdnhanVien).HasName("PK__NhanVien__7AC2D9F7F0FD7F5D");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSanPham).HasName("PK__SanPham__FAC7442DEAF0F8BC");

            entity.HasOne(d => d.IdvoucherNavigation).WithMany(p => p.SanPhams).HasConstraintName("FK__SanPham__IDVouch__412EB0B6");

            entity.HasOne(d => d.MaNhaSanXuatNavigation).WithMany(p => p.SanPhams).HasConstraintName("FK__SanPham__MaNhaSa__4222D4EF");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.Idvoucher).HasName("PK__Voucher__50249A27631EB33B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
