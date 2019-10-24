using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VNVon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestorController : ControllerBase
    {
        [Route("daututodong")]
        [HttpGet]
        public ActionResult AutoChoiceInvest()
        {
            return Ok(mockData());
        }

        private object mockData()
        {
            var DanhsachHoso1 = new
            {

                sohoso = "95894",
                tenconty = "Công ty cổ phần Hoàng Dũng",
                chungnhankinhdoan = "100010102",
                trangthai = "tài trợ",
                tongsotien = 50000000,
                kyhan = 90,
                mucdichhuydongvon = "Vốn lưu động",
                sotiencothedautu = 50000000,
                tiledautu = 10,
                chitietnguoivay = new
                {
                    diemtaichinh = 25,
                    diemdinhtinh = 40,
                    tongdiem = 65,
                    tenconty = "Công ty cổ phần Hoàng Dũng",
                    chungnhankinhdoan = "100010102",
                    ngaycapphep = "03/11/2009",
                    duoccapboi = "sở kế hoạch đầu tư",
                    thanhpho = "Thái Bình",
                    diachi = "Huyện Tiền Hải",
                },
                thongtincanlienlac = new
                {
                    socanha = "12345",
                    tendaydu = "Công ty cổ phần Hoàng Dũng",
                    gioitinh = "Nữ",
                    vitri = "Giám Đốc",
                    sodienthoaicodinh = "024838383",
                    sodienthoaididong = "0882828282",
                    emailcanhan = "congtyhoangdung2006@gmail.com"
                }
            };

            var DanhsachHoso2 = new
            {

                sohoso = "95894",
                tenconty = "Công ty cổ phần Hoàng Dũng2",
                chungnhankinhdoan = "122010102",
                trangthai = "tài trợ",
                tongsotien = 50000000,
                kyhan = 90,
                mucdichhuydongvon = "Vốn lưu động",
                sotiencothedautu = 50000000,
                tiledautu = 10,
                chitietnguoivay = new
                {
                    diemtaichinh = 25,
                    diemdinhtinh = 40,
                    tongdiem = 65,
                    tenconty = "Công ty cổ phần Hoàng Dũng2",
                    chungnhankinhdoan = "100010102",
                    ngaycapphep = "03/11/2009",
                    duoccapboi = "sở kế hoạch đầu tư",
                    thanhpho = "Thái Bình",
                    diachi = "Huyện Tiền Hải",
                },
                thongtincanlienlac = new
                {
                    socanha = "12345",
                    tendaydu = "Công ty cổ phần Hoàng Dũng2",
                    gioitinh = "Nữ",
                    vitri = "Giám Đốc",
                    sodienthoaicodinh = "024838383",
                    sodienthoaididong = "0882828282",
                    emailcanhan = "congtyhoangdung2006@gmail.com"
                }
            };

            var mock = new { DanhsachHoso1, DanhsachHoso2 };
            return mock;
        }      
    }
}

