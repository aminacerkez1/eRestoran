using eStudio.WinUI.Main;
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
    public partial class frmNabavka : Form
    {
        private readonly ApiService _apiService = new ApiService("Nabavka");
        private readonly ApiService _zaposlenikService = new ApiService("Zaposlenik");


        public frmNabavka()
        {
            InitializeComponent();
        }

        private async void frmNabavka_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<eRestoran.Model.Nabavka>>(null);
            foreach (var item in result)
            {
                var zaposlenik = await _zaposlenikService.GetById<eRestoran.Model.Zaposlenik>(item.ZaposlenikId);
                item.Zaposlenik = zaposlenik.Ime + " " + zaposlenik.Prezime;
            }

            dgvNabavke.AutoGenerateColumns = false;
            dgvNabavke.DataSource = result;
        }

        private void dgvNabavke_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvNabavke.SelectedRows[0].Cells[0].Value;
            frmNabavkaDetalji frm = new frmNabavkaDetalji(int.Parse(id.ToString()));
            frm.ShowDialog();
        }

        private void btnNovaNabavka_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }

            frmNabavkaNova frm = new frmNabavkaNova();
            frm.MdiParent = frmMain.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
