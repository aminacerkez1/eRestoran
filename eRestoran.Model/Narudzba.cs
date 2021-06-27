using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class Narudzba
    {
        public int NarudzbaId { get; set; }
        public int KlijentId { get; set; }
        public DateTime DatumNarudzbe { get; set; }
        public string VrijemeNarudzbe { get; set; }
        public decimal CijenaNarudzbe { get; set; }

        public string Status { get; set; }
        public bool? Prihvaceno { get; set; }
        public bool? Otkazano { get; set; }
        public bool? Izvrseno { get; set; }
        public bool? NaCekanju { get; set; }
        
    }
}
