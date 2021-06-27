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
            var novoPice = new PiceInsertRequest()
            {
                Naziv = txtNaziv.Text,
                Cijena = decimal.Parse(txtCijena.Text),
                StanjeNaSkladistu = (int)numericUpDownPice.Value
            };
           
            await _servicePice.Insert<eRestoran.Model.Pice>(novoPice);
            Close();
        }
    }
}
