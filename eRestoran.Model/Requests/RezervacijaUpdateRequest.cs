﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eRestoran.Model.Requests
{
    public class RezervacijaUpdateRequest
    {
       
        public bool? Otkazano { get; set; }
        public bool? Prihvaceno { get; set; }
        public bool? NaCekanju { get; set; }
        public bool? Izvrseno { get; set; }
    
    }
}
