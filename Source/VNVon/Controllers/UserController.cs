using log4net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using VNVon.Service.DTO;
using VNVon.Service.Interfaces;

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
            _service.Register(user);
            return new OkResult();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("login")]
        public ActionResult Login([FromBody] LoginDTO user)
        {
            log.Info("Start loggin.....");
            var result = _service.Login(user);
            if (result == null)
            {
                return Unauthorized();
            }
            else
            {
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
        }
    }
}