using log4net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using VNVon.Service.DTO;
using VNVon.Service.Interfaces;
using VNVon.Validator;

namespace VNVon.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _config;
        private IUserService _service;
        private static readonly ILog log = LogManager.GetLogger(typeof(UserController));

        public UserController(IUserService service, IConfiguration config)
        {
            _service = service;

            _config = config;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("register")]
        public ActionResult UserRegistor([FromBody] CaNhanDTO user)
        {
            UserValidator validator = new UserValidator();
            var result = validator.Validate(user);

            if (result.IsValid)
            {
                _service.Register(user);
                return Ok();
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("registercompany")]
        public ActionResult CompanyRegistor([FromBody] DoanhNghiepDauTuDTO user)
        {
            CompanyValidator validator = new CompanyValidator();
            var result = validator.Validate(user);

            if (result.IsValid)
            {
                _service.RegisterCompany(user);
                return Ok();
            }
            else
            {
                return BadRequest(VNVon.Utilities.Utility.GetModelMessage(result.Errors));
            }

        }

        [HttpPost]
        [AllowAnonymous]
        [Route("login")]
        public ActionResult Login([FromBody] LoginDTO user)
        {
            LoginValidator validator = new LoginValidator();
            var validationResult = validator.Validate(user);

            if (validationResult.IsValid)
            {
                var result = _service.Login(user);

                var claim = new[]
                    {
                    new Claim(ClaimTypes.NameIdentifier, result.Username),
                    new Claim(ClaimTypes.Role, result.Role)
                };

                var keyValue = _config.GetSection("AppSettings:SecurityKey").Value;
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(keyValue));


                var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(claim),
                    Expires = DateTime.Now.AddDays(1),
                    SigningCredentials = credential
                };

                var tokenHandler = new JwtSecurityTokenHandler();

                SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

                return Ok(new { token = tokenHandler.WriteToken(token) });
            }
            else
            {
                return BadRequest(VNVon.Utilities.Utility.GetModelMessage(validationResult.Errors));
            }
        }

        [HttpGet]
        public ActionResult Get()
        {
            string username = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var result = _service.FindByCondition(u => u.Username == username);

            if (result != null && result.Any())
            {
                return Ok(result.First());
            }

            return NotFound();
        }

        [HttpPut]
        [AllowAnonymous]
        [Route("changePassword")]
        public ActionResult ChangePassword([FromBody] ChangePassDto user)
        {
            var result = _service.ChangePassword(user);
            return Ok(result);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("forgetPassword")]
        public ActionResult ForgetPassword(ForgetPassDto forgetPassDto)
        {
            var result = _service.ForgetPassword(forgetPassDto);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("historyinvestment")]
        public ActionResult HistoryInvestment()
        {
            var data = new[]
            {
                new { NgayGiaoDich = DateTime.Now.AddDays(55).Date, LoaiGiaoDich = "", SoTien = 5000000, GhiChu = "" },
                new { NgayGiaoDich = DateTime.Now.AddDays(30).Date, LoaiGiaoDich = "", SoTien = 15000000, GhiChu = "" }
            };

            return Ok(data);
        }
    }
}