using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eRestoran.Model.Requests
{
    public class NarudzbaJeloInsertRequest
    {
        [Required]
        public int NarudzbaId { get; set; }

        [Required]
        public int JeloId { get; set; }

        [Required]
        public int KolicinaJela { get; set; }
        public int? PrilogJelaId { get; set; }
        public decimal? KolicinaPriloga { get; set; }
    }
}
