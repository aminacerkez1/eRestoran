using System;
using System.Collections.Generic;

namespace eRestoran_API.Database
{
    public partial class Pice
    {
        public Pice()
        {
            NabavkaPice = new HashSet<NabavkaPice>();
        }
        public int PiceId { get; set; }
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int StanjeNaSkladistu { get; set; }
        
        public ICollection<NabavkaPice> NabavkaPice { get; set; }
    }
}
