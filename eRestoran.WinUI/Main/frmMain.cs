using eRestoran.WinUI;
using eRestoran.WinUI.Jelo;
using eRestoran.WinUI.Klijent;
using eRestoran.WinUI.Nabavka;
using eRestoran.WinUI.Narudzba;
using eRestoran.WinUI.Profil;
using eRestoran.WinUI.Rezervacija;
using eRestoran.WinUI.Skladiste;
using eRestoran.WinUI.Zaposlenik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eStudio.WinUI.Main
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            frmZaposlenici frm = new frmZaposlenici();
            frm.MdiParent = frmMain.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            frmZaposlenici frm = new frmZaposlenici();
            frm.MdiParent = frmMain.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            txtUsername.Text = Global.LoggedUser.Ime + " " + Global.LoggedUser.Prezime;
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
            WindowState = FormWindowState.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
              WindowState = FormWindowState.Minimized;
        }

        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            frmKlijenti frm = new frmKlijenti();
            frm.MdiParent = frmMain.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            frmRezervacija frm = new frmRezervacija();
            frm.MdiParent = frmMain.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnNabavke_Click(object sender, EventArgs e)
        {
          
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            frmNabavka frm = new frmNabavka();
            frm.MdiParent = frmMain.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();

        }

        private void btnSkladiste_Click(object sender, EventArgs e)
        {

            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            frmSkladistePica frm = new frmSkladistePica();
            frm.MdiParent = frmMain.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();

        }

        private void btnNarudzba_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            frmNarudzba frm = new frmNarudzba();
            frm.MdiParent = frmMain.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnJela_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            frmJelo frm = new frmJelo();
            frm.MdiParent = frmMain.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            frmProfil frm = new frmProfil();
            frm.MdiParent = frmMain.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
