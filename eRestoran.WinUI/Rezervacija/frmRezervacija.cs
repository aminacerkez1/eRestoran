using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI.Rezervacija
{
    public partial class frmRezervacija : Form
    {
        private readonly ApiService _apiService = new ApiService("Rezervacija");

        public frmRezervacija()
        {
            
            InitializeComponent();
            
        }
        
        private async void frmRezervacija_Load(object sender, EventArgs e)
        {
            
            var result = await _apiService.GetByDates<List<eRestoran.Model.Rezervacija>>(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"));

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
            dgvRezervacije.DataSource = result;
            dgvRezervacije.AutoGenerateColumns = false;

        }

        private async void onFormClosing(object sender, FormClosingEventArgs e)
        {
           
            var result = await _apiService.GetByDates<List<eRestoran.Model.Rezervacija>>(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"));

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
            dgvRezervacije.DataSource = result;
            dgvRezervacije.AutoGenerateColumns = false;
        }



        private void dgvRezervacije_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvRezervacije.SelectedRows[0].Cells[0].Value;
            frmRezervacijaDetalji frm = new frmRezervacijaDetalji(int.Parse(id.ToString()));
            frm.FormClosing += new FormClosingEventHandler(onFormClosing);
            frm.ShowDialog();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private async void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            var startDate = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-ddTHH:mm:ss");
            var endDate = monthCalendar1.SelectionRange.End.ToString("yyyy-MM-ddTHH:mm:ss");
            var result = await _apiService.GetByDates<List<eRestoran.Model.Rezervacija>>(startDate, endDate);
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
            dgvRezervacije.DataSource = result;
        }

       
    }
}
