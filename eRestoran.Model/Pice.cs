using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class Pice
    {
        public int PiceId { get; set; }
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int StanjeNaSkladistu { get; set; }
        

    }
}
