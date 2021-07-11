using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public interface IKlijentService
    {
        List<eRestoran.Model.Klijent> Get(KlijentSearchRequest request);


        eRestoran.Model.Klijent GetById(int id);


        eRestoran.Model.Klijent Authenticiraj(string username, string password);


        eRestoran.Model.Klijent Insert(KlijentInsertRequest request);


        eRestoran.Model.Klijent Update(int id, KlijentInsertRequest request);
    }
}
