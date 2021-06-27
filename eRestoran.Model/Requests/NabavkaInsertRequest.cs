using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model.Requests
{
   public class NabavkaInsertRequest
    {
        public DateTime DatumNabavke { get; set; }
        public int ZaposlenikID { get; set; }
        public decimal UkupanIznos { get; set; }

    }
}
