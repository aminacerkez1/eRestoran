using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eRestoran.Model.Requests;

namespace eRestoran.WinUI.Pica
{
    public partial class frmPiceDodaj : Form
    {
        private int? _id = null;

        private readonly ApiService _servicePice = new ApiService("Pice");
        public frmPiceDodaj(int? id = null)
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
