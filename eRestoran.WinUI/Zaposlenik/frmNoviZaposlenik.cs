using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI.Zaposlenik
{
    public partial class frmNoviZaposlenik : Form
    {
        private readonly ApiService _service = new ApiService("zaposlenik");
        private readonly ApiService ulogaService = new ApiService("uloga");

        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        private int? _id = null;
        public frmNoviZaposlenik(int? ZaposlenikID = null)
        {
            InitializeComponent();
            _id = ZaposlenikID;

            DialogResult = DialogResult.None;
        }


        private async void frmNoviZaposlenik_Load(object sender, EventArgs e)
        {
            var uloge = await ulogaService.Get<List<eRestoran.Model.Uloga>>(null);
            var ulogeNaziv = new List<String>();
            foreach (var item in uloge)
            {
                ulogeNaziv.Add(item.Naziv);
            }

            if (_id.HasValue)
            {
                var zaposlenik = await _service.GetById<eRestoran.Model.Zaposlenik>(_id);
                var uloga = await ulogaService.GetById<eRestoran.Model.Uloga>(zaposlenik.UlogaId);

                txtIme.Text = zaposlenik.Ime;
                txtPrezime.Text = zaposlenik.Prezime;
                txtEmail.Text = zaposlenik.Email;
                txtTelefon.Text = zaposlenik.Telefon;
                dateTimePickerDatumRodjenja.Value = (DateTime)zaposlenik.DatumRodjenja;
                dateTimePickerDatumZaposlenja.Value = zaposlenik.DatumZaposlenja;
                chxbAministrator.Checked = zaposlenik.IsAdministrator;
                comboBoxUloga.DataSource = ulogeNaziv;
                comboBoxUloga.SelectedItem = uloga.Naziv;
                KorisnickoIme.Text = zaposlenik.Username;
            }
            else
            {
                comboBoxUloga.DataSource = ulogeNaziv;
            }


        }

        private async void btnProfilSpasi_Click(object sender, EventArgs e)
        {
            var selectedUloga = comboBoxUloga.SelectedItem.ToString();
            var uloga = await ulogaService.GetByName<eRestoran.Model.Uloga>(selectedUloga);
            var request = new ZaposlenikInsertRequest()
            {
                Email = txtEmail.Text,
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Telefon = txtTelefon.Text,
                DatumRodjenja = dateTimePickerDatumRodjenja.Value,
                DatumZaposlenja = dateTimePickerDatumZaposlenja.Value,
                UlogaId = uloga.UlogaId,
                IsAdministrator = chxbAministrator.Checked,
                Password = Lozinka.Text,
                PasswordConfirmation = textLozinkaPotvrda.Text,
                Username = KorisnickoIme.Text
            };

            if (_id.HasValue)
            {
                await _service.Update<eRestoran.Model.Zaposlenik>((int)_id, request);
            }
            else
            {
                await _service.Insert<eRestoran.Model.Zaposlenik>(request);
            }

            MessageBox.Show("Operacija je uspjesna");
            Close();
            
        }
    }
}

