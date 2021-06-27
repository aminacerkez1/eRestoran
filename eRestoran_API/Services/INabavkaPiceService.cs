using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public interface INabavkaPiceService
    {
        List<eRestoran.Model.NabavkaPice> Get(int id);
        eRestoran.Model.NabavkaPice Insert(NabavkaPiceInsertRequest request);

    }
}
