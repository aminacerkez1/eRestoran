using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public interface IPiceService
    {
       eRestoran.Model.Pice GetById(int id);

       List<eRestoran.Model.Pice> Get();
        eRestoran.Model.Pice Update(int id, PiceUpdateRequest request);

        eRestoran.Model.Pice Insert(PiceInsertRequest pice);
    }
}
