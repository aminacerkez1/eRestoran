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

namespace eRestoran.WinUI.Nabavka
{
    public partial class frmNabavkaNovaPica : Form
    {
        private int? _id = null;

        private readonly ApiService _servicePice = new ApiService("Pice");
        public frmNabavkaNovaPica(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSnimiPice_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text.Length == 0 || txtCijena.Text.Length == 0)
            {
                MessageBox.Show("Popunite sva obavezna polja!");
                return;
            }
            var novoPice = new PiceInsertRequest()
            {
                Naziv = txtNaziv.Text,
                Cijena = decimal.Parse(txtCijena.Text),
                StanjeNaSkladistu = (int)numericUpDownPice.Value
            };
           
            await _servicePice.Insert<eRestoran.Model.Pice>(novoPice);
            Close();
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtNaziv, null);
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCijena.Text))
            {
                errorProvider1.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtCijena, null);
            }
        }

     
    }
}
