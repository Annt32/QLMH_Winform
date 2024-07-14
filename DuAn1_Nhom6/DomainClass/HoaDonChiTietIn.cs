﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn1_Nhom6.DomainClass;

[Table("HoaDonChiTietIN")]
public partial class HoaDonChiTietIn
{
    [Key]
    [Column("MaHoaDonCTIN")]
    public int MaHoaDonCtin { get; set; }

    [StringLength(10)]
    public string? MaSanPham { get; set; }

    [Column("IDNhanVien")]
    [StringLength(10)]
    public string? IdnhanVien { get; set; }

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

    [ForeignKey("MaSanPham")]
    [InverseProperty("HoaDonChiTietIns")]
    public virtual SanPham? MaSanPhamNavigation { get; set; }
}
