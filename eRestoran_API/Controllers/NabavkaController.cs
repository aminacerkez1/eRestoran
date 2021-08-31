using eRestoran.Model.Requests;
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
    [Authorize(Roles = "Administrator, Konobar, Kuhar")]
    [Route("api/[controller]")]
    [ApiController]
    public class NabavkaController : ControllerBase
    {
        private readonly INabavkaService _service;
        public NabavkaController(INabavkaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<eRestoran.Model.Nabavka> Get()
        {
            return _service.Get();
        }

        [HttpPost]
        public eRestoran.Model.Nabavka Insert(NabavkaInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public eRestoran.Model.Nabavka Update(int id, NabavkaUpdateRequest request)
        {
            return _service.Update(id, request);
        }


    }
}
