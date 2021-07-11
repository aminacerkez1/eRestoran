using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public interface INamirnicaService
    {
        eRestoran.Model.Namirnica GetById(int id);

        List<eRestoran.Model.Namirnica> Get();
        eRestoran.Model.Namirnica Update(int id, NamirnicaUpdateRequest request);

        eRestoran.Model.Namirnica Insert(NamirnicaInsertRequest pice);

        List<eRestoran.Model.Namirnica> GetPrilog();

    }
}
