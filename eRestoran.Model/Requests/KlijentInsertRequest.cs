using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eRestoran.Model.Requests
{
    public class KlijentInsertRequest
    {

        [Required]
        [MinLength(3)]
        public string Ime { get; set; }

        [Required]
        [MinLength(3)]
        public string Prezime { get; set; }

        [Required]
        public string BrojTelefona { get; set; }

        [Required]
        public string Adresa { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string PasswordConfirmation { get; set; }
    }
}
