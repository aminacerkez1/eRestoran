using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class Namirnica
    {
        public int NamirnicaId { get; set; }
        public string Naziv { get; set; }
        public decimal CijenaPoKomadu { get; set; }
        public bool IsPrilog { get; set; }
        public decimal StanjeNaSkladistu { get; set; }
    }
}
