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

namespace eRestoran.WinUI.Skladiste
{
    public partial class frmSkladisteNamirnicaUredi : Form
    {
        private readonly ApiService _apiService = new ApiService("Namirnica");
        private int? _id = null;
        public frmSkladisteNamirnicaUredi(int? NamirnicaID)
        {
            InitializeComponent();
            _id = NamirnicaID;
        }

        //frmSkladisteNamirnica
        private async void frmSkladisteNamirnicaUredi_Load(object sender, EventArgs e)
        {
            var pice = await _apiService.GetById<eRestoran.Model.Namirnica>(_id);
            txtNamirnica.Text = pice.Naziv;
            txtNamirnica.Enabled = false;
            txtCijena.Text = pice.CijenaPoKomadu.ToString();
            txtCijena.Enabled = false;
            txtStanje.Text = pice.StanjeNaSkladistu.ToString();
        }

        private async void btnSnimiNamirnica_Click(object sender, EventArgs e)
        {
            var request = new NamirnicaUpdateRequest()
            {
                StanjeUSkladistu = Decimal.Parse(txtStanje.Text),
                Operation = "Azuriranje"
            };

            if (_id.HasValue)
            {
                await _apiService.Update<eRestoran.Model.Namirnica>((int)_id, request);
            }
            Close();
        }
    }
}
