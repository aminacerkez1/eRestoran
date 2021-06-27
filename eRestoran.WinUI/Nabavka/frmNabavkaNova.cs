using eRestoran.Model.Requests;
using eStudio.WinUI.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI.Nabavka
{
    public partial class frmNabavkaNova : Form
    {
        private readonly ApiService nabavkaService = new ApiService("Nabavka");
        private readonly ApiService namirnicaService = new ApiService("Namirnica");
        private readonly ApiService piceService = new ApiService("Pice");
        private readonly ApiService nabavkaNamirnicaService = new ApiService("NabavkaNamirnica");
        private readonly ApiService nabavkaPiceService = new ApiService("NabavkaPice");

        private int? _id = null;
        private eRestoran.Model.Nabavka nabavka = new eRestoran.Model.Nabavka();

        public frmNabavkaNova()
        {
            InitializeComponent();
        }

        private async void frmNabavkaNova_Load(object sender, EventArgs e)
        {
            var namirnice = await namirnicaService.Get<List<eRestoran.Model.Namirnica>>(null);
            comboBoxNamirnice.DisplayMember = "Naziv";
            comboBoxNamirnice.ValueMember = "NamirnicaID";
            comboBoxNamirnice.DataSource = namirnice;

            var pica = await piceService.Get<List<eRestoran.Model.Pice>>(null);
            comboBoxPice.DisplayMember = "Naziv";
            comboBoxPice.ValueMember = "PiceID";
            comboBoxPice.DataSource = pica;
        }

        private async void btnDodajNamirnicu_Click(object sender, EventArgs e)
        {
            if (_id == null)
            {
                var nabavkaRequest = new NabavkaInsertRequest()
                {
                    DatumNabavke = DateTime.Now.Date,
                    UkupanIznos = 0,
                    ZaposlenikID = Global.LoggedUser.ZaposlenikId
                };
                nabavka = await nabavkaService.Insert<eRestoran.Model.Nabavka>(nabavkaRequest);
                _id = nabavka.NabavkaId;
            }
            var nabavkaNamirnicaRequest = new NabavkaNamirnicaInsertRequest()
            {
                NabavkaID = nabavka.NabavkaId,
                NamirnicaID = (int)comboBoxNamirnice.SelectedValue,
                Kolicina = (int)numericNamirnice.Value
            };
            await nabavkaNamirnicaService.Insert<eRestoran.Model.NabavkaNamirnica>(nabavkaNamirnicaRequest);
            loadNamirnice(sender, e, nabavka.NabavkaId);
        }

        private async void btnDodajPice_Click(object sender, EventArgs e)
        {
            if (_id == null)
            {
                var nabavkaRequest = new NabavkaInsertRequest()
                {
                    DatumNabavke = DateTime.Now.Date,
                    UkupanIznos = 0,
                    ZaposlenikID = Global.LoggedUser.ZaposlenikId
                };
                nabavka = await nabavkaService.Insert<eRestoran.Model.Nabavka>(nabavkaRequest);
                _id = nabavka.NabavkaId;
            }

            var nabavkaPiceRequest = new NabavkaPiceInsertRequest()
            {

                NabavkaID = nabavka.NabavkaId,
                PiceID = (int)comboBoxPice.SelectedValue,
                Kolicina = (int)numericPice.Value
            };
            await nabavkaPiceService.Insert<eRestoran.Model.NabavkaPice>(nabavkaPiceRequest);
            loadPice(sender, e, nabavka.NabavkaId);
        }

        private async void loadNamirnice(object sender, EventArgs e, int id)
        {
            var stavke = await nabavkaNamirnicaService.Get<List<eRestoran.Model.NabavkaNamirnica>>(id);
            foreach (var item in stavke)
            {
                var namirnicaItem = await namirnicaService.GetById<eRestoran.Model.Namirnica>(item.NamirnicaId);
                item.UkupnaCijena = Math.Round(item.Kolicina * namirnicaItem.CijenaPoKomadu);
                item.Namirnica = namirnicaItem.Naziv;
            }
            dgvNamirnice.DataSource = stavke;
            var namirnica = await namirnicaService.GetById<eRestoran.Model.Namirnica>(comboBoxNamirnice.SelectedValue);
            var request = new NabavkaUpdateRequest()
            {
                Cijena = Math.Round(numericNamirnice.Value * namirnica.CijenaPoKomadu, 2)
            };
            await nabavkaService.Update<eRestoran.Model.Nabavka>((int)_id, request);

            var namirnicaRequest = new NamirnicaUpdateRequest()
            {
                StanjeUSkladistu = (int)numericNamirnice.Value,
                Operation = "Dodavanje"
            };
            await namirnicaService.Update<eRestoran.Model.Namirnica>(namirnica.NamirnicaId, namirnicaRequest);
            numericNamirnice.Value = 1;
        }

        private async void loadPice(object sender, EventArgs e, int id)
        {
            var stavke = await nabavkaPiceService.Get<List<eRestoran.Model.NabavkaPice>>(id);
            foreach (var item in stavke)
            {
                var piceItem = await piceService.GetById<eRestoran.Model.Pice>(item.PiceId);
                item.UkupnaCijenaPice = Math.Round(item.Kolicina * piceItem.Cijena);
                item.Pice = piceItem.Naziv;
            }
            dgvPice.DataSource = stavke;
            var pice = await piceService.GetById<eRestoran.Model.Pice>(comboBoxPice.SelectedValue);
            var request = new NabavkaUpdateRequest()
            {
                Cijena = Math.Round(numericPice.Value * pice.Cijena, 2)
            };
            await nabavkaService.Update<eRestoran.Model.Nabavka>((int)_id, request);
            var piceRequest = new PiceUpdateRequest()
            {
                StanjeUSkladistu = (int)numericPice.Value,
                Operation = "Dodavanje"
            };
            await piceService.Update<eRestoran.Model.Pice>(pice.PiceId, piceRequest);
            numericPice.Value = 1;
        }
        
        private void btnZakljuci_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }

            frmNabavka frm = new frmNabavka();
            
            frm.MdiParent = frmMain.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

       

        private async void onFormClosing(object sender, FormClosingEventArgs e)
        {
            var result = await piceService.Get<List<eRestoran.Model.Pice>>(null);
            comboBoxPice.DisplayMember = "Naziv";
            comboBoxPice.ValueMember = "PiceID";
            comboBoxPice.DataSource = result;
        }

        private async void onFormClosingNamirnica(object sender, FormClosingEventArgs e)
        {
            var result = await namirnicaService.Get<List<eRestoran.Model.Namirnica>>(null);
            comboBoxNamirnice.DisplayMember = "Naziv";
            comboBoxNamirnice.ValueMember = "NamirnicaID";
            comboBoxNamirnice.DataSource = result;
        }

        private void btnNovaNamirnica_Click(object sender, EventArgs e)
        {
            frmNabavkaNovaNamirnica frm = new frmNabavkaNovaNamirnica();
            frm.FormClosing += new FormClosingEventHandler(onFormClosingNamirnica);
            frm.ShowDialog();
        }

        private void btnNovoPice_Click(object sender, EventArgs e)
        {
            frmNabavkaNovaPica frm = new frmNabavkaNovaPica();
            frm.FormClosing += new FormClosingEventHandler(onFormClosing);
            frm.ShowDialog();
        }
    }
}
