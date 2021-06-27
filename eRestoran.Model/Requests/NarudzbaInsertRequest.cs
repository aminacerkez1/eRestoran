using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model.Requests
{
    public class NarudzbaInsertRequest
    {
        public bool? Otkazano { get; set; }
        public bool? Prihvaceno { get; set; }
        public bool? NaCekanju { get; set; }
        public bool? Izvrseno { get; set; }
    }
}
