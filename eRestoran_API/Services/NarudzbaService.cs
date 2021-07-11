using AutoMapper;
using eRestoran.Model.Requests;
using eRestoran_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public class NarudzbaService:INarudzbaService
    {
        private readonly IB140235Context _context;
        private readonly IMapper _mapper;

        public NarudzbaService(IB140235Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<eRestoran.Model.Narudzba> Get()
        {
            var list = _context.Narudzba.ToList();
            return Mapper.Map<List<eRestoran.Model.Narudzba>>(list);
        }

        public List<eRestoran.Model.Narudzba> GetByDates(DateTime dateFrom, DateTime dateTo)
        {
            var entity = _context.Narudzba.Where(x => x.DatumNarudzbe >= dateFrom && x.DatumNarudzbe <= dateTo).ToList();
            return Mapper.Map<List<eRestoran.Model.Narudzba>>(entity);
        }

        public eRestoran.Model.Narudzba GetById(int id)
        {
            var entity = _context.Narudzba.Where(x => x.NarudzbaId == id).FirstOrDefault();
            return Mapper.Map<eRestoran.Model.Narudzba>(entity);
        }

        public List<eRestoran.Model.Narudzba> GetByKlijent(int id)
        {
            var list = _context.Narudzba.Where(x => x.KlijentId == id).ToList();
            return Mapper.Map<List<eRestoran.Model.Narudzba>>(list);
        }

        public eRestoran.Model.Narudzba Update(int id, NarudzbaUpdateRequest narudzba)
        {
            var entity = _context.Narudzba.Find(id);
            _mapper.Map(narudzba, entity);
            _context.SaveChanges();
            return _mapper.Map<eRestoran.Model.Narudzba>(entity);
        }

        public eRestoran.Model.Narudzba Insert(NarudzbaInsertRequest request)
        {
            var entity = _mapper.Map<Database.Narudzba>(request);
            entity.NaCekanju = true;
            entity.CijenaNarudzbe = 0;
            _context.Narudzba.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eRestoran.Model.Narudzba>(entity);
        }

        public eRestoran.Model.Narudzba UpdateCijena(int id, NarudzbaUpdateCijenaRequest request)
        {
            var entity = _context.Narudzba.Find(id);
            entity.CijenaNarudzbe += request.CijenaNarudzbe;
            _context.SaveChanges();
            return _mapper.Map<eRestoran.Model.Narudzba>(entity);
        }

    }
}
