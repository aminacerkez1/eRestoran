using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eRestoran.Model.Requests
{
    public class JeloInsertRequest
    {
       
        public string Naziv { get; set; }

        public decimal Cijena { get; set; }

        public byte? [] Slika { get; set; }
        public byte? [] SlikaThumb { get; set; }

        public int VrstaJelaId { get; set; }

         }
}
