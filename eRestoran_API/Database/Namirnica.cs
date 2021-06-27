using System;
using System.Collections.Generic;

namespace eRestoran_API.Database
{
    public partial class Namirnica
    {
        public Namirnica()
        {
            NabavkaNamirnica = new HashSet<NabavkaNamirnica>();
            NarudzbaJelo = new HashSet<NarudzbaJelo>();
        }

        public string Naziv { get; set; }
        public decimal CijenaPoKomadu { get; set; }
        public decimal StanjeNaSkladistu { get; set; }
        public bool IsPrilog { get; set; }
        public int NamirnicaId { get; set; }

        public ICollection<NabavkaNamirnica> NabavkaNamirnica { get; set; }
        public ICollection<NarudzbaJelo> NarudzbaJelo { get; set; }
    }
}
