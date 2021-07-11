using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public interface IOcjenaService
    {
        eRestoran.Model.Ocjena GetById(int id);

        List<eRestoran.Model.Ocjena> Get();

        eRestoran.Model.Ocjena Insert(OcjenaInsertRequest ocjena);

    }
}
