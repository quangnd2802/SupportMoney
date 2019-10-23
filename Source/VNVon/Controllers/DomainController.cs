using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VNVon.DataAccess.Models;
using VNVon.Service.DTO;
using VNVon.Service.Interfaces;

namespace VNVon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DomainController : ControllerBase
    {
        private IServiceBase<Domain> _service;

        public DomainController(IServiceBase<Domain> service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<DomainDTO> Get()
        {
            List<DomainDTO> result = new List<DomainDTO>();

            var items = _service.FindAll();

            foreach (var item in items)
            {
                result.Add(new DomainDTO() { Id = item.Id, LinhVuc = item.VieLinhVuc });
            }

            return result;
        }
    }
}