namespace eRestoran.WinUI.Zaposlenik
{
    partial class frmZaposlenici
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZaposlenici));
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.textPretraga = new System.Windows.Forms.TextBox();
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.ZaposlenikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumZaposlenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nabavke = new System.Windows.Forms.Label();
            this.btnNoviZaposlenik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.Red;
            this.btnPrikazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrikazi.FlatAppearance.BorderSize = 2;
            this.btnPrikazi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrikazi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.ForeColor = System.Drawing.Color.White;
            this.btnPrikazi.Location = new System.Drawing.Point(661, 113);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(217, 30);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // textPretraga
            // 
            this.textPretraga.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPretraga.Location = new System.Drawing.Point(31, 120);
            this.textPretraga.Name = "textPretraga";
            this.textPretraga.Size = new System.Drawing.Size(217, 23);
            this.textPretraga.TabIndex = 1;
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AllowUserToAddRows = false;
            this.dgvZaposlenici.AllowUserToDeleteRows = false;
            this.dgvZaposlenici.AllowUserToResizeRows = false;
            this.dgvZaposlenici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZaposlenici.BackgroundColor = System.Drawing.Color.White;
            this.dgvZaposlenici.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZaposlenici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZaposlenikID,
            this.Ime,
            this.Prezime,
            this.Uloga,
            this.Email,
            this.Telefon,
            this.DatumRodjenja,
            this.DatumZaposlenja});
            this.dgvZaposlenici.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvZaposlenici.EnableHeadersVisualStyles = false;
            this.dgvZaposlenici.GridColor = System.Drawing.Color.White;
            this.dgvZaposlenici.Location = new System.Drawing.Point(31, 191);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZaposlenici.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvZaposlenici.RowHeadersVisible = false;
            this.dgvZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenici.Size = new System.Drawing.Size(847, 353);
            this.dgvZaposlenici.TabIndex = 0;
            this.dgvZaposlenici.DoubleClick += new System.EventHandler(this.dgvZaposlenici_DoubleClick);
            // 
            // ZaposlenikID
            // 
            this.ZaposlenikID.DataPropertyName = "ZaposlenikID";
            this.ZaposlenikID.HeaderText = "ZaposlenikID";
            this.ZaposlenikID.Name = "ZaposlenikID";
            this.ZaposlenikID.ReadOnly = true;
            this.ZaposlenikID.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.Ime.DefaultCellStyle = dataGridViewCellStyle2;
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            this.Prezime.DefaultCellStyle = dataGridViewCellStyle3;
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Uloga
            // 
            this.Uloga.DataPropertyName = "Uloga";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            this.Uloga.DefaultCellStyle = dataGridViewCellStyle4;
            this.Uloga.HeaderText = "Uloga";
            this.Uloga.Name = "Uloga";
            this.Uloga.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            this.Email.DefaultCellStyle = dataGridViewCellStyle5;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red;
            this.Telefon.DefaultCellStyle = dataGridViewCellStyle6;
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Red;
            this.DatumRodjenja.DefaultCellStyle = dataGridViewCellStyle7;
            this.DatumRodjenja.HeaderText = "Datum rođenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            // 
            // DatumZaposlenja
            // 
            this.DatumZaposlenja.DataPropertyName = "DatumZaposlenja";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Red;
            this.DatumZaposlenja.DefaultCellStyle = dataGridViewCellStyle8;
            this.DatumZaposlenja.HeaderText = "Datum zaposlenja";
            this.DatumZaposlenja.Name = "DatumZaposlenja";
            this.DatumZaposlenja.ReadOnly = true;
            // 
            // Nabavke
            // 
            this.Nabavke.AutoSize = true;
            this.Nabavke.BackColor = System.Drawing.Color.Transparent;
            this.Nabavke.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nabavke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nabavke.Location = new System.Drawing.Point(26, 65);
            this.Nabavke.Name = "Nabavke";
            this.Nabavke.Size = new System.Drawing.Size(129, 25);
            this.Nabavke.TabIndex = 6;
            this.Nabavke.Text = "Zaposlenici";
            // 
            // btnNoviZaposlenik
            // 
            this.btnNoviZaposlenik.BackColor = System.Drawing.Color.Red;
            this.btnNoviZaposlenik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNoviZaposlenik.FlatAppearance.BorderSize = 2;
            this.btnNoviZaposlenik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNoviZaposlenik.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviZaposlenik.ForeColor = System.Drawing.Color.White;
            this.btnNoviZaposlenik.Location = new System.Drawing.Point(424, 113);
            this.btnNoviZaposlenik.Name = "btnNoviZaposlenik";
            this.btnNoviZaposlenik.Size = new System.Drawing.Size(217, 30);
            this.btnNoviZaposlenik.TabIndex = 7;
            this.btnNoviZaposlenik.Text = "Novi zaposlenik";
            this.btnNoviZaposlenik.UseVisualStyleBackColor = false;
            this.btnNoviZaposlenik.Click += new System.EventHandler(this.btnNoviZaposlenik_Click);
            // 
            // frmZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 580);
            this.Controls.Add(this.btnNoviZaposlenik);
            this.Controls.Add(this.Nabavke);
            this.Controls.Add(this.dgvZaposlenici);
            this.Controls.Add(this.textPretraga);
            this.Controls.Add(this.btnPrikazi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmZaposlenici";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmZaposlenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox textPretraga;
        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Label Nabavke;
        private System.Windows.Forms.Button btnNoviZaposlenik;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZaposlenikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uloga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumZaposlenja;
    }
}