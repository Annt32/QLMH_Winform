using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn1_Nhom6.DomainClass;

[Table("HoaDonChiTietTT")]
public partial class HoaDonChiTietTt
{
    [Key]
    [Column("MaHoaDonTT")]
    public int MaHoaDonTt { get; set; }

    [Column("STTHoaDonTT")]
    [StringLength(10)]
    public string? StthoaDonTt { get; set; }

    [StringLength(10)]
    public string? MaSanPham { get; set; }

    [Column("IDNhanVien")]
    [StringLength(10)]
    public string? IdnhanVien { get; set; }

    [Column("IDKhachHang")]
    [StringLength(10)]
    public string? IdkhachHang { get; set; }

    [StringLength(255)]
    public string? TenSanPham { get; set; }

    [StringLength(255)]
    public string? MenhGiaVoucher { get; set; }

    [Column("HSDVoucher")]
    [StringLength(255)]
    public string? Hsdvoucher { get; set; }

    public int? SoLuong { get; set; }

    public double? TongTien { get; set; }

    [StringLength(255)]
    public string? TrangThai { get; set; }

    [ForeignKey("IdkhachHang")]
    [InverseProperty("HoaDonChiTietTts")]
    public virtual KhachHang? IdkhachHangNavigation { get; set; }

    [ForeignKey("IdnhanVien")]
    [InverseProperty("HoaDonChiTietTts")]
    public virtual NhanVien? IdnhanVienNavigation { get; set; }

    [ForeignKey("MaSanPham")]
    [InverseProperty("HoaDonChiTietTts")]
    public virtual SanPham? MaSanPhamNavigation { get; set; }
}
