using System;
using System.Collections.Generic;

namespace eRestoran_API.Database
{
    public partial class Rezervacija
    {
        public int KlijentId { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public string VrijemeRezervacije { get; set; }
        public int? BrojOsoba { get; set; }
        public bool? Otkazano { get; set; }
        public bool? Prihvaceno { get; set; }
        public bool? NaCekanju { get; set; }
        public bool? Izvrseno { get; set; }
        public int RezervacijaId { get; set; }

        public Klijent Klijent { get; set; }
    }
}
