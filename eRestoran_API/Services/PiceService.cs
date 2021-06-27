using AutoMapper;
using eRestoran.Model.Requests;
using eRestoran_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public class PiceService:IPiceService
    {

        private readonly IB140235Context _context;
        private readonly IMapper _mapper;

        public PiceService(IB140235Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<eRestoran.Model.Pice> Get()
        {
            var list = _context.Pice.ToList();
            return Mapper.Map<List<eRestoran.Model.Pice>>(list);
        }

        public eRestoran.Model.Pice GetById(int id)
        {
            var entity = _context.Pice.Find(id);
            return Mapper.Map<eRestoran.Model.Pice>(entity);
        }

        public eRestoran.Model.Pice Insert(PiceInsertRequest request)
        {
            var entity = _mapper.Map<Database.Pice>(request);
            _context.Pice.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eRestoran.Model.Pice>(entity);

        }
        public eRestoran.Model.Pice Update(int id, PiceUpdateRequest request)
        {
            var entity = _context.Pice.Find(id);
            if (request.Operation == "Dodavanje")
            {
                entity.StanjeNaSkladistu += request.StanjeUSkladistu;
            }
            else if(request.Operation=="Azuriranje")
            {
                entity.StanjeNaSkladistu = request.StanjeUSkladistu;
            }
            else
            {
                entity.StanjeNaSkladistu -= request.StanjeUSkladistu;
            }

            _context.SaveChanges();
            return _mapper.Map<eRestoran.Model.Pice>(entity);
        }

       

    }
}
