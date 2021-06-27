using eRestoran.Model.Requests;
using eRestoran_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public interface IZaposlenikService
    {
        List<eRestoran.Model.Zaposlenik> Get(ZaposlenikSearchRequest request);

        eRestoran.Model.Zaposlenik GetById(int id);


        eRestoran.Model.Zaposlenik Insert(ZaposlenikInsertRequest request);

        eRestoran.Model.Zaposlenik Update(int id, ZaposlenikInsertRequest request);


        eRestoran.Model.Zaposlenik Authenticiraj(string username, string password);
    
      
    }
}
