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
    public partial class frmNabavkaDetalji : Form
    {
        private int? _id = null;
        private readonly ApiService _service = new ApiService("NabavkaPice");
        private readonly ApiService _piceService = new ApiService("Pice");
        private readonly ApiService _nabavkaNamirnicaService = new ApiService("NabavkaNamirnica");
        private readonly ApiService _namirnicaService = new ApiService("Namirnica");

        public frmNabavkaDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmNabavkaDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var piceStavke = await _service.Get<List<eRestoran.Model.NabavkaPice>>(_id);
                foreach (var item in piceStavke)
                {
                    var pice = await _piceService.GetById<eRestoran.Model.Pice>(item.PiceId);
                    item.Pice= pice.Naziv;
                   
                    item.UkupnaCijenaPice = Math.Round(pice.Cijena * item.Kolicina);
                }
                var namirniceStavke = await _nabavkaNamirnicaService.Get<List<eRestoran.Model.NabavkaNamirnica>>(_id);
                foreach (var item in namirniceStavke)
                {
                    var namirnica = await _namirnicaService.GetById<eRestoran.Model.Namirnica>(item.NamirnicaId);
                    item.Namirnica = namirnica.Naziv;
                    item.UkupnaCijena = Math.Round(namirnica.CijenaPoKomadu * item.Kolicina);
                   
                }
                dgvNabavkePice.DataSource = piceStavke;
                dgvNamirnice.DataSource = namirniceStavke;
            }
        }

      
    }
}