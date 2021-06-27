using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model.Requests
{
    public class NamirnicaInsertRequest
    {
        public string Naziv { get; set; }
        public decimal CijenaPoKomadu { get; set; }
        public bool IsPrilog { get; set; }

    }
}
