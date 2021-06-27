using AutoMapper;
using eRestoran.Model.Requests;
using eRestoran_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public class JeloService:IJeloService
    {
        private readonly IB140235Context _context;
        private readonly IMapper _mapper;

        public JeloService(IB140235Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<eRestoran.Model.Jelo> Get()
        {
            var list = _context.Jelo.ToList();
            var mappedList = Mapper.Map<List<eRestoran.Model.Jelo>>(list);
            foreach (var item in mappedList)
            {
                item.VrstaJela = _context.VrstaJela.Find(item.VrstaJelaId).Naziv;
            }
            
            return mappedList;
        }

        public eRestoran.Model.Jelo GetById(int id)
        {
            var entity = _context.Jelo.Find(id);
            var mappedEntity = Mapper.Map<eRestoran.Model.Jelo>(entity);
            mappedEntity.VrstaJela = _context.VrstaJela.Find(entity.VrstaJelaId).Naziv;
            return mappedEntity;
        }


        public eRestoran.Model.Jelo Insert(JeloInsertRequest request)
        {
            var entity = _mapper.Map<Database.Jelo>(request);
            _context.Jelo.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eRestoran.Model.Jelo>(entity);

        }
    }
}
