using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eRestoran_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UlogaController : ControllerBase
    {
        private readonly IUlogaService _service;
        public UlogaController(IUlogaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<eRestoran.Model.Uloga> Get()
        {
            return _service.Get();
        }

        [HttpGet("{id}")]
        public eRestoran.Model.Uloga GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet]
        [Route("name={name}")]
        public eRestoran.Model.Uloga GetByName(string name)
        {
            return _service.GetByName(name);
        }



    }


}
