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
    public class NarudzbaController : ControllerBase
    {
        private readonly INarudzbaService _service;
        public NarudzbaController(INarudzbaService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<eRestoran.Model.Narudzba>> Get()
        {
            return _service.Get();
        }


        [HttpGet("{id}")]
        public eRestoran.Model.Narudzba GetById(int id)
        {
            return _service.GetById(id);
        }


        [HttpGet]
        [Route("GetByKlijent/{id}")]
        public List<eRestoran.Model.Narudzba> GetByKlijent(int id)
        {
            return _service.GetByKlijent(id);
        }

        [HttpGet]
        [Route("GetByDates/{dateFrom}/{dateTo}")]
        public List<eRestoran.Model.Narudzba> GetByDates(DateTime dateFrom, DateTime dateTo)
        {
            return _service.GetByDates(dateFrom, dateTo);
        }

        [HttpPut("{id}")]
        public eRestoran.Model.Narudzba Update(int id, NarudzbaUpdateRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpPost]
        public eRestoran.Model.Narudzba Insert(NarudzbaInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut]
        [Route("UpdateCijena/{id}")]
        public eRestoran.Model.Narudzba UpdateCijena(int id, NarudzbaUpdateCijenaRequest request)
        {
            return _service.UpdateCijena(id, request);
        }




    }
}
