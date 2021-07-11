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
            if (txtPice.Text.Length == 0 || txtCijena.Text.Length == 0 || txtStanje.Text.Length == 0)
            {
                MessageBox.Show("Popunite sva obavezna polja!");
                return;
            }
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

        private void txtPice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPice.Text))
            {
                errorProvider1.SetError(txtPice, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtPice, null);
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCijena.Text))
            {
                errorProvider1.SetError(txtCijena, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtCijena, null);
            }
        }

        private void txtStanje_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStanje.Text))
            {
                errorProvider1.SetError(txtStanje, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtStanje, null);
            }
        }
    }

}
