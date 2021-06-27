using AutoMapper;
using eRestoran.Model.Requests;
using eRestoran_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public class NabavkaService:INabavkaService
    {

        private readonly IB140235Context _context;
        private readonly IMapper _mapper;

        public NabavkaService(IB140235Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<eRestoran.Model.Nabavka> Get()
        {
            var list = _context.Nabavka.ToList();
            return Mapper.Map<List<eRestoran.Model.Nabavka>>(list);
        }

        public eRestoran.Model.Nabavka Insert(NabavkaInsertRequest request)
        {
            var entity = _mapper.Map<Database.Nabavka>(request);

            _context.Nabavka.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eRestoran.Model.Nabavka>(entity);

        }

        public eRestoran.Model.Nabavka Update(int id, NabavkaUpdateRequest request)
        {
            var entity = _context.Nabavka.Find(id);
            entity.UkupanIznos += request.Cijena;
            _context.SaveChanges();
            return _mapper.Map<eRestoran.Model.Nabavka>(entity);
        }

    }
}
