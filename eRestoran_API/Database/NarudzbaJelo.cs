using System;
using System.Collections.Generic;

namespace eRestoran_API.Database
{
    public partial class NarudzbaJelo
    {
        public int NarudzbaId { get; set; }
        public int JeloId { get; set; }
        public int KolicinaJela { get; set; }
        public int? PrilogJelaId { get; set; }
        public decimal? KolicinaPriloga { get; set; }
        public int NarudzbaJeloId { get; set; }

        public Jelo Jelo { get; set; }
        public Narudzba Narudzba { get; set; }
        public Namirnica PrilogJela { get; set; }
    }
}
