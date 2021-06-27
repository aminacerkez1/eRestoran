using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class Nabavka
    {
        public DateTime DatumNabavke { get; set; }
        public int ZaposlenikId { get; set; }
        public decimal UkupanIznos { get; set; }
        public int NabavkaId { get; set; }

        public string Zaposlenik { get; set; }
    }
}
