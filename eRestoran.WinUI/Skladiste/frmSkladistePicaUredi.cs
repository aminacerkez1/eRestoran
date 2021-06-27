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
    public partial class frmSkladistePicaUredi : Form
    {
        private readonly ApiService _apiService = new ApiService("Pice");
        private int? _id = null;


        public frmSkladistePicaUredi(int? PiceID)
        {
            InitializeComponent();
            _id = PiceID;
        }

        private async void frmSkladistePicaUredi_Load(object sender, EventArgs e)
        {
            var pice = await _apiService.GetById<eRestoran.Model.Pice>(_id);
            txtPice.Text = pice.Naziv;
            txtPice.Enabled = false;
            txtCijena.Text = pice.Cijena.ToString();
            txtCijena.Enabled = false;
            txtStanje.Text = pice.StanjeNaSkladistu.ToString();
        }

        private async void btnSnimiPice_Click(object sender, EventArgs e)
        {
            var request = new PiceUpdateRequest()
            {
                StanjeUSkladistu = Int32.Parse(txtStanje.Text),
                Operation = "Azuriranje"
            };

            if (_id.HasValue)
            {
                await _apiService.Update<eRestoran.Model.Pice>((int)_id, request);
            }
            Close();
        }
    }

}
