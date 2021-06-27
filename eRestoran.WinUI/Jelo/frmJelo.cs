using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI.Jelo
{
    public partial class frmJelo : Form
    {

        private readonly ApiService _apiService = new ApiService("Jelo");
        private readonly ApiService _vrstaJelaService = new ApiService("Jelo");

        public frmJelo()
        {
            InitializeComponent();
        }

        private async void onFormClosing(object sender, FormClosingEventArgs e)
        {
            var result = await _apiService.Get<List<eRestoran.Model.Jelo>>(null);
            dgvJelo.AutoGenerateColumns = false;
            dgvJelo.DataSource = result;
        }


        private void btnNovoJelo_Click(object sender, EventArgs e)
        {
            frmJeloDodaj frm = new frmJeloDodaj();
            frm.FormClosing += new FormClosingEventHandler(onFormClosing);
            frm.Show();
        }

        private async void frmJelo_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<eRestoran.Model.Jelo>>(null);
            dgvJelo.AutoGenerateColumns = false;
            dgvJelo.DataSource = result;
        }
    }
}
