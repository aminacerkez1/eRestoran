using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model.Requests
{
    public class NamirnicaUpdateRequest
    {
        public decimal StanjeUSkladistu { get; set; }
        public string Operation { get; set; }
    }
}
