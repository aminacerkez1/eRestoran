using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model.Requests
{
    public class NabavkaNamirnicaInsertRequest
    {
        public int NabavkaID { get; set; }
        public int NamirnicaID { get; set; }
        public decimal Kolicina { get; set; }

    }
}
