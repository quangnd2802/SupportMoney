using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace VNVon.DataAccess.Models
{
    [Table("User")]
    public class User
    {
        public int Id { get; set; }

        [Column("CaNhan.Ten")]
        public string Ten { get; set; }

        [Column("CaNhan.Cmnd")]
        public string Cmnd { get; set; }

        [Column("CaNhan.NgayCap")]
        public DateTime? NgayCap { get; set; }

        [Column("CaNhan.NoiCap")]
        public string NoiCap { get; set; }

        [Column("CaNhan.IdGioiTinh")]
        public int GioiTinh { get; set; }

        [Column("CaNhan.NgaySinh")]
        public DateTime? NgaySinh { get; set; }

        [Column("CaNhan.MaSoThue")]
        public string MaSoThue { get; set; }

        [Column("CaNhan.SoDiDong")]
        public string SoDiDong { get; set; }

        [Column("CaNhan.SoCoDinh")]
        public string SoCoDinh { get; set; }

        [Column("CaNhan.Email")]
        public string Email { get; set; }

        [Column("CaNhan.IdThanhPho")]
        public int ThanhPho { get; set; }

        [Column("CaNhan.DiaChiNha")]
        public string DiaChiNha { get; set; }

        [Column("CaNhan.ViTriTrongCongTy")]
        public string ViTriTrongCongTy { get; set; }

        [Column("UserType")]
        public int UserType { get; set; }

        [Column("Username")]
        public string Username { get; set; }

        [JsonIgnore]
        public byte[] PasswordHash { get; set; }

        [JsonIgnore]
        public byte[] PasswordSalt { get; set; }

        [Column("CongTy.Ten")]
        public string CongTyTen { get; set; }

        [Column("CongTy.IdLinhVuc")]
        public int CongTyIdLinhVuc { get; set; }

        [Column("CongTy.SoDangKyKinhDoanh")]
        public string CongTySoDangKyKinhDoanh { get; set; }

        [Column("CongTy.NgayCapPhep")]
        public DateTime? CongTyNgayCapPhep { get; set; }

        [Column("CongTy.DuocCapBoi")]
        public string CongTyDuocCapBoi { get; set; }

        [Column("CongTy.IdThanhPho")]
        public int CongTyIdThanhPho { get; set; }

        [Column("CongTy.DiaChiCongTy")]
        public string CongTyDiaChiCongTy { get; set; }

        public decimal? SoTienDaGui { get; set; }

        public decimal? SoTienDaRut { get; set; }

        public decimal? SoDuKhaDung { get; set; }

        public decimal? SoTienDangDauTu { get; set; }

        public string SoTaiKhoanNganHang { get; set; }

        public int IdNganHang { get; set; }

        public string TenChiNhanh { get; set; }

        public string TenChuTaiKhoan { get; set; }

        public string ChiTietTaiKhoan { get; set; }
    }
}
