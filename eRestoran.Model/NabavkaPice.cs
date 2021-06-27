using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class NabavkaPice
    {
        public int NabavkaId { get; set; }
        public int PiceId { get; set; }
        public string Pice{ get; set; }

        public int Kolicina { get; set; }
        public int NabavkaPiceId { get; set; }
        public decimal UkupnaCijenaPice { get; set; }

    }
}
