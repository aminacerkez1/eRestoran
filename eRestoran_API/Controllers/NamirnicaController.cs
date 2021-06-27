using eRestoran.Model.Requests;
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
    public class NamirnicaController : ControllerBase
    {
        private readonly INamirnicaService _service;
        public NamirnicaController(INamirnicaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<eRestoran.Model.Namirnica> Get()
        {
            return _service.Get();
        }

        [HttpGet("{id}")]
        public eRestoran.Model.Namirnica GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPut("{id}")]
        public eRestoran.Model.Namirnica Update(int id, NamirnicaUpdateRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpPost]
        public eRestoran.Model.Namirnica Insert(NamirnicaInsertRequest request)
        {
            return _service.Insert(request);
        }


    }
}
