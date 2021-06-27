using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public interface INarudzbaService
    {

        List<eRestoran.Model.Narudzba> Get();
        eRestoran.Model.Narudzba GetById(int id);

        List<eRestoran.Model.Narudzba> GetByKlijent(int id);

        List<eRestoran.Model.Narudzba> GetByDates(DateTime dateFrom, DateTime dateTo);

        eRestoran.Model.Narudzba Update(int id, NarudzbaInsertRequest narudzba);
    }
}
