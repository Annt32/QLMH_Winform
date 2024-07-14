using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn1_Nhom6.DomainClass;

[Table("SanPham")]
public partial class SanPham
{
    [Key]
    [StringLength(10)]
    public string MaSanPham { get; set; } = null!;

    [Column("IDVoucher")]
    [StringLength(10)]
    public string? Idvoucher { get; set; }

    [StringLength(10)]
    public string? MaNhaSanXuat { get; set; }

    [StringLength(255)]
    public string? TenSanPham { get; set; }

    [InverseProperty("MaSanPhamNavigation")]
    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();

    [InverseProperty("MaSanPhamNavigation")]
    public virtual ICollection<HoaDonChiTietIn> HoaDonChiTietIns { get; set; } = new List<HoaDonChiTietIn>();

    [InverseProperty("MaSanPhamNavigation")]
    public virtual ICollection<HoaDonChiTietTt> HoaDonChiTietTts { get; set; } = new List<HoaDonChiTietTt>();

    [InverseProperty("MaSanPhamNavigation")]
    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    [ForeignKey("Idvoucher")]
    [InverseProperty("SanPhams")]
    public virtual Voucher? IdvoucherNavigation { get; set; }

    [ForeignKey("MaNhaSanXuat")]
    [InverseProperty("SanPhams")]
    public virtual NhaSanXuat? MaNhaSanXuatNavigation { get; set; }
}
