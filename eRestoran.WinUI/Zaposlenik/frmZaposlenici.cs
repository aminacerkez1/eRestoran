using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using eRestoran.Model.Requests;

namespace eRestoran.WinUI.Zaposlenik
{
    public partial class frmZaposlenici : Form
    {
        private readonly ApiService _apiService = new ApiService("Zaposlenik");
        public frmZaposlenici()
        {
            InitializeComponent();
        }
         
        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new ZaposlenikSearchRequest()
            {
                Ime=textPretraga.Text

            };
            var result = await _apiService.Get<List<eRestoran.Model.Zaposlenik>>(search);
            dgvZaposlenici.AutoGenerateColumns = false;
            dgvZaposlenici.DataSource = result;

        }

        private void dgvZaposlenici_DoubleClick(object sender, EventArgs e)
        {
            var Id = dgvZaposlenici.SelectedRows[0].Cells[0].Value;
            frmZaposlenikDetalji frm = new frmZaposlenikDetalji(int.Parse(Id.ToString()));

           
            frm.ShowDialog();
        }

        private async void frmZaposlenici_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<eRestoran.Model.Zaposlenik>>(null);
            dgvZaposlenici.AutoGenerateColumns = false;
            dgvZaposlenici.DataSource = result;
            btnNoviZaposlenik.Visible = Global.LoggedUser.IsAdministrator == true ? true : false;

        }

        private void btnNoviZaposlenik_Click(object sender, EventArgs e)
        {
            var Id = dgvZaposlenici.SelectedRows[0].Cells[0].Value;
            frmNoviZaposlenik frm = new frmNoviZaposlenik();
            frm.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            frm.ShowDialog();
        }

        private async void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            var result = await _apiService.Get<List<eRestoran.Model.Zaposlenik>>(null);
            dgvZaposlenici.AutoGenerateColumns = false;
            dgvZaposlenici.DataSource = result;
            btnNoviZaposlenik.Visible = Global.LoggedUser.IsAdministrator == true ? true : false;
        }
    }
}
