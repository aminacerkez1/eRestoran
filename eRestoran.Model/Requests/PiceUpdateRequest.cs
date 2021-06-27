using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model.Requests
{
    public class PiceUpdateRequest
    {
        public int StanjeUSkladistu { get; set; }
        public string Operation { get; set; }
    }
}
