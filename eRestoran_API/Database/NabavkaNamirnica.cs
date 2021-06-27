using System;
using System.Collections.Generic;

namespace eRestoran_API.Database
{
    public partial class NabavkaNamirnica
    {
        public int NabavkaId { get; set; }
        public int NamirnicaId { get; set; }
        public decimal Kolicina { get; set; }
        public int NabavkaNamirnicaId { get; set; }

        public Nabavka Nabavka { get; set; }
        public Namirnica Namirnica { get; set; }
    }
}
