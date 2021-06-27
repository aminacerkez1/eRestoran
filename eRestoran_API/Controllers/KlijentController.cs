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
    public class KlijentController : ControllerBase
    {

        private readonly IKlijentService _service;

        public KlijentController(IKlijentService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<eRestoran.Model.Klijent>> Get([FromQuery] KlijentSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet]
        [Route("LoginCheck/{username}/{pass}")]
        public eRestoran.Model.Klijent LoginCheck(String username, String pass)
        {
            return _service.Authenticiraj(username, pass);
        }


        [HttpGet("{id}")]
        public eRestoran.Model.Klijent GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public eRestoran.Model.Klijent Insert(KlijentInsertRequest request)
        {
            return _service.Insert(request);
        }

    }
}
