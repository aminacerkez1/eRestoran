using System;
using System.Collections.Generic;

namespace eRestoran_API.Database
{
    public partial class Ocjena
    {
        public int KlijentId { get; set; }
        public int Ocjena1 { get; set; }
        public int JeloId { get; set; }
        public int OcjenaId { get; set; }

        public Jelo Jelo { get; set; }
        public Klijent Klijent { get; set; }
    }
}
