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

namespace eRestoran.WinUI.Rezervacija
{

    public partial class frmRezervacijaDetalji : Form
    {
        private int? _id = null;
        private readonly ApiService _apiService = new ApiService("Rezervacija");
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public frmRezervacijaDetalji(int? id)
        {
            _id = id;
            InitializeComponent();
        }

        private void frmRezervacijaDetalji_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmRezervacijaDetalji_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmRezervacijaDetalji_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new RezervacijaInsertRequest()
            {
               NaCekanju=true

            };
          
            await _apiService.Insert<eRestoran.Model.Rezervacija>(request);
          
            MessageBox.Show("Operacija je uspjesna");
        }

        private async void frmRezervacijaDetalji_Load(object sender, EventArgs e)
        {

            if (_id.HasValue)
            {
                var rezervacija = await _apiService.GetById<eRestoran.Model.Rezervacija>(_id);
                picturePrihvati.Visible = rezervacija.DatumRezervacije.Year == DateTime.Now.Year && rezervacija.DatumRezervacije.Month == DateTime.Now.Month && rezervacija.DatumRezervacije.Day == DateTime.Now.Day ? true : false;
                pictureOtkazi.Visible = rezervacija.DatumRezervacije.Year == DateTime.Now.Year && rezervacija.DatumRezervacije.Month == DateTime.Now.Month && rezervacija.DatumRezervacije.Day == DateTime.Now.Day ? true : false;
                Prihvati.Visible = rezervacija.DatumRezervacije.Year == DateTime.Now.Year && rezervacija.DatumRezervacije.Month == DateTime.Now.Month && rezervacija.DatumRezervacije.Day == DateTime.Now.Day ? true : false;
                Otkazi.Visible = rezervacija.DatumRezervacije.Year == DateTime.Now.Year && rezervacija.DatumRezervacije.Month == DateTime.Now.Month && rezervacija.DatumRezervacije.Day == DateTime.Now.Day ? true : false;
                dateTimePicker1.Value = rezervacija.DatumRezervacije.Date;
                dateTimePicker1.Enabled = false;
                txtBrojOsoba.Text = rezervacija.BrojOsoba.ToString();
                txtBrojOsoba.Enabled = false;
                txtVrijeme.Text = rezervacija.VrijemeRezervacije;
                txtVrijeme.Enabled = false;
            }
                
        }

        private async void picturePrihvati_Click(object sender, EventArgs e)
        {
            var rezervacija = await _apiService.GetById<eRestoran.Model.Rezervacija>(_id);

            var request = new RezervacijaInsertRequest()
            {
                Prihvaceno = true
            };
            await _apiService.Update<eRestoran.Model.Rezervacija>(rezervacija.RezervacijaID, request);
            Close();
        }

        private async void pictureOtkazi_Click(object sender, EventArgs e)
        {
            var rezervacija = await _apiService.GetById<eRestoran.Model.Rezervacija>(_id);
            var request = new RezervacijaInsertRequest()
            {
                Prihvaceno = false,
                Otkazano = true
            };
            await _apiService.Update<eRestoran.Model.Rezervacija>(rezervacija.RezervacijaID, request);
            Close();
        }

        private void UgasiDetalji_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
