using eRestoran_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Controllers
{
    [Authorize(AuthenticationSchemes = "BasicAuthentication")]
    [Route("api/[controller]")]
    [ApiController]
    public class VrstaJelaController : ControllerBase
    {
        private readonly IVrstaJelaService _service;
        public VrstaJelaController(IVrstaJelaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<eRestoran.Model.VrstaJela> Get()
        {
            return _service.Get();
        }

        [HttpGet("{id}")]
        public eRestoran.Model.VrstaJela GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpGet]
        [Route("name={name}")]
        public eRestoran.Model.VrstaJela GetByName(string name)
        {
            return _service.GetByName(name);
        }


    }

}
