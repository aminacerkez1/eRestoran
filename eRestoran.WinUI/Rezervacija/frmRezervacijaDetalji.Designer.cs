
namespace eRestoran.WinUI.Rezervacija
{
    partial class frmRezervacijaDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervacijaDetalji));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVrijeme = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrojOsoba = new System.Windows.Forms.TextBox();
            this.Nabavke = new System.Windows.Forms.Label();
            this.pictureOtkazi = new System.Windows.Forms.PictureBox();
            this.Otkazi = new System.Windows.Forms.Label();
            this.Prihvati = new System.Windows.Forms.Label();
            this.picturePrihvati = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOtkazi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePrihvati)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 14);
            this.label2.TabIndex = 33;
            this.label2.Text = "Vrijeme rezervacije";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 14);
            this.label1.TabIndex = 32;
            this.label1.Text = "Datum rezervacije";
            // 
            // txtVrijeme
            // 
            this.txtVrijeme.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVrijeme.Location = new System.Drawing.Point(34, 216);
            this.txtVrijeme.Name = "txtVrijeme";
            this.txtVrijeme.Size = new System.Drawing.Size(202, 22);
            this.txtVrijeme.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 14);
            this.label3.TabIndex = 47;
            this.label3.Text = "Broj osoba";
            // 
            // txtBrojOsoba
            // 
            this.txtBrojOsoba.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojOsoba.Location = new System.Drawing.Point(36, 258);
            this.txtBrojOsoba.Name = "txtBrojOsoba";
            this.txtBrojOsoba.Size = new System.Drawing.Size(202, 22);
            this.txtBrojOsoba.TabIndex = 46;
            // 
            // Nabavke
            // 
            this.Nabavke.AutoSize = true;
            this.Nabavke.BackColor = System.Drawing.Color.Transparent;
            this.Nabavke.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nabavke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nabavke.Location = new System.Drawing.Point(31, 61);
            this.Nabavke.Name = "Nabavke";
            this.Nabavke.Size = new System.Drawing.Size(203, 25);
            this.Nabavke.TabIndex = 48;
            this.Nabavke.Text = "Detalji rezervacije";
            // 
            // pictureOtkazi
            // 
            this.pictureOtkazi.BackColor = System.Drawing.Color.Transparent;
            this.pictureOtkazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureOtkazi.ErrorImage = null;
            this.pictureOtkazi.Image = ((System.Drawing.Image)(resources.GetObject("pictureOtkazi.Image")));
            this.pictureOtkazi.InitialImage = null;
            this.pictureOtkazi.Location = new System.Drawing.Point(161, 312);
            this.pictureOtkazi.Margin = new System.Windows.Forms.Padding(2);
            this.pictureOtkazi.Name = "pictureOtkazi";
            this.pictureOtkazi.Size = new System.Drawing.Size(77, 71);
            this.pictureOtkazi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureOtkazi.TabIndex = 59;
            this.pictureOtkazi.TabStop = false;
            this.pictureOtkazi.Click += new System.EventHandler(this.pictureOtkazi_Click);
            // 
            // Otkazi
            // 
            this.Otkazi.AutoSize = true;
            this.Otkazi.BackColor = System.Drawing.Color.Transparent;
            this.Otkazi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Otkazi.Location = new System.Drawing.Point(170, 385);
            this.Otkazi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Otkazi.Name = "Otkazi";
            this.Otkazi.Size = new System.Drawing.Size(51, 17);
            this.Otkazi.TabIndex = 58;
            this.Otkazi.Text = "Otkaži";
            // 
            // Prihvati
            // 
            this.Prihvati.AutoSize = true;
            this.Prihvati.BackColor = System.Drawing.Color.Transparent;
            this.Prihvati.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prihvati.Location = new System.Drawing.Point(46, 385);
            this.Prihvati.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Prihvati.Name = "Prihvati";
            this.Prihvati.Size = new System.Drawing.Size(60, 17);
            this.Prihvati.TabIndex = 57;
            this.Prihvati.Text = "Prihvati";
            // 
            // picturePrihvati
            // 
            this.picturePrihvati.BackColor = System.Drawing.Color.Transparent;
            this.picturePrihvati.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picturePrihvati.ErrorImage = null;
            this.picturePrihvati.Image = ((System.Drawing.Image)(resources.GetObject("picturePrihvati.Image")));
            this.picturePrihvati.InitialImage = null;
            this.picturePrihvati.Location = new System.Drawing.Point(36, 312);
            this.picturePrihvati.Margin = new System.Windows.Forms.Padding(2);
            this.picturePrihvati.Name = "picturePrihvati";
            this.picturePrihvati.Size = new System.Drawing.Size(75, 71);
            this.picturePrihvati.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePrihvati.TabIndex = 56;
            this.picturePrihvati.TabStop = false;
            this.picturePrihvati.Click += new System.EventHandler(this.picturePrihvati_Click);
            // 
            // frmRezervacijaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(295, 450);
            this.Controls.Add(this.pictureOtkazi);
            this.Controls.Add(this.Otkazi);
            this.Controls.Add(this.Prihvati);
            this.Controls.Add(this.picturePrihvati);
            this.Controls.Add(this.Nabavke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrojOsoba);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVrijeme);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRezervacijaDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRezervacijaDetalji_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmRezervacijaDetalji_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmRezervacijaDetalji_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmRezervacijaDetalji_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureOtkazi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePrihvati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVrijeme;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrojOsoba;
        private System.Windows.Forms.Label Nabavke;
        private System.Windows.Forms.PictureBox pictureOtkazi;
        private System.Windows.Forms.Label Otkazi;
        private System.Windows.Forms.Label Prihvati;
        private System.Windows.Forms.PictureBox picturePrihvati;
    }
}