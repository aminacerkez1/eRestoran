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
    public partial class frmZaposlenikDetalji : Form
    {
        private readonly ApiService _service = new ApiService("zaposlenik");
        private readonly ApiService ulogaService = new ApiService("uloga");

        private int? _id = null;
        public frmZaposlenikDetalji(int? ZaposlenikID=null)
        {
            InitializeComponent();
            _id = ZaposlenikID;

            DialogResult = DialogResult.None;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var selectedUloga = comboBoxUloga.SelectedItem.ToString();
            var uloga = await ulogaService.GetByName<eRestoran.Model.Uloga>(selectedUloga);
            var request = new ZaposlenikInsertRequest()
            {
                Email = txtEmail.Text,
                Ime=txtIme.Text,
                Prezime=txtPrezime.Text,
                Telefon=txtTelefon.Text,
                DatumRodjenja=dateTimePickerDatumRodjenja.Value,
                DatumZaposlenja=dateTimePickerDatumZaposlenja.Value,
                UlogaId=uloga.UlogaId,
                IsAdministrator=chxbAministrator.Checked,
            };

            if(_id.HasValue)
            {
                await _service.Update<eRestoran.Model.Zaposlenik>((int)_id, request);
            }
            else
            {
                await _service.Insert<eRestoran.Model.Zaposlenik>(request);
            }

            MessageBox.Show("Operacija je uspjesna");

           // this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private async void FrmZaposlenikDetalji_Load(object sender, EventArgs e)
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
                txtIme.Enabled = false;
                txtPrezime.Text = zaposlenik.Prezime;
                txtPrezime.Enabled = false;
                txtEmail.Text = zaposlenik.Email;
                txtEmail.Enabled = false;
                txtTelefon.Text = zaposlenik.Telefon;
                txtTelefon.Enabled = false;
                dateTimePickerDatumRodjenja.Value = (DateTime)zaposlenik.DatumRodjenja;
                dateTimePickerDatumRodjenja.Enabled = false;
                dateTimePickerDatumZaposlenja.Value = zaposlenik.DatumZaposlenja;
                dateTimePickerDatumZaposlenja.Enabled = false;
                chxbAministrator.Checked = zaposlenik.IsAdministrator;
                chxbAministrator.Enabled = false;
                comboBoxUloga.DataSource = ulogeNaziv;
                comboBoxUloga.Enabled = false;
                comboBoxUloga.SelectedItem = uloga.Naziv;
                
            }
            else
            {
                comboBoxUloga.DataSource = ulogeNaziv;
            }
        }

        
    }
}
