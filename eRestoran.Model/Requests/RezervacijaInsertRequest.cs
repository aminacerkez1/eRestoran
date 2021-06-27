using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eRestoran.Model.Requests
{
    public class RezervacijaInsertRequest
    {
        //[Required]
        //public int KlijentId { get; set; }

        //[Required]
        //public DateTime DatumRezervacije { get; set; }

        //[Required]
        //public string VrijemeRezervacije { get; set; }

        //public int? BrojOsoba { get; set; }
        public bool? Otkazano { get; set; }
        public bool? Prihvaceno { get; set; }
        public bool? NaCekanju { get; set; }
        public bool? Izvrseno { get; set; }
    
    }
}
