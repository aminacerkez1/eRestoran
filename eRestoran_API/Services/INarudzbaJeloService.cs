using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public interface INarudzbaJeloService
    {
        List<eRestoran.Model.NarudzbaJelo> GetByNarudzbe(int id);

        List<eRestoran.Model.NarudzbaJelo> Get();
        eRestoran.Model.NarudzbaJelo GetById(int id);
    }
}
