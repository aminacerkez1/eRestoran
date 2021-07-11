using AutoMapper;
using eRestoran.Model.Requests;
using eRestoran_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public class OcjenaService:IOcjenaService
    {

        private readonly IB140235Context _context;
        private readonly IMapper _mapper;

        public OcjenaService(IB140235Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<eRestoran.Model.Ocjena> Get()
        {
            var list = _context.Ocjena.ToList();
            return Mapper.Map<List<eRestoran.Model.Ocjena>>(list);
        }

        public eRestoran.Model.Ocjena GetById(int id)
        {
            var entity = _context.Ocjena.Find(id);
            return Mapper.Map<eRestoran.Model.Ocjena>(entity);
        }

        public eRestoran.Model.Ocjena Insert(OcjenaInsertRequest request)
        {
            var entity = _mapper.Map<Database.Ocjena>(request);
            _context.Ocjena.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eRestoran.Model.Ocjena>(entity);

        }

    }
}
