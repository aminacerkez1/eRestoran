using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public interface INabavkaService
    {
        List<eRestoran.Model.Nabavka> Get();
        eRestoran.Model.Nabavka Insert(NabavkaInsertRequest request);
        eRestoran.Model.Nabavka Update(int id, NabavkaUpdateRequest request);

    }
}
