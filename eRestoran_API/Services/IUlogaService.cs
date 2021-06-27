using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public interface IUlogaService
    {
        List<eRestoran.Model.Uloga> Get();

        eRestoran.Model.Uloga GetByName(string name);

        eRestoran.Model.Uloga GetById(int id);

     
    }
}
