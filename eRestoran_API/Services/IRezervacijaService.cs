using eRestoran.Model;
using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public interface IRezervacijaService
    {
        List<eRestoran.Model.Rezervacija> Get();

        eRestoran.Model.Rezervacija GetById(int id);
        List<eRestoran.Model.Rezervacija> GetByDates(DateTime dateFrom, DateTime dateTo);

        eRestoran.Model.Rezervacija Insert(RezervacijaInsertRequest rezervacija);

        eRestoran.Model.Rezervacija Update(int id, RezervacijaUpdateRequest rezervacija);

        List<eRestoran.Model.Rezervacija> GetByKlijent(int id);
    }
}
