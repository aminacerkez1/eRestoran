using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using eRestoran.Model.Requests;
using eRestoran_API.Database;
using eRestoran_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eRestoran_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZaposlenikController : ControllerBase
    {
        private readonly IZaposlenikService _service;
        public ZaposlenikController(IZaposlenikService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<eRestoran.Model.Zaposlenik>> Get([FromQuery]ZaposlenikSearchRequest request)
        {
            return _service.Get(request);
        }


        [HttpGet]
        [Route("LoginCheck/{username}/{pass}")]
        public eRestoran.Model.Zaposlenik LoginCheck(String username, String pass)
        {
            return _service.Authenticiraj(username,pass);
        }


        [HttpGet("{id}")]
        public eRestoran.Model.Zaposlenik GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public eRestoran.Model.Zaposlenik Insert(ZaposlenikInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public eRestoran.Model.Zaposlenik Update(int id,ZaposlenikInsertRequest request)
        {
            return _service.Update(id,request);
        }
    }
}
