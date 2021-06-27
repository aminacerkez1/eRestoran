using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model.Requests
{
    public class PiceInsertRequest
    {
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int StanjeNaSkladistu { get; set; }
       
    }
}
