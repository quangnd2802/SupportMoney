using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace VNVon.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class InvestorController : ControllerBase
    {
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
    }
}

