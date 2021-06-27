using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public interface INabavkaNamirnicaService
    {
        List<eRestoran.Model.NabavkaNamirnica> Get(int id);
        eRestoran.Model.NabavkaNamirnica Insert(NabavkaNamirnicaInsertRequest request);

    }
}
