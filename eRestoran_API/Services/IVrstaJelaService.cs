using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Services
{
    public interface IVrstaJelaService
    {
        eRestoran.Model.VrstaJela GetById(int id);


        eRestoran.Model.VrstaJela GetByName(string name);

        List<eRestoran.Model.VrstaJela> Get();

    }
}
