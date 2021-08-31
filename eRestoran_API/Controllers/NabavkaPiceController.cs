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
    public class NabavkaPiceController : ControllerBase
    {
        private readonly INabavkaPiceService _service;
        public NabavkaPiceController(INabavkaPiceService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<eRestoran.Model.NabavkaPice> Get(int id)
        {
            return _service.Get(id);
        }

        [HttpPost]
        public eRestoran.Model.NabavkaPice Insert(NabavkaPiceInsertRequest request)
        {
            return _service.Insert(request);
        }

    }

}
