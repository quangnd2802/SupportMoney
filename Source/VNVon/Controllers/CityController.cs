using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VNVon.DataAccess.Models;
using VNVon.DTO;
using VNVon.Service.Interfaces;

namespace VNVon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private IServiceBase<City> _service;

        public CityController(IServiceBase<City> service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<CityDTO> Get()
        {
            List<CityDTO> result = new List<CityDTO>();

            var items = _service.FindAll();

            foreach(var item in items)
            {
                result.Add(new CityDTO() { Id = item.Id, Name = item.ThanhPho });                    
            }

            return result;
        }
    }
}