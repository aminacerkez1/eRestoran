using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI.Pica
{
    public partial class frmPica : Form
    {
        private readonly ApiService _apiService = new ApiService("Pice");
        public frmPica()
        {
            InitializeComponent();
        }

        private async void frmPica_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<eRestoran.Model.Pice>>(null);
            dgvPice.AutoGenerateColumns = false;
            dgvPice.DataSource = result;

        }

        private async void onFormClosing(object sender, FormClosingEventArgs e)
        {
            var result = await _apiService.Get<List<eRestoran.Model.Pice>>(null);
            dgvPice.AutoGenerateColumns = false;
            dgvPice.DataSource = result;
        }

        private void btnNovoPice_Click(object sender, EventArgs e)
        {
            frmPiceDodaj frm = new frmPiceDodaj();
            frm.FormClosing += new FormClosingEventHandler(onFormClosing);
            frm.ShowDialog();
        }


































        private void dgvPice_CellContentClick(object sendezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz, DataGridViewCellEventArgs e)
        {

        }
    }
}
