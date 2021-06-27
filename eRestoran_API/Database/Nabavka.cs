using System;
using System.Collections.Generic;

namespace eRestoran_API.Database
{
    public partial class Nabavka
    {
        public Nabavka()
        {
            NabavkaNamirnica = new HashSet<NabavkaNamirnica>();
            NabavkaPice = new HashSet<NabavkaPice>();
        }

        public DateTime DatumNabavke { get; set; }
        public int ZaposlenikId { get; set; }
        public decimal UkupanIznos { get; set; }
        public int NabavkaId { get; set; }

        public Zaposlenik Zaposlenik { get; set; }
        public ICollection<NabavkaNamirnica> NabavkaNamirnica { get; set; }
        public ICollection<NabavkaPice> NabavkaPice { get; set; }
    }
}
