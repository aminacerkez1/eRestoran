using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace eRestoran.Model.Requests
{
    public class ZaposlenikInsertRequest
    {
        [Required]
        [MinLength(3)]
        public string Ime { get; set; }

        [Required]
        [MinLength(3)]
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }

        [Required]
        public DateTime DatumZaposlenja { get; set; }

        [Required]
        public bool IsAdministrator { get; set; }

        [Required]
        public int UlogaId { get; set; }

        [Required]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Telefon { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string PasswordConfirmation { get; set; }

    }
}
