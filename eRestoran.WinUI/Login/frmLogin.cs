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

namespace eRestoran.WinUI.Login
{
    public partial class frmLogin : Form
    {

        private readonly ApiService _apiService = new ApiService("Zaposlenik");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            ApiService.Username = txtUsername.Text;
            ApiService.Password = txtPassword.Text;
            try
            {
                var list = await _apiService.Get<List<eRestoran.Model.Zaposlenik>>(null);
                var user = list.Where(x => x.Username == ApiService.Username).FirstOrDefault();
                if (user != null)
                {
                    var newHash = Util.GenerateHash(user.PasswordSalt, ApiService.Password);
                    if (newHash == user.PasswordHash)
                    {
                        Global.LoggedUser = user;
                        this.Hide();
                        frmMain frm = new frmMain();
                        frm.Show();
                       
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                    }
                }
                else
                {
                    MessageBox.Show("User doesn't exist");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
