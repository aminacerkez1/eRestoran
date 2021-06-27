using System;
using System.Collections.Generic;

namespace eRestoran_API.Database
{
    public partial class VrstaJela
    {
        public VrstaJela()
        {
            Jelo = new HashSet<Jelo>();
        }

        public string Naziv { get; set; }
        public int VrstaJelaId { get; set; }

        public ICollection<Jelo> Jelo { get; set; }
    }
}
