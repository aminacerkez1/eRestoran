using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eRestoran.Model.Requests
{
    public class NarudzbaInsertRequest
    {
        [Required]
        public int KlijentId { get; set; }

        [Required]
        public DateTime DatumNarudzbe { get; set; }

        [Required]
        public string VrijemeNarudzbe { get; set; }

        [Required]
        public decimal CijenaNarudzbe { get; set; }

        public bool? Prihvaceno { get; set; }
        public bool? Otkazano { get; set; }
        public bool? Izvrseno { get; set; }
        public bool? NaCekanju { get; set; }
    }
}
