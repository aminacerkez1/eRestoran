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
        public class JeloController : ControllerBase
        {
        
        private readonly IJeloService _service;
        public JeloController(IJeloService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<eRestoran.Model.Jelo> Get()
        {
         
            return _service.Get();
        }

        [HttpGet("{id}")]
        public eRestoran.Model.Jelo GetById(int id)
        {
        
            return _service.GetById(id);
        }

        [HttpPost]
        public eRestoran.Model.Jelo Insert(JeloInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpGet("getRecommendedJelo/{id}")]
        public List<eRestoran.Model.Jelo> getRecommendedJelo(int id)
        {
            return _service.GetRecommendedJelo(id);
        }
    }
}
