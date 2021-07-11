using AutoMapper;
using eRestoran.Model.Requests;
using eRestoran_API.Database;
using eRestoran_API.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public class KlijentService:IKlijentService
    {
        private readonly IB140235Context _context;
        private readonly IMapper _mapper;

        public KlijentService(IB140235Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<eRestoran.Model.Klijent> Get(KlijentSearchRequest request)
        {
            var query = _context.Klijent.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));

            }
            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));

            }

            var list = query.ToList();
            

            return _mapper.Map<List<eRestoran.Model.Klijent>>(list);
        }

        public eRestoran.Model.Klijent Authenticiraj(string username, string password)
        {
            var user = _context.Klijent.FirstOrDefault(x => x.Username == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt, password);

                if (newHash == user.PasswordHash)
                {

                    return _mapper.Map<eRestoran.Model.Klijent>(user);
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


        public eRestoran.Model.Klijent Insert(KlijentInsertRequest request)
        {
            var entity = _mapper.Map<Database.Klijent>(request);
            
            if (request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Passwordi se ne podudaraju!!");
            }
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            _context.Klijent.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eRestoran.Model.Klijent>(entity);

        }


        public eRestoran.Model.Klijent GetById(int id)
        {
            var entity = _context.Klijent.Find(id);
            return Mapper.Map<eRestoran.Model.Klijent>(entity);

        }

        public eRestoran.Model.Klijent Update(int id, KlijentInsertRequest request)
        {
            var entity = _context.Klijent.Find(id);

            _mapper.Map(request, entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new Exception("Passwordi se ne podudaraju!!");
                }
            }
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            _context.SaveChanges();

            return _mapper.Map<eRestoran.Model.Klijent>(entity);
        }

    }
}
