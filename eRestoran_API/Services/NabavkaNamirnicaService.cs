using AutoMapper;
using eRestoran.Model.Requests;
using eRestoran_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public class NabavkaNamirnicaService : INabavkaNamirnicaService
    {
        private readonly IB140235Context _context;
        private readonly IMapper _mapper;

        public NabavkaNamirnicaService(IB140235Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<eRestoran.Model.NabavkaNamirnica> Get(int id)
        {
            var list = _context.NabavkaNamirnica.Where(x => x.NabavkaId == id).ToList();
            return Mapper.Map<List<eRestoran.Model.NabavkaNamirnica>>(list);
        }

        public eRestoran.Model.NabavkaNamirnica Insert(NabavkaNamirnicaInsertRequest request)
        {
            var nabavkaNamirnice = _context.NabavkaNamirnica.Where(x => x.NabavkaId == request.NabavkaID).ToList();
            foreach (var item in nabavkaNamirnice)
            {
                if(item.NamirnicaId == request.NamirnicaID)
                {
                    item.Kolicina += request.Kolicina;
                    _context.SaveChanges();
                    return _mapper.Map<eRestoran.Model.NabavkaNamirnica>(item);
                }
            }
            var entity = _mapper.Map<Database.NabavkaNamirnica>(request);

            _context.NabavkaNamirnica.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eRestoran.Model.NabavkaNamirnica>(entity);

        }
    }
}
