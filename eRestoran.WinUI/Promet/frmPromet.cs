using eRestoran.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI.Promet
{
    public partial class frmPromet : Form
    {
        private readonly ApiService _apiService = new ApiService("Narudzba");
        public frmPromet()
        {
            InitializeComponent();
        }

        private async void frmPromet_Load(object sender, EventArgs e)
        {
            decimal sumaMjesec = 0;
            decimal sumaGodina = 0;
            int brojacmjesec = 0;
            int brojacgodine = 0;
            
            var narudzbe = await _apiService.Get<List<eRestoran.Model.Narudzba>>(null);
            
            foreach (var item in narudzbe)
            {
                if(item.DatumNarudzbe.Month==DateTime.Now.Month && item.Prihvaceno==true)
                {
                    brojacmjesec++;
                    sumaMjesec += item.CijenaNarudzbe;
                }
               
            }

            foreach (var item in narudzbe)
            {
                if (item.DatumNarudzbe.Year == DateTime.Now.Year && item.Prihvaceno == true)
                {
                    brojacgodine++;
                    sumaGodina += item.CijenaNarudzbe;
                }

            }
            textBoxMonth.Text = sumaMjesec.ToString();
            textBoxYear.Text = sumaGodina.ToString();
            textMonthNumber.Text = brojacmjesec.ToString();
            textYearNumber.Text = brojacgodine.ToString();
        }

      
    }
}
