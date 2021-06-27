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

namespace eRestoran.WinUI.Klijent
{
    public partial class frmKlijenti : Form
    {
        private readonly ApiService _apiService = new ApiService("Klijent");

        public frmKlijenti()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new KlijentSearchRequest()
            {
                Ime = textPretraga.Text

            };
            var result = await _apiService.Get<List<eRestoran.Model.Klijent>>(search);
            dgvKlijenti.AutoGenerateColumns = false;
            dgvKlijenti.DataSource = result;
        }

        private void dgvKlijenti_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                var id = dgvKlijenti.SelectedRows[0].Cells[0].Value;
                frmKlijentDetalji frm = new frmKlijentDetalji(int.Parse(id.ToString()));
                frm.ShowDialog();
        }

        private async void frmKlijenti_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<eRestoran.Model.Klijent>>(null);
            dgvKlijenti.AutoGenerateColumns = false;
            dgvKlijenti.DataSource = result;
        }
    }
    
}
