
namespace eRestoran.WinUI.Jelo
{
    partial class frmJeloDodaj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJeloDodaj));
            this.Nabavke = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxVrstaJela = new System.Windows.Forms.ComboBox();
            this.btnSnimiJelo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nabavke
            // 
            this.Nabavke.AutoSize = true;
            this.Nabavke.BackColor = System.Drawing.Color.Transparent;
            this.Nabavke.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nabavke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nabavke.Location = new System.Drawing.Point(53, 55);
            this.Nabavke.Name = "Nabavke";
            this.Nabavke.Size = new System.Drawing.Size(120, 25);
            this.Nabavke.TabIndex = 33;
            this.Nabavke.Text = "Dodaj jelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 32;
            this.label2.Text = "Cijena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 31;
            this.label1.Text = "Naziv";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(58, 206);
            this.txtCijena.Margin = new System.Windows.Forms.Padding(4);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(235, 20);
            this.txtCijena.TabIndex = 30;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(58, 149);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(235, 22);
            this.txtNaziv.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 14);
            this.label3.TabIndex = 34;
            this.label3.Text = "Vrsta jela";
            // 
            // comboBoxVrstaJela
            // 
            this.comboBoxVrstaJela.FormattingEnabled = true;
            this.comboBoxVrstaJela.Location = new System.Drawing.Point(58, 260);
            this.comboBoxVrstaJela.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxVrstaJela.Name = "comboBoxVrstaJela";
            this.comboBoxVrstaJela.Size = new System.Drawing.Size(235, 21);
            this.comboBoxVrstaJela.TabIndex = 47;
            // 
            // btnSnimiJelo
            // 
            this.btnSnimiJelo.BackColor = System.Drawing.Color.Red;
            this.btnSnimiJelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSnimiJelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSnimiJelo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimiJelo.ForeColor = System.Drawing.Color.White;
            this.btnSnimiJelo.Location = new System.Drawing.Point(58, 315);
            this.btnSnimiJelo.Name = "btnSnimiJelo";
            this.btnSnimiJelo.Size = new System.Drawing.Size(235, 30);
            this.btnSnimiJelo.TabIndex = 48;
            this.btnSnimiJelo.Text = "Snimi";
            this.btnSnimiJelo.UseVisualStyleBackColor = false;
            this.btnSnimiJelo.Click += new System.EventHandler(this.btnSnimiJelo_Click);
            // 
            // frmJeloDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(353, 450);
            this.Controls.Add(this.btnSnimiJelo);
            this.Controls.Add(this.comboBoxVrstaJela);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nabavke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtNaziv);
            this.DoubleBuffered = true;
            this.Name = "frmJeloDodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmJeloDodaj";
            this.Load += new System.EventHandler(this.frmJeloDodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nabavke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxVrstaJela;
        private System.Windows.Forms.Button btnSnimiJelo;
    }
}