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
            

            if (txtIme.Text.Length == 0 || txtPrezime.Text.Length == 0 || txtTelefon.Text.Length == 0 || txtEmail.Text.Length==0 || KorisnickoIme.Text.Length==0 || Lozinka.Text.Length==0 || textLozinkaPotvrda.Text.Length==0
                || comboBoxUloga.Text.Length==0)
            {
                MessageBox.Show("Popunite sva obavezna polja!");
                return;
            }

            if (Lozinka.Text != textLozinkaPotvrda.Text)
            {
                MessageBox.Show("Lozinka i potvrda lozinke nisu jednake!");
                return;
            }


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

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider1.SetError(txtIme, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider1.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtPrezime, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider1.SetError(txtTelefon, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtTelefon, null);
            }
        }

        private void comboBoxUloga_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxUloga.Text))
            {
                errorProvider1.SetError(comboBoxUloga, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(comboBoxUloga, null);
            }
        }

        private void KorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(KorisnickoIme.Text))
            {
                errorProvider1.SetError(KorisnickoIme, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(KorisnickoIme, null);
            }
        }

        private void Lozinka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Lozinka.Text))
            {
                errorProvider1.SetError(Lozinka, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(Lozinka, null);
            }
        }

        private void textLozinkaPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textLozinkaPotvrda.Text))
            {
                errorProvider1.SetError(textLozinkaPotvrda, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(textLozinkaPotvrda, null);
            }
        }
    }
}

