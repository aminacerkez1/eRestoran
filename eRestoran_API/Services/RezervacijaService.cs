using AutoMapper;
using eRestoran.Model.Requests;
using eRestoran_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public class RezervacijaService: IRezervacijaService
    {
        private readonly IB140235Context _context;
        private readonly IMapper _mapper;

        public RezervacijaService(IB140235Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<eRestoran.Model.Rezervacija> Get()
        {
            var list = _context.Rezervacija.ToList();
            return Mapper.Map<List<eRestoran.Model.Rezervacija>>(list);
        }

        public eRestoran.Model.Rezervacija GetById(int id)
        {
            var entity = _context.Rezervacija.Where(x=>x.RezervacijaId==id).FirstOrDefault();
            return Mapper.Map<eRestoran.Model.Rezervacija>(entity);
        }

        public List<eRestoran.Model.Rezervacija> GetByDates(DateTime dateFrom, DateTime dateTo)
        {
            var entity = _context.Rezervacija.Where(x => x.DatumRezervacije>=dateFrom && x.DatumRezervacije<=dateTo).ToList();
            return Mapper.Map<List<eRestoran.Model.Rezervacija>>(entity);
        }

        public eRestoran.Model.Rezervacija Insert(RezervacijaInsertRequest request)
        {
            var entity = _mapper.Map<Database.Rezervacija>(request);
            entity.NaCekanju = true;
            _context.Rezervacija.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eRestoran.Model.Rezervacija>(entity);

        }

        public eRestoran.Model.Rezervacija Update(int id,RezervacijaUpdateRequest rezervacija)
        {
            var entity = _context.Rezervacija.Find(id);

            _mapper.Map(rezervacija, entity);
            _context.SaveChanges();
            return _mapper.Map<eRestoran.Model.Rezervacija>(entity);
        }

        public List<eRestoran.Model.Rezervacija> GetByKlijent(int id)
        {
            var list = _context.Rezervacija.Where(x => x.KlijentId == id).ToList();
            return Mapper.Map<List<eRestoran.Model.Rezervacija>>(list);
        }
    }
}
