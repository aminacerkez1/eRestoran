using System;
using System.Collections.Generic;

namespace eRestoran_API.Database
{
    public partial class Narudzba
    {
        public Narudzba()
        {
            NarudzbaJelo = new HashSet<NarudzbaJelo>();
        }

        public int KlijentId { get; set; }
        public DateTime DatumNarudzbe { get; set; }
        public string VrijemeNarudzbe { get; set; }
        public decimal CijenaNarudzbe { get; set; }
        public bool? Prihvaceno { get; set; }
        public bool? Otkazano { get; set; }
        public bool? Izvrseno { get; set; }
        public bool? NaCekanju { get; set; }
        public int NarudzbaId { get; set; }

        public Klijent Klijent { get; set; }
        public ICollection<NarudzbaJelo> NarudzbaJelo { get; set; }
    }
}
