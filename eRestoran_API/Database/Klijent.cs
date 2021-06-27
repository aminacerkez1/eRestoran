using System;
using System.Collections.Generic;

namespace eRestoran_API.Database
{
    public partial class Klijent
    {
        public Klijent()
        {
            Narudzba = new HashSet<Narudzba>();
            Ocjena = new HashSet<Ocjena>();
            Rezervacija = new HashSet<Rezervacija>();
        }
        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public string Adresa { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        

        public ICollection<Narudzba> Narudzba { get; set; }
        public ICollection<Ocjena> Ocjena { get; set; }
        public ICollection<Rezervacija> Rezervacija { get; set; }
    }
}
