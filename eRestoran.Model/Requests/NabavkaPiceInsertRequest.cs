using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model.Requests
{
    public class NabavkaPiceInsertRequest
    {
        public int NabavkaID { get; set; }
        public int PiceID { get; set; }
        public int Kolicina { get; set; }
    }
}
