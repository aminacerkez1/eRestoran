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
    public partial class frmSkladisteNamirnica : Form
    {
        private int? _id = null;
        private readonly ApiService _apiService = new ApiService("Namirnica");

        public frmSkladisteNamirnica(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmSkladisteNamirnica_Load(object sender, EventArgs e)
        {
            btnSkladisteNamirnica.BackColor = Color.Red;
            btnSkladistePica.BackColor = Color.DarkRed;
            var result = await _apiService.Get<List<eRestoran.Model.Namirnica>>(null);

            dgvSkladisteNamirnica.AutoGenerateColumns = false;
            dgvSkladisteNamirnica.DataSource = result;

        }

        private void btnSkladistePica_Click(object sender, EventArgs e)
        {
            btnSkladisteNamirnica.BackColor = Color.DarkRed;
            btnSkladistePica.BackColor = Color.Red;
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }

            frmSkladistePica frm = new frmSkladistePica();
            frm.MdiParent = frmMain.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnSkladisteNamirnica_Click(object sender, EventArgs e)
        {
            frmSkladisteNamirnica_Load(sender, e);
        }

        private async void onFormClosing(object sender, FormClosingEventArgs e)
        {
            var result = await _apiService.Get<List<eRestoran.Model.Namirnica>>(null);
            dgvSkladisteNamirnica.AutoGenerateColumns = false;
            dgvSkladisteNamirnica.DataSource = result;
        }


        private void dgvSkladisteNamirnica_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var Id = dgvSkladisteNamirnica.SelectedRows[0].Cells[0].Value;
            frmSkladisteNamirnicaUredi frm = new frmSkladisteNamirnicaUredi(int.Parse(Id.ToString()));
            frm.FormClosing += new FormClosingEventHandler(onFormClosing);
            frm.Show();
        }
    }
}
