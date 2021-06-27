using System;
using System.Collections.Generic;

namespace eRestoran_API.Database
{
    public partial class NabavkaPice
    {
        public int NabavkaId { get; set; }
        public int PiceId { get; set; }
        public int Kolicina { get; set; }
        public int NabavkaPiceId { get; set; }

        public Nabavka Nabavka { get; set; }
        public Pice Pice { get; set; }
    }
}
