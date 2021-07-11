 using eRestoran.Model;
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

namespace eRestoran.WinUI.Jelo            
{
    public partial class frmJeloDodaj : Form
    {
        private int? _id = null;

        private readonly ApiService _service = new ApiService("VrstaJela");
        private readonly ApiService _serviceJelo = new ApiService("Jelo");

        public frmJeloDodaj(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmJeloDodaj_Load(object sender, EventArgs e)
        {
            var vrstaJela = await _service.Get<List<eRestoran.Model.VrstaJela>>(null);

            var vrstaNaziv = new List<String>();


            vrstaNaziv.Add("Izaberite vrstu jela");

            foreach (var item in vrstaJela)
            {
                vrstaNaziv.Add(item.Naziv);
            }


            comboBoxVrstaJela.DataSource = vrstaNaziv;
            comboBoxVrstaJela.SelectedItem = "Izaberite vrstu jela";
        }

        private async void btnSnimiJelo_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text.Length == 0 || txtCijena.Text.Length == 0 || comboBoxVrstaJela.Text.ToString()=="Izaberite vrstu jela")
            {
                MessageBox.Show("Popunite sva obavezna polja!");
                return;
            }

            if (comboBoxVrstaJela.SelectedItem.ToString() == "Izaberite vrstu jela")
                {
                    MessageBox.Show("Jelo je obavezno!");
                    return;
                }
                var selectedVrstaJela = comboBoxVrstaJela.SelectedItem.ToString();


                var vrstaJela = await _service.GetByName<eRestoran.Model.VrstaJela>(selectedVrstaJela);


                var novoJelo = new JeloInsertRequest()
                {
                    Naziv = txtNaziv.Text,
                    Cijena = decimal.Parse(txtCijena.Text),
                    VrstaJelaId = vrstaJela.VrstaJelaId
                };
                await _serviceJelo.Insert<eRestoran.Model.Jelo>(novoJelo);
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
                errorProvider1.SetError(txtCijena, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtCijena, null);
            }
        }

        private void comboBoxVrstaJela_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxVrstaJela.SelectedItem.ToString() == "Izaberite vrstu jela")
            {
                errorProvider1.SetError(comboBoxVrstaJela, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(comboBoxVrstaJela, null);
            }
        }

       
    }
}
