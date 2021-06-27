using System;
using System.Collections.Generic;

namespace eRestoran_API.Database
{
    public partial class Zaposlenik
    {
        public Zaposlenik()
        {
            Nabavka = new HashSet<Nabavka>();
        }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public bool IsAdministrator { get; set; }
        public int UlogaId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public int ZaposlenikId { get; set; }

        public Uloga Uloga { get; set; }
        public ICollection<Nabavka> Nabavka { get; set; }
    }
}
