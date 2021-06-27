using System;

namespace eRestoran.Model
{
    public class Zaposlenik
    {
        public int ZaposlenikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public bool IsAdministrator { get; set; }
        public int UlogaId { get; set; }
        public string Uloga { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

    }
}
