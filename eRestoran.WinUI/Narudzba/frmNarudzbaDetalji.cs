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

namespace eRestoran.WinUI.Narudzba
{
    public partial class frmNarudzbaDetalji : Form
    {
        private int? _id = null;
        private readonly ApiService _apiService = new ApiService("Narudzba");
        private readonly ApiService _apiServiceNarJela = new ApiService("NarudzbaJelo");
        private readonly ApiService _apiServiceJela = new ApiService("Jelo");
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        
        public frmNarudzbaDetalji(int? id)
        {
            _id = id;
            InitializeComponent();
        }


        private void frmNarudzbaDetalji_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmNarudzbaDetalji_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmNarudzbaDetalji_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new NarudzbaUpdateRequest()
            {
                NaCekanju = true

            };

            await _apiService.Insert<eRestoran.Model.Narudzba>(request);


            MessageBox.Show("Operacija je uspjesna");
        }

        private async void frmNarudzbaDetalji_Load(object sender, EventArgs e)
        {
           
            if (_id.HasValue)
            {
                var narudzba = await _apiService.GetById<eRestoran.Model.Narudzba>(_id);
                var narudzbajela = await _apiServiceNarJela.GetByNarudzbe<List<eRestoran.Model.NarudzbaJelo>>(_id);
                picturePrihvati.Visible = narudzba.DatumNarudzbe.Year == DateTime.Now.Year && narudzba.DatumNarudzbe.Month==DateTime.Now.Month && narudzba.DatumNarudzbe.Day == DateTime.Now.Day ? true : false;
                pictureOtkazi.Visible = narudzba.DatumNarudzbe.Year == DateTime.Now.Year && narudzba.DatumNarudzbe.Month == DateTime.Now.Month && narudzba.DatumNarudzbe.Day == DateTime.Now.Day ? true : false;
                Prihvati.Visible = narudzba.DatumNarudzbe.Year == DateTime.Now.Year && narudzba.DatumNarudzbe.Month == DateTime.Now.Month && narudzba.DatumNarudzbe.Day == DateTime.Now.Day ? true : false;
                Otkazi.Visible = narudzba.DatumNarudzbe.Year == DateTime.Now.Year && narudzba.DatumNarudzbe.Month == DateTime.Now.Month && narudzba.DatumNarudzbe.Day == DateTime.Now.Day ? true : false;
                dateTimePicker2.Value = narudzba.DatumNarudzbe.Date;
                dateTimePicker2.Enabled = false;
                txtCijenaNarudzbe.Text = narudzba.CijenaNarudzbe.ToString();
                txtCijenaNarudzbe.Enabled = false;
                txtVrijeme.Text = narudzba.VrijemeNarudzbe;
                txtVrijeme.Enabled = false;
                foreach (var item in narudzbajela)
                {
                    var jeloo = await _apiServiceJela.GetById<eRestoran.Model.Jelo>(item.JeloId);
                    item.Jelo = jeloo.Naziv;
                }

                dgvNarudzbaJelo.AutoGenerateColumns = false;
                dgvNarudzbaJelo.DataSource = narudzbajela;
            }


        }

        private async void picturePrihvati_Click(object sender, EventArgs e)
        {
           
            var narudzba = await _apiService.GetById<eRestoran.Model.Narudzba>(_id);

            var request = new NarudzbaUpdateRequest()
            {
                Prihvaceno = true
            };
            await _apiService.Update<eRestoran.Model.Narudzba>(narudzba.NarudzbaId, request);
            Close();
        }

        private async void pictureOtkazi_Click(object sender, EventArgs e)
        {
            var narudzba = await _apiService.GetById<eRestoran.Model.Narudzba>(_id);
            var request = new NarudzbaUpdateRequest()
            {
                Prihvaceno = false,
                Otkazano = true
            };
            await _apiService.Update<eRestoran.Model.Narudzba>(narudzba.NarudzbaId, request);
            Close();
        }

        private void UgasiDetalji_Click(object sender, EventArgs e)
        {
            this.Close();
        }



      
       


    }
}

