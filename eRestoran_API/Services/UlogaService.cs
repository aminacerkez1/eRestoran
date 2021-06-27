using AutoMapper;
using eRestoran.Model;
using eRestoran.Model.Requests;
using eRestoran_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public class UlogaService : IUlogaService
    {
        private readonly IB140235Context _context;
        private readonly IMapper _mapper;

        public UlogaService(IB140235Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<eRestoran.Model.Uloga> Get()
        {
            var list = _context.Uloga.ToList();
            return Mapper.Map<List<eRestoran.Model.Uloga>>(list);
        }

        public eRestoran.Model.Uloga GetById(int id)
        {
            var entity = _context.Uloga.Find(id);
            return Mapper.Map<eRestoran.Model.Uloga>(entity);

        }

        public eRestoran.Model.Uloga GetByName(string name)
        {
            var entity = _context.Uloga.Where(x=>x.Naziv==name).SingleOrDefault();
            return Mapper.Map<eRestoran.Model.Uloga>(entity);
        }
    }
}
