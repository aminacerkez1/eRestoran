using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class NarudzbaJelo
    {
        public int NarudzbaJeloId { get; set; }
        public int NarudzbaId { get; set; }
        public int JeloId { get; set; }
        public string Jelo { get; set; }
        public int KolicinaJela { get; set; }
        public int? PrilogJelaId { get; set; }
        public decimal? KolicinaPriloga { get; set; }
        
    }
}
