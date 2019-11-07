using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VNVon.Service.DTO;

namespace VNVon.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class InvestorController : ControllerBase
    {
        private List<HoSoDTO> Data = new List<HoSoDTO>();

        public InvestorController()
        {
            var hoso1 = new HoSoDTO()
            {
                SoHoSo = 95894,
                TenCongTy = "Công ty cổ phần Hoàng Dũng",
                SoChungNhanDangKyKinhDoanh = "100010102",
                TrangThai = "Thương trường",
                TongSoTien = 50000000,
                KyHan = 90,
                MucDinhHuyDongVon = "Vốn lưu động",
                SoTienCoTheDauTu = 50000000,
                TyLeDaDuocDauTu = 0,
                ChiTietNguoiVay = new ChiTietNguoiVay()
                {
                    DiemTaiChinh = 25,
                    DiemDinhTinh = 40,
                    TongDiem = 65,
                    TenCongTy = "Công ty cổ phần Hoàng Dũng",
                    SoChungNhanDangKyKinhDoanh = "100010102",
                    NgayDuocCapPhep = "03/11/2009",
                    DuocCapBoi = "Sở kế hoạch đầu tư",
                    ThanhPho = "Thái Bình",
                    DiaChi = "Huyện Tiền Hải",
                },
                ThongTinLienLac = new ThongTinNguoiCanLienLac()
                {
                    SoCaNhan = "12345",
                    TenDayDu = "Công ty cổ phần Hoàng Dũng",
                    GioiTinh = "Nữ",
                    ViTri = "Giám Đốc",
                    SoDienThoaiCoDinh = "024838383",
                    SoDiDong = "0882828282",
                    EmailCaNhan = "congtyhoangdung2006@gmail.com"
                },
                LichSuTinDungs = new List<LichSuTinDung>()
                {
                    new LichSuTinDung{
                        SoHopDong = 95430,
                        MucDichHuyDongVon = "Vốn lưu động",
                        LaiSuat = 16,
                        SoTienYeuCau = 1000000000,
                        ThoiHan = 90,
                        TongSoTienPhaiTra = 1039452055,
                        NgayDenHan = "07/11/2019",
                        DuNoConLai = 0,
                        TrangThai = "Tài trợ",
                        ChuThich = ""
                    },
                    new LichSuTinDung{
                        SoHopDong = 95698,
                        MucDichHuyDongVon = "Vốn lưu động",
                        LaiSuat = 16,
                        SoTienYeuCau = 500000000,
                        ThoiHan = 90,
                        TongSoTienPhaiTra = 519726027,
                        NgayDenHan = "",
                        DuNoConLai = 0,
                        TrangThai = "Thương trường",
                        ChuThich = ""
                    }
                }
            };

            var hoso2 = new HoSoDTO()
            {
                SoHoSo = 95895,
                TenCongTy = "Công ty cổ phần Minh Huy",
                SoChungNhanDangKyKinhDoanh = "100010102",
                TrangThai = "Thương trường",
                TongSoTien = 50000000,
                KyHan = 90,
                MucDinhHuyDongVon = "Vốn lưu động",
                SoTienCoTheDauTu = 50000000,
                TyLeDaDuocDauTu = 0,
                ChiTietNguoiVay = new ChiTietNguoiVay()
                {
                    DiemTaiChinh = 25,
                    DiemDinhTinh = 40,
                    TongDiem = 65,
                    TenCongTy = "Công ty cổ phần Hoàng Dũng",
                    SoChungNhanDangKyKinhDoanh = "100010102",
                    NgayDuocCapPhep = "03/11/2009",
                    DuocCapBoi = "Sở kế hoạch đầu tư",
                    ThanhPho = "Thái Bình",
                    DiaChi = "Huyện Tiền Hải",
                },
                ThongTinLienLac = new ThongTinNguoiCanLienLac()
                {
                    SoCaNhan = "12345",
                    TenDayDu = "Công ty cổ phần Hoàng Dũng",
                    GioiTinh = "Nữ",
                    ViTri = "Giám Đốc",
                    SoDienThoaiCoDinh = "024838383",
                    SoDiDong = "0882828282",
                    EmailCaNhan = "congtyhoangdung2006@gmail.com"
                },
                LichSuTinDungs = new List<LichSuTinDung>()
                {
                    new LichSuTinDung{
                        SoHopDong = 95430,
                        MucDichHuyDongVon = "Vốn lưu động",
                        LaiSuat = 16,
                        SoTienYeuCau = 1000000000,
                        ThoiHan = 90,
                        TongSoTienPhaiTra = 1039452055,
                        NgayDenHan = "07/11/2019",
                        DuNoConLai = 0,
                        TrangThai = "Tài trợ",
                        ChuThich = ""
                    },
                    new LichSuTinDung{
                        SoHopDong = 95698,
                        MucDichHuyDongVon = "Vốn lưu động",
                        LaiSuat = 16,
                        SoTienYeuCau = 500000000,
                        ThoiHan = 90,
                        TongSoTienPhaiTra = 519726027,
                        NgayDenHan = "",
                        DuNoConLai = 0,
                        TrangThai = "Thương trường",
                        ChuThich = ""
                    }
                }
            };

            var hoso3 = new HoSoDTO()
            {
                SoHoSo = 95896,
                TenCongTy = "Công ty cổ phần Net Viet",
                SoChungNhanDangKyKinhDoanh = "100010102",
                TrangThai = "Thương trường",
                TongSoTien = 50000000,
                KyHan = 90,
                MucDinhHuyDongVon = "Vốn lưu động",
                SoTienCoTheDauTu = 50000000,
                TyLeDaDuocDauTu = 0,
                ChiTietNguoiVay = new ChiTietNguoiVay()
                {
                    DiemTaiChinh = 25,
                    DiemDinhTinh = 40,
                    TongDiem = 65,
                    TenCongTy = "Công ty cổ phần Hoàng Dũng",
                    SoChungNhanDangKyKinhDoanh = "100010102",
                    NgayDuocCapPhep = "03/11/2009",
                    DuocCapBoi = "Sở kế hoạch đầu tư",
                    ThanhPho = "Thái Bình",
                    DiaChi = "Huyện Tiền Hải",
                },
                ThongTinLienLac = new ThongTinNguoiCanLienLac()
                {
                    SoCaNhan = "12345",
                    TenDayDu = "Công ty cổ phần Hoàng Dũng",
                    GioiTinh = "Nữ",
                    ViTri = "Giám Đốc",
                    SoDienThoaiCoDinh = "024838383",
                    SoDiDong = "0882828282",
                    EmailCaNhan = "congtyhoangdung2006@gmail.com"
                },
                LichSuTinDungs = new List<LichSuTinDung>()
                {
                    new LichSuTinDung{
                        SoHopDong = 95430,
                        MucDichHuyDongVon = "Vốn lưu động",
                        LaiSuat = 16,
                        SoTienYeuCau = 1000000000,
                        ThoiHan = 90,
                        TongSoTienPhaiTra = 1039452055,
                        NgayDenHan = "07/11/2019",
                        DuNoConLai = 0,
                        TrangThai = "Tài trợ",
                        ChuThich = ""
                    },
                    new LichSuTinDung{
                        SoHopDong = 95698,
                        MucDichHuyDongVon = "Vốn lưu động",
                        LaiSuat = 16,
                        SoTienYeuCau = 500000000,
                        ThoiHan = 90,
                        TongSoTienPhaiTra = 519726027,
                        NgayDenHan = "",
                        DuNoConLai = 0,
                        TrangThai = "Thương trường",
                        ChuThich = ""
                    }
                }
            };

            Data.Add(hoso1);
            Data.Add(hoso2);
            Data.Add(hoso3);
        }

        [Route("borrowers")]
        [HttpGet]
        public ActionResult ListBorrowers()
        {
            return Ok(mockData());
        }

        private object mockData()
        {
            var DanhsachHoso1 = new
            {
                Sohoso = 95894,
                Tenconty = "Công ty cổ phần Hoàng Dũng",
                SoChungNhanDangKyKinhDoanh = "100010102",
                TrangThai = "Thương trường",
                TongSoTien = 50000000,
                KyHan = 90,
                MucDichHuyDongVon = "Vốn lưu động",
                SoTienCoTheDauTu = 50000000,
                TyLeDaDuocDauTu = 0,
                ChiTietNguoiVay = new
                {
                    DiemTaiChinh = 25,
                    DiemDinhTinh = 40,
                    TongDiem = 65,
                    TenCongTy = "Công ty cổ phần Hoàng Dũng",
                    SoChungNhanDangKyKinhDoanh = "100010102",
                    NgayDuocCapPhep = "03/11/2009",
                    DuocCapBoi = "Sở kế hoạch đầu tư",
                    ThanhPho = "Thái Bình",
                    DiaChi = "Huyện Tiền Hải",
                },
                ThongTinNguoiCanLienLac = new
                {
                    SoCaNha = "12345",
                    TenDayDu = "Công ty cổ phần Hoàng Dũng",
                    GioiTinh = "Nữ",
                    ViTri = "Giám Đốc",
                    SoDienThoaiCoDinh = "024838383",
                    SoDiDong = "0882828282",
                    EmailCaNhan = "congtyhoangdung2006@gmail.com"
                },
                LichSuTinDung = new List<dynamic>()
                {
                    new {
                        SoHopDong = 95430,
                        MucDichHuyDongVon = "Vốn lưu động",
                        LaiSuat = 16,
                        SoTienYeuCau = 1000000000,
                        ThoiHan = 90,
                        TongSoTienPhaiTra = 1039452055,
                        NgayDenHan = "07/11/2019",
                        DuNoConLai = 0,
                        TrangThai = "Tài trợ",
                        ChuThich = ""
                    },
                    new {
                        SoHopDong = 95698,
                        MucDichHuyDongVon = "Vốn lưu động",
                        LaiSuat = 16,
                        SoTienYeuCau = 500000000,
                        ThoiHan = 90,
                        TongSoTienPhaiTra = 519726027,
                        NgayDenHan = "",
                        DuNoConLai = 0,
                        TrangThai = "Thương trường",
                        ChuThich = ""
                    }
                }
                
            };

            var DanhsachHoso2 = new
            {
                Sohoso = 95692,
                Tenconty = "Công ty cổ phần tư vấn thiết kết",
                SoChungNhanDangKyKinhDoanh = "0106860319",
                TrangThai = "Thương trường",
                TongSoTien = 30000000,
                KyHan = 60,
                MucDichHuyDongVon = "Vốn lưu động",
                SoTienCoTheDauTu = 30000000,
                TyLeDaDuocDauTu = 0,
                ChiTietNguoiVay = new
                {
                    DiemTaiChinh = 25,
                    DiemDinhTinh = 40,
                    TongDiem = 65,
                    TenCongTy = "Công ty cổ phần Hoàng Dũng",
                    SoChungNhanDangKyKinhDoanh = "100010102",
                    NgayDuocCapPhep = "03/11/2009",
                    DuocCapBoi = "Sở kế hoạch đầu tư",
                    ThanhPho = "Thái Bình",
                    DiaChi = "Huyện Tiền Hải",
                },
                ThongTinNguoiCanLienLac = new
                {
                    SoCaNha = "12345",
                    TenDayDu = "Công ty cổ phần Hoàng Dũng",
                    GioiTinh = "Nữ",
                    ViTri = "Giám Đốc",
                    SoDienThoaiCoDinh = "024838383",
                    SoDiDong = "0882828282",
                    EmailCaNhan = "congtyhoangdung2006@gmail.com"
                },
                LichSuTinDung = new List<dynamic>()
                {
                    new {
                        SoHopDong = 95430,
                        MucDichHuyDongVon = "Vốn lưu động",
                        LaiSuat = 16,
                        SoTienYeuCau = 1000000000,
                        ThoiHan = 90,
                        TongSoTienPhaiTra = 1039452055,
                        NgayDenHan = "07/11/2019",
                        DuNoConLai = 0,
                        TrangThai = "Tài trợ",
                        ChuThich = ""
                    },
                    new {
                        SoHopDong = 95698,
                        MucDichHuyDongVon = "Vốn lưu động",
                        LaiSuat = 16,
                        SoTienYeuCau = 500000000,
                        ThoiHan = 90,
                        TongSoTienPhaiTra = 519726027,
                        NgayDenHan = "",
                        DuNoConLai = 0,
                        TrangThai = "Thương trường",
                        ChuThich = ""
                    }
                }

            };

            var mock = new { DanhsachHoso1, DanhsachHoso2 };
            return mock;
        }
                
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(Data);
        }
                
        [HttpGet("{id}")]
        public ActionResult GetAll(int id)
        {
            HoSoDTO result = null;

            foreach(var item in Data)
            {
                if (item.SoHoSo == id)
                {
                    result = item;
                    break;
                }
            }

            return Ok(result);
        }
    }
}

