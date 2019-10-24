using Microsoft.AspNetCore.Mvc;
using VNVon.DataAccess.Models;
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
    }
}