using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VNVon.DataAccess.Models;
using VNVon.Service.DTO;
using VNVon.Service.Interfaces;

namespace VNVon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private IServiceBase<Bank> _service;

        public BankController(IServiceBase<Bank> service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_service.FindAll());
        }

        [Authorize]
        [HttpGet("vnvon")]
        public ActionResult RootBank()
        {
            return Ok(new 
            { 
                SoTaiKhoanNganHang = "11869338888", 
                TenNganHang = "CONG THUONG VN (VIETINBANK)", 
                TenChuTaiKhoan = "CONG TY CP KET NOI TAI CHINH VIET NAM"
            });
        }

        [Authorize]
        [HttpGet("rate/{day}")]
        public ActionResult Rate(int day)
        {
            int result;
            switch (day)
            {
                case 10:
                    result = 5;
                    break;
                case 20:
                    result = 7;
                    break;
                case 30:
                    result = 9;
                    break;
                case 60:
                    result = 12;
                    break;
                case 90:
                    result = 15;
                    break;
                default:
                    result = 0;
                    break;
            }

            return Ok(result);
        }

    }
}