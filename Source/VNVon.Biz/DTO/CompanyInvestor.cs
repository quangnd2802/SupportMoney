﻿using System;

namespace VNVon.Service.DTO
{
    public class DoanhNghiepDauTuDTO
    {
        public int Id { get; set; }

        public string Ten { get; set; }

        public string Cmnd { get; set; }

        public string NgayCap { get; set; }

        public string NoiCap { get; set; }

        public string GioiTinh { get; set; }

        public string NgaySinh { get; set; }

        public string MaSoThue { get; set; }

        public string SoDiDong { get; set; }

        public string SoCoDinh { get; set; }

        public string Email { get; set; }

        public int ThanhPho { get; set; }

        public string DiaChiNha { get; set; }

        public string MatKhau { get; set; }

        public string ViTriTrongCongTy { get; set; }

        public int UserType { get; set; }

        public string Username { get; set; }

        public decimal? SoTienDaGui { get; set; }

        public decimal? SoTienDaRut { get; set; }

        public decimal? SoDuKhaDung { get; set; }

        public decimal? SoTienDangDauTu { get; set; }

        public string SoTaiKhoanNganHang { get; set; }

        public int IdNganHang { get; set; }

        public string TenChiNhanh { get; set; }

        public string TenChuTaiKhoan { get; set; }

        public string ChiTietTaiKhoan { get; set; }

        // Doanh nghiep dau tu

        public string CongTyTen { get; set; }

        public int CongTyIdLinhVuc { get; set; }

        public string CongTySoDangKyKinhDoanh { get; set; }

        public string CongTyNgayCapPhep { get; set; }

        public string CongTyDuocCapBoi { get; set; }

        public int CongTyIdThanhPho { get; set; }

        public string CongTyDiaChiCongTy { get; set; }
    }
}
