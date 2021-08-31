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
    [Route("api/[controller]")]
    [ApiController]
    public class OcjenaController : ControllerBase
    {
        private readonly IOcjenaService _service;
        public OcjenaController(IOcjenaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<eRestoran.Model.Ocjena> Get()
        {
            return _service.Get();
        }

        [HttpGet("{id}")]
        public eRestoran.Model.Ocjena GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public eRestoran.Model.Ocjena Insert(OcjenaInsertRequest request)
        {
            return _service.Insert(request);
        }
    }

    }
