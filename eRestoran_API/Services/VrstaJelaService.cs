using AutoMapper;
using eRestoran_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public class VrstaJelaService:IVrstaJelaService
    {
        private readonly IB140235Context _context;
        private readonly IMapper _mapper;

        public VrstaJelaService(IB140235Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<eRestoran.Model.VrstaJela> Get()
        {
            var list = _context.VrstaJela.ToList();
            return Mapper.Map<List<eRestoran.Model.VrstaJela>>(list);
        }

        public eRestoran.Model.VrstaJela GetById(int id)
        {
            var entity = _context.VrstaJela.Find(id);
            return Mapper.Map<eRestoran.Model.VrstaJela>(entity);
        }

        public eRestoran.Model.VrstaJela GetByName(string name)
        {
            var entity = _context.VrstaJela.Where(x => x.Naziv == name).SingleOrDefault();
            return Mapper.Map<eRestoran.Model.VrstaJela>(entity);
        }
    }
}
