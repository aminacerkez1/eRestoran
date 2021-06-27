using AutoMapper;
using eRestoran_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public class NarudzbaJeloService:INarudzbaJeloService
    {
        private readonly IB140235Context _context;
        private readonly IMapper _mapper;

        public NarudzbaJeloService(IB140235Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<eRestoran.Model.NarudzbaJelo> Get()
        {
            var list = _context.NarudzbaJelo.ToList();
            var mappedList = Mapper.Map<List<eRestoran.Model.NarudzbaJelo>>(list);
            foreach (var item in mappedList)
            {
                item.Jelo = _context.Jelo.Find(item.JeloId).Naziv;
            }
            return mappedList;
        }

        public eRestoran.Model.NarudzbaJelo GetById(int id)
        {
            var entity = _context.NarudzbaJelo.Where(x => x.NarudzbaJeloId == id).FirstOrDefault();
            return Mapper.Map<eRestoran.Model.NarudzbaJelo>(entity);
        }

        public List<eRestoran.Model.NarudzbaJelo> GetByNarudzbe(int id)
        {
            var list = _context.NarudzbaJelo.Where(x => x.NarudzbaId == id).ToList();
            return Mapper.Map<List<eRestoran.Model.NarudzbaJelo>>(list);
        }
    }
}
