using System;
using System.Collections.Generic;

namespace eRestoran_API.Database
{
    public partial class Jelo
    {
        public Jelo()
        {
            NarudzbaJelo = new HashSet<NarudzbaJelo>();
            Ocjena = new HashSet<Ocjena>();
        }

        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int VrstaJelaId { get; set; }
        public int JeloId { get; set; }

        public VrstaJela VrstaJela { get; set; }
        public ICollection<NarudzbaJelo> NarudzbaJelo { get; set; }
        public ICollection<Ocjena> Ocjena { get; set; }
    }
}
