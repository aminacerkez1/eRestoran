using AutoMapper;
using eRestoran.Model.Requests;
using eRestoran_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public class NamirnicaService:INamirnicaService
    {
        private readonly IB140235Context _context;
        private readonly IMapper _mapper;

        public NamirnicaService(IB140235Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<eRestoran.Model.Namirnica> Get()
        {
            var list = _context.Namirnica.ToList();
            return Mapper.Map<List<eRestoran.Model.Namirnica>>(list);
        }


        public List<eRestoran.Model.Namirnica> GetPrilog()
        {
            var list = _context.Namirnica.Where(x=>x.IsPrilog==true).ToList();
            return Mapper.Map<List<eRestoran.Model.Namirnica>>(list);
        }

        public eRestoran.Model.Namirnica Insert(NamirnicaInsertRequest request)
        {
            var entity = _mapper.Map<Database.Namirnica>(request);
            entity.StanjeNaSkladistu = 0;
            _context.Namirnica.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eRestoran.Model.Namirnica>(entity);

        }

        public eRestoran.Model.Namirnica GetById(int id)
        {
            var entity = _context.Namirnica.Find(id);
            return Mapper.Map<eRestoran.Model.Namirnica>(entity);
        }

        public eRestoran.Model.Namirnica Update(int id, NamirnicaUpdateRequest request)
        {
            var entity = _context.Namirnica.Find(id);
            if(request.Operation == "Dodavanje")
            {
                entity.StanjeNaSkladistu += request.StanjeUSkladistu;
            }
            else if (request.Operation == "Azuriranje")
            {
                entity.StanjeNaSkladistu = request.StanjeUSkladistu;
            }
            else
            {
                entity.StanjeNaSkladistu -= request.StanjeUSkladistu;
            }
            _context.SaveChanges();
            return _mapper.Map<eRestoran.Model.Namirnica>(entity);
        }

    }
}
