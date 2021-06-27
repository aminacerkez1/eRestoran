using AutoMapper;
using eRestoran.Model.Requests;
using eRestoran_API.Database;
using eRestoran_API.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public class ZaposlenikService : IZaposlenikService
    {
        private readonly IB140235Context _context;
        private readonly IMapper _mapper;

        public ZaposlenikService(IB140235Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public eRestoran.Model.Zaposlenik Authenticiraj(string username, string password)
        {
            var user = _context.Zaposlenik.FirstOrDefault(x => x.Username == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt,password);

                if (newHash == user.PasswordHash)
                {
                    
                    return _mapper.Map<eRestoran.Model.Zaposlenik>(user);
                }
            }
            return null;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public List<eRestoran.Model.Zaposlenik> Get(ZaposlenikSearchRequest request)
        {
            var query = _context.Zaposlenik.AsQueryable();
            if(!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));

            }
            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));

            }

            var list = query.ToList();
            var list2= Mapper.Map<List<eRestoran.Model.Zaposlenik>>(list);
            foreach (var item in list2)
            {
                item.Uloga = _context.Uloga.Find(item.UlogaId).Naziv;
            }

            return list2;
           

        }

        public eRestoran.Model.Zaposlenik GetById(int id)
        {
            var entity = _context.Zaposlenik.Find(id);
            return Mapper.Map<eRestoran.Model.Zaposlenik>(entity);
        }

        public eRestoran.Model.Zaposlenik Insert(ZaposlenikInsertRequest request)
        {
            var entity = _mapper.Map<Database.Zaposlenik>(request);
            if(request.Password!=request.PasswordConfirmation)
            {
                throw new UserException("Passwordi se ne podudaraju!!");
            }
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
          
            _context.Zaposlenik.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eRestoran.Model.Zaposlenik>(entity);

        }

        public eRestoran.Model.Zaposlenik Update(int id, ZaposlenikInsertRequest request)
        {
            var entity = _context.Zaposlenik.Find(id);

            _mapper.Map(request, entity);

            if(!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new Exception("Passwordi se ne podudaraju!!");
                }
            }
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            _context.SaveChanges();

            return _mapper.Map<eRestoran.Model.Zaposlenik>(entity);
        }
    }
}
