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
            if (txtNamirnica.Text.Length == 0 || txtCijena.Text.Length == 0 || txtStanje.Text.Length == 0)
            {
                MessageBox.Show("Popunite sva obavezna polja!");
                return;
            }
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

        private void txtNamirnica_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamirnica.Text))
            {
                errorProvider1.SetError(txtNamirnica, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtNamirnica, null);
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
