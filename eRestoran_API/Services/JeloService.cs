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

            foreach (var item in mappedList)
            {
                var rateList = _context.Ocjena.Where(x => x.JeloId == item.JeloId).ToList();
                if (rateList.Count > 0)
                {
                    double counter = 0;
                    foreach (var rate in rateList)
                    {
                        counter += rate.Ocjena1;
                    }
                    item.ProsjecnaOcjena = Math.Round(counter / rateList.Count(), 1).ToString();
                }
            }

            return mappedList;
        }

        public eRestoran.Model.Jelo GetById(int id)
        {
            var entity = _context.Jelo.Find(id);
            var mappedEntity = Mapper.Map<eRestoran.Model.Jelo>(entity);
            mappedEntity.VrstaJela = _context.VrstaJela.Find(entity.VrstaJelaId).Naziv;
            var rateList = _context.Ocjena.Where(x => x.JeloId == mappedEntity.JeloId).ToList();
            if (rateList.Count > 0)
            {
                double counter = 0;
                foreach (var rate in rateList)
                {
                    counter += rate.Ocjena1;
                }
                mappedEntity.ProsjecnaOcjena = Math.Round(counter / rateList.Count(), 1).ToString();
            }
            return mappedEntity;
        }


        public eRestoran.Model.Jelo Insert(JeloInsertRequest request)
        {
            var entity = _mapper.Map<Database.Jelo>(request);
            _context.Jelo.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eRestoran.Model.Jelo>(entity);

        }

        Dictionary<int, List<Ocjena>> jela = new Dictionary<int, List<Ocjena>>();

        private void GetProductsData(int jeloId)
        {
            List<Jelo> aktivnaJela = _context.Jelo.Where(x => x.JeloId != jeloId).ToList();
            List<Ocjena> ocjene;

            foreach (Jelo item in aktivnaJela)
            {
                ocjene = _context.Ocjena.Where(x => x.JeloId == item.JeloId).OrderBy(x => x.KlijentId).ToList();

                if (ocjene.Count > 0)
                {
                    jela.Add(item.JeloId, ocjene);
                }
            }

        }

        private double GetSimilarity(List<Ocjena> ratings1, List<Ocjena> ratings2)
        {
            if (ratings1.Count != ratings2.Count)
            {
                return 0;
            }

            double numerator = 0, denominator1 = 0, denominator2 = 0;

            for (int i = 0; i < ratings1.Count; i++)
            {
                numerator = ratings1[i].Ocjena1 * ratings2[i].Ocjena1;

                denominator1 = ratings1[i].Ocjena1 * ratings1[i].Ocjena1 * 1.0;
                denominator2 = ratings2[i].Ocjena1 * ratings2[i].Ocjena1 * 1.0;

            }
            denominator1 = Math.Sqrt(denominator1);
            denominator2 = Math.Sqrt(denominator2);

            double denominator = denominator1 * denominator2;
            if (denominator == 0)
            {
                return 0;
            }
            else
            {
                return numerator / denominator;
            }

        }

        public List<eRestoran.Model.Jelo> GetRecommendedJelo(int jeloId)
        {
            GetProductsData(jeloId);

            List<Ocjena> ratingsOfThisUsluga = _context.Ocjena.Where(x => x.JeloId == jeloId).OrderBy(x => x.KlijentId).ToList();

            List<Ocjena> ratings1 = new List<Ocjena>();
            List<Ocjena> ratings2 = new List<Ocjena>();

            List<Jelo> recommendedJelo = new List<Jelo>();

            foreach (var item in jela)
            {
                foreach (Ocjena r in ratingsOfThisUsluga)
                {
                    if (item.Value.Where(x => x.KlijentId == r.KlijentId).Count() > 0)
                    {
                        ratings1.Add(r);
                        ratings2.Add(item.Value.Where(x => x.KlijentId == r.KlijentId).First());
                    }
                }

                double similarity = 0;
                similarity = GetSimilarity(ratings1, ratings2);

                if (similarity > 0.6)
                {
                    recommendedJelo.Add(_context.Jelo.Where(p => p.JeloId == item.Key).FirstOrDefault());
                }
                ratings1.Clear();
                ratings2.Clear();
            }

            var mappedJelaList = _mapper.Map<List<eRestoran.Model.Jelo>>(recommendedJelo);
            foreach (var item in mappedJelaList)
            {
                var rateList = _context.Ocjena.Where(x => x.JeloId == item.JeloId).ToList();
                if (rateList.Count > 0)
                {
                    double counter = 0;
                    foreach (var rate in rateList)
                    {
                        counter += rate.Ocjena1;
                    }
                    item.ProsjecnaOcjena = Math.Round(counter / rateList.Count(), 1).ToString();
                }
            }
            return mappedJelaList;

        }


    }
}
