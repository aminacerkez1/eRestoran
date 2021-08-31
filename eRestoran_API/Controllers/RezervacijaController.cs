using eRestoran.Model.Requests;
using eRestoran_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    public class RezervacijaController : ControllerBase
    {
        private readonly IRezervacijaService _service;
        public RezervacijaController(IRezervacijaService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<eRestoran.Model.Rezervacija>> Get()
        {
            return _service.Get();
        }


        [HttpGet("{id}")]
        public eRestoran.Model.Rezervacija GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet]
        [Route("GetByDates/{dateFrom}/{dateTo}")]
        public List<eRestoran.Model.Rezervacija> GetByDates(DateTime dateFrom, DateTime dateTo)
        {
            return _service.GetByDates(dateFrom,dateTo);
        }

        [HttpPost]
        public eRestoran.Model.Rezervacija Insert(RezervacijaInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public eRestoran.Model.Rezervacija Update(int id, RezervacijaUpdateRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet]
        [Route("GetByKlijent/{id}")]
        public List<eRestoran.Model.Rezervacija> GetByKlijent(int id)
        {
            return _service.GetByKlijent(id);
        }
    }
}
