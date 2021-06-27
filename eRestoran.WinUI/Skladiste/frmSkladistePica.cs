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

namespace eRestoran.WinUI.Skladiste
{
    public partial class frmSkladistePica : Form
    {
        private readonly ApiService _apiService = new ApiService("Pice");

        public frmSkladistePica()
        {
            InitializeComponent();
        }

        private async void frmSkladistePica_Load(object sender, EventArgs e)
        {
            btnSkladisteNamirnica.BackColor = Color.DarkRed;
            btnSkladistePica.BackColor = Color.Red;
            var result = await _apiService.Get<List<eRestoran.Model.Pice>>(null);
            dgvSkladistePice.AutoGenerateColumns = false;
            dgvSkladistePice.DataSource = result;

        }

        private async void onFormClosing(object sender, FormClosingEventArgs e)
        {
            var result = await _apiService.Get<List<eRestoran.Model.Pice>>(null);
            dgvSkladistePice.AutoGenerateColumns = false;
            dgvSkladistePice.DataSource = result;
        }

        private void btnSkladistePica_Click(object sender, EventArgs e)
        {
            frmSkladistePica_Load(sender, e);
        }

        private void btnSkladisteNamirnica_Click(object sender, EventArgs e)
        {
            btnSkladisteNamirnica.BackColor = Color.Red;
            btnSkladistePica.BackColor = Color.DarkRed;
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }

            frmSkladisteNamirnica frm = new frmSkladisteNamirnica();
            frm.MdiParent = frmMain.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
       
        }

        private void dgvSkladistePice_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var Id = dgvSkladistePice.SelectedRows[0].Cells[0].Value;
            frmSkladistePicaUredi frm = new frmSkladistePicaUredi(int.Parse(Id.ToString()));
            frm.FormClosing += new FormClosingEventHandler(onFormClosing);
            frm.ShowDialog();
        }
    }
}
