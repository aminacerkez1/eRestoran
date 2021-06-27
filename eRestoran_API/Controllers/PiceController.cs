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
    public class PiceController : ControllerBase
    {
        private readonly IPiceService _service;
        public PiceController(IPiceService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<eRestoran.Model.Pice> Get()
        {
            return _service.Get();
        }

        [HttpGet("{id}")]
        public eRestoran.Model.Pice GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPut("{id}")]
        public eRestoran.Model.Pice Update(int id, PiceUpdateRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpPost]
        public eRestoran.Model.Pice Insert(PiceInsertRequest request)
        {
            return _service.Insert(request);
        }


    }
}
