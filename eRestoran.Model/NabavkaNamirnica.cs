using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class NabavkaNamirnica
    {
        public int NabavkaId { get; set; }
        public string Namirnica { get; set; }
        public int NamirnicaId { get; set; }
        public decimal Kolicina { get; set; }
        public int NabavkaNamirnicaId { get; set; }
        public decimal UkupnaCijena { get; set; }
    }
}
