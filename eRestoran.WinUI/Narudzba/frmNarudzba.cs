using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI.Narudzba
{
    public partial class frmNarudzba : Form
    {

        private readonly ApiService _apiService = new ApiService("Narudzba");

        public frmNarudzba()
        {
            InitializeComponent();
        }

        private async void frmNarudzbe_Load(object sender, EventArgs e)
        {
            var result = await _apiService.GetByDates<List<eRestoran.Model.Narudzba>>(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"));
            foreach (var item in result)
            {
                if (item.NaCekanju == true)
                    item.Status = "Na cekanju";
                if (item.Prihvaceno == true)
                    item.Status = "Prihvaćeno";
                if (item.Izvrseno == true)
                    item.Status = "Izvršeno";
                if (item.Otkazano == true)
                    item.Status = "Otkazano";
            }

           
            dgvNarudzbe.DataSource = result;
            dgvNarudzbe.AutoGenerateColumns = false;

        }

        private void dgvNarudzbe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvNarudzbe.SelectedRows[0].Cells[0].Value;
            frmNarudzbaDetalji frm = new frmNarudzbaDetalji(int.Parse(id.ToString()));
            frm.FormClosing += new FormClosingEventHandler(onFormClosing);
            frm.ShowDialog();
        }


        private async void onFormClosing(object sender, FormClosingEventArgs e)
        {

            var result = await _apiService.GetByDates<List<eRestoran.Model.Narudzba>>(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"));
            foreach (var item in result)
            {
                if (item.NaCekanju == true)
                    item.Status = "Na cekanju";
                if (item.Prihvaceno == true)
                    item.Status = "Prihvaćeno";
                if (item.Izvrseno == true)
                    item.Status = "Izvršeno";
                if (item.Otkazano == true)
                    item.Status = "Otkazano";
            }
            
            dgvNarudzbe.DataSource = result;
            dgvNarudzbe.AutoGenerateColumns = false;

        }


        private async void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            var startDate = monthCalendar2.SelectionRange.Start.ToString("yyyy-MM-ddTHH:mm:ss");
            var endDate = monthCalendar2.SelectionRange.End.ToString("yyyy-MM-ddTHH:mm:ss");
            var result = await _apiService.GetByDates<List<eRestoran.Model.Narudzba>>(startDate, endDate);
            foreach (var item in result)
            {
                if (item.NaCekanju == true)
                    item.Status = "Na cekanju";
                if (item.Prihvaceno == true)
                    item.Status = "Prihvaćeno";
                if (item.Izvrseno == true)
                    item.Status = "Izvršeno";
                if (item.Otkazano == true)
                    item.Status = "Otkazano";
            }
            dgvNarudzbe.DataSource = result;
        }

       
    }
}
