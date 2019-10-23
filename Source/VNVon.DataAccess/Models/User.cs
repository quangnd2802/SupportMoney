using System;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Column("CaNhan.MatKhau")]
        public string MatKhau { get; set; }

        [Column("CaNhan.ViTriTrongCongTy")]
        public string ViTriTrongCongTy { get; set; }

        [Column("UserType")]
        public int UserType { get; set; }

        [Column("Username")]
        public string Username { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}
