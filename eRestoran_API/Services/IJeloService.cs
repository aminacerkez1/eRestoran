using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public interface IJeloService
    {
        eRestoran.Model.Jelo GetById(int id);

        List<eRestoran.Model.Jelo> Get();

        eRestoran.Model.Jelo Insert(JeloInsertRequest jelo);

        List<eRestoran.Model.Jelo> GetRecommendedJelo(int id);

    }
}
