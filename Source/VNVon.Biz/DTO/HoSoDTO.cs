using System;
using System.Collections.Generic;
using System.Text;

namespace VNVon.Service.DTO
{
    public class HoSoDTO
    {
        public int SoHoSo { get; set; }

        public string TenCongTy { get; set; }

        public string SoChungNhanDangKyKinhDoanh { get; set; }

        public string TrangThai { get; set; }

        public decimal TongSoTien { get; set; }

        public int KyHan { get; set; }

        public string MucDinhHuyDongVon { get; set; }

        public decimal SoTienCoTheDauTu { get; set; }

        public int TyLeDaDuocDauTu { get; set; }

        public ChiTietNguoiVay ChiTietNguoiVay { get; set; }

        public ThongTinNguoiCanLienLac ThongTinLienLac { get; set; }

        public List<LichSuTinDung> LichSuTinDungs { get; set; }
    }

    public class ChiTietNguoiVay
    {
        public int DiemTaiChinh { get; set; }

        public int DiemDinhTinh { get; set; }

        public int TongDiem { get; set; }

        public string TenCongTy { get; set; }

        public string SoChungNhanDangKyKinhDoanh { get; set; }

        public string NgayDuocCapPhep { get; set; }

        public string DuocCapBoi { get; set; }
        public string ThanhPho { get; set; }
        public string DiaChi { get; set; }

    }

    public class ThongTinNguoiCanLienLac
    {
        public string SoCaNhan { get; set; }
        public string TenDayDu { get; set; }
        public string GioiTinh { get; set; }
        public string ViTri { get; set; }
        public string SoDienThoaiCoDinh { get; set; }
        public string SoDiDong { get; set; }
        public string EmailCaNhan { get; set; }
    }
    public class LichSuTinDung
    {
        public int SoHopDong { get; set; }
        public string MucDichHuyDongVon { get; set; }
        public int LaiSuat { get; set; }

        public decimal SoTienYeuCau { get; set; }

        public int ThoiHan { get; set; }

        public decimal TongSoTienPhaiTra { get; set; }
        public decimal DuNoConLai { get; set; }

        public string NgayDenHan { get; set; }
        public string TrangThai { get; set; }
        public string ChuThich { get; set; }

    }
}