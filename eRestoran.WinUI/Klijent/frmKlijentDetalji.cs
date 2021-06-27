using Flurl.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI.Klijent
{
    public partial class frmKlijentDetalji : Form
    {
        private int? _id = null;
        private readonly ApiService _apiService = new ApiService("Klijent");
        private readonly ApiService _apiServiceRez = new ApiService("Rezervacija");
        private readonly ApiService _apiServiceNar = new ApiService("Narudzba");


        public frmKlijentDetalji(int? id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmKlijentDetalji_Load(object sender, EventArgs e)
        {
            var klijent = await _apiService.GetById<eRestoran.Model.Klijent>(_id);
            var rezervacija = await _apiServiceRez.GetByKlijent<List<eRestoran.Model.Rezervacija>>(_id);
            var narudzba = await _apiServiceNar.GetByKlijent<List<eRestoran.Model.Narudzba>>(_id);
            labelImePrezime.Text = klijent.Ime + " " + klijent.Prezime;
            labelAdresa.Text = klijent.Adresa.ToString();
            labelTelefon.Text = klijent.BrojTelefona;

            dgvNarudzbe.AutoGenerateColumns = false;
            dgvRezervacije.AutoGenerateColumns = false;
            dgvRezervacije.DataSource = rezervacija;
            dgvNarudzbe.DataSource = narudzba;

        }






    }
}
