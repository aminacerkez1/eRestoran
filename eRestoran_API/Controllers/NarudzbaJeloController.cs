using eRestoran_API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NarudzbaJeloController : ControllerBase
    {
        private readonly INarudzbaJeloService _service;
        public NarudzbaJeloController(INarudzbaJeloService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<eRestoran.Model.NarudzbaJelo> Get()
        {
            
            return _service.Get();
        }

        [HttpGet("{id}")]
        public eRestoran.Model.NarudzbaJelo GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet]
        [Route("GetByNarudzbe/{id}")]
        public List<eRestoran.Model.NarudzbaJelo> GetByNarudzbe(int id)
        {
            return _service.GetByNarudzbe(id);
        }
    }
}
