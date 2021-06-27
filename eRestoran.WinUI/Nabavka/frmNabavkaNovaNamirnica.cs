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
    public partial class frmNabavkaNovaNamirnica : Form
    {
        private int? _id = null;

        private readonly ApiService _serviceNamirnica = new ApiService("Namirnica");
        public frmNabavkaNovaNamirnica(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSnimiNamirnica_Click(object sender, EventArgs e)
        {
            var novaNamirnica = new NamirnicaInsertRequest()
            {
                Naziv = txtNamirnica.Text,
                CijenaPoKomadu = decimal.Parse(txtCijena.Text),
                IsPrilog = Prilog.Checked

            };

            await _serviceNamirnica.Insert<eRestoran.Model.Namirnica>(novaNamirnica);
            Close();
        }
    }
}
