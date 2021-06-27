using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class Jelo
    {
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int VrstaJelaId { get; set; }

        public string JeloNaziv { get; set; }
        public string VrstaJela { get; set; }
        public int JeloId { get; set; }
    }
}
