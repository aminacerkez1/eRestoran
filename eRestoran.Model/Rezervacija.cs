using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class Rezervacija
    {
        public int RezervacijaID { get; set; }

        public int KlijentId { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public string VrijemeRezervacije { get; set; }
        public int? BrojOsoba { get; set; }
        public string Status { get; set; }

        public bool? Otkazano { get; set; }
        public bool? Prihvaceno { get; set; }
        public bool? NaCekanju { get; set; }
        public bool? Izvrseno { get; set; }

    }
}
