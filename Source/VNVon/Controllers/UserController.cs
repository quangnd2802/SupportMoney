using Microsoft.AspNetCore.Mvc;
using VNVon.DataAccess.Models;
using VNVon.Service.DTO;
using VNVon.Service.Interfaces;

namespace VNVon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("register")]
        public ActionResult UserRegistor([FromBody] CaNhanDTO user)
        {
            _service.Register(user);
            return new OkResult();
        }
    }
}