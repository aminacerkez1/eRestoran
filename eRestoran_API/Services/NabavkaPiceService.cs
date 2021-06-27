using AutoMapper;
using eRestoran.Model.Requests;
using eRestoran_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public class NabavkaPiceService:INabavkaPiceService
    {
        private readonly IB140235Context _context;
        private readonly IMapper _mapper;

        public NabavkaPiceService(IB140235Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<eRestoran.Model.NabavkaPice> Get(int id)
        {
            var list = _context.NabavkaPice.Where(x => x.NabavkaId == id).ToList();
            return Mapper.Map<List<eRestoran.Model.NabavkaPice>>(list);
        }

        public eRestoran.Model.NabavkaPice Insert(NabavkaPiceInsertRequest request)
        {
            var nabavkaPice = _context.NabavkaPice.Where(x => x.NabavkaId == request.NabavkaID).ToList();
            foreach (var item in nabavkaPice)
            {
                if (item.PiceId == request.PiceID)
                {
                    item.Kolicina += request.Kolicina;
                    _context.SaveChanges();
                    return _mapper.Map<eRestoran.Model.NabavkaPice>(item);
                }
            }
            var entity = _mapper.Map<Database.NabavkaPice>(request);

            _context.NabavkaPice.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eRestoran.Model.NabavkaPice>(entity);

        }

    }
}
