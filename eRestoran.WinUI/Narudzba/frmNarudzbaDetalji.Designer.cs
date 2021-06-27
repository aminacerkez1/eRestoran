
namespace eRestoran.WinUI.Narudzba
{
    partial class frmNarudzbaDetalji
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNarudzbaDetalji));
            this.dgvNarudzbaJelo = new System.Windows.Forms.DataGridView();
            this.NarudzbaJeloID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JeloID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KolicinaJela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureOtkazi = new System.Windows.Forms.PictureBox();
            this.Otkazi = new System.Windows.Forms.Label();
            this.Prihvati = new System.Windows.Forms.Label();
            this.picturePrihvati = new System.Windows.Forms.PictureBox();
            this.Nabavke = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCijenaNarudzbe = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVrijeme = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbaJelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOtkazi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePrihvati)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNarudzbaJelo
            // 
            this.dgvNarudzbaJelo.AllowUserToAddRows = false;
            this.dgvNarudzbaJelo.AllowUserToDeleteRows = false;
            this.dgvNarudzbaJelo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNarudzbaJelo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNarudzbaJelo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNarudzbaJelo.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNarudzbaJelo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNarudzbaJelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbaJelo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NarudzbaJeloID,
            this.JeloID,
            this.Jelo,
            this.KolicinaJela});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNarudzbaJelo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNarudzbaJelo.EnableHeadersVisualStyles = false;
            this.dgvNarudzbaJelo.GridColor = System.Drawing.Color.White;
            this.dgvNarudzbaJelo.Location = new System.Drawing.Point(266, 166);
            this.dgvNarudzbaJelo.Name = "dgvNarudzbaJelo";
            this.dgvNarudzbaJelo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNarudzbaJelo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNarudzbaJelo.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            this.dgvNarudzbaJelo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNarudzbaJelo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzbaJelo.Size = new System.Drawing.Size(326, 215);
            this.dgvNarudzbaJelo.TabIndex = 97;
            // 
            // NarudzbaJeloID
            // 
            this.NarudzbaJeloID.DataPropertyName = "NarudzbaJeloID";
            this.NarudzbaJeloID.HeaderText = "NarudzbaJeloID";
            this.NarudzbaJeloID.Name = "NarudzbaJeloID";
            this.NarudzbaJeloID.ReadOnly = true;
            this.NarudzbaJeloID.Visible = false;
            // 
            // JeloID
            // 
            this.JeloID.DataPropertyName = "JeloID";
            this.JeloID.HeaderText = "JeloID";
            this.JeloID.Name = "JeloID";
            this.JeloID.ReadOnly = true;
            this.JeloID.Visible = false;
            // 
            // Jelo
            // 
            this.Jelo.DataPropertyName = "Jelo";
            this.Jelo.HeaderText = "Jelo";
            this.Jelo.Name = "Jelo";
            this.Jelo.ReadOnly = true;
            // 
            // KolicinaJela
            // 
            this.KolicinaJela.DataPropertyName = "KolicinaJela";
            this.KolicinaJela.HeaderText = "Količina jela";
            this.KolicinaJela.Name = "KolicinaJela";
            this.KolicinaJela.ReadOnly = true;
            // 
            // pictureOtkazi
            // 
            this.pictureOtkazi.BackColor = System.Drawing.Color.Transparent;
            this.pictureOtkazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureOtkazi.ErrorImage = null;
            this.pictureOtkazi.Image = ((System.Drawing.Image)(resources.GetObject("pictureOtkazi.Image")));
            this.pictureOtkazi.InitialImage = null;
            this.pictureOtkazi.Location = new System.Drawing.Point(162, 310);
            this.pictureOtkazi.Margin = new System.Windows.Forms.Padding(2);
            this.pictureOtkazi.Name = "pictureOtkazi";
            this.pictureOtkazi.Size = new System.Drawing.Size(77, 71);
            this.pictureOtkazi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureOtkazi.TabIndex = 96;
            this.pictureOtkazi.TabStop = false;
            this.pictureOtkazi.Click += new System.EventHandler(this.pictureOtkazi_Click);
            // 
            // Otkazi
            // 
            this.Otkazi.AutoSize = true;
            this.Otkazi.BackColor = System.Drawing.Color.Transparent;
            this.Otkazi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Otkazi.Location = new System.Drawing.Point(171, 383);
            this.Otkazi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Otkazi.Name = "Otkazi";
            this.Otkazi.Size = new System.Drawing.Size(51, 17);
            this.Otkazi.TabIndex = 95;
            this.Otkazi.Text = "Otkaži";
            // 
            // Prihvati
            // 
            this.Prihvati.AutoSize = true;
            this.Prihvati.BackColor = System.Drawing.Color.Transparent;
            this.Prihvati.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prihvati.Location = new System.Drawing.Point(47, 383);
            this.Prihvati.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Prihvati.Name = "Prihvati";
            this.Prihvati.Size = new System.Drawing.Size(60, 17);
            this.Prihvati.TabIndex = 94;
            this.Prihvati.Text = "Prihvati";
            // 
            // picturePrihvati
            // 
            this.picturePrihvati.BackColor = System.Drawing.Color.Transparent;
            this.picturePrihvati.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picturePrihvati.ErrorImage = null;
            this.picturePrihvati.Image = ((System.Drawing.Image)(resources.GetObject("picturePrihvati.Image")));
            this.picturePrihvati.InitialImage = null;
            this.picturePrihvati.Location = new System.Drawing.Point(37, 310);
            this.picturePrihvati.Margin = new System.Windows.Forms.Padding(2);
            this.picturePrihvati.Name = "picturePrihvati";
            this.picturePrihvati.Size = new System.Drawing.Size(75, 71);
            this.picturePrihvati.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePrihvati.TabIndex = 93;
            this.picturePrihvati.TabStop = false;
            this.picturePrihvati.Click += new System.EventHandler(this.picturePrihvati_Click);
            // 
            // Nabavke
            // 
            this.Nabavke.AutoSize = true;
            this.Nabavke.BackColor = System.Drawing.Color.Transparent;
            this.Nabavke.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nabavke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nabavke.Location = new System.Drawing.Point(32, 64);
            this.Nabavke.Name = "Nabavke";
            this.Nabavke.Size = new System.Drawing.Size(185, 25);
            this.Nabavke.TabIndex = 92;
            this.Nabavke.Text = "Detalji narudžbe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.TabIndex = 91;
            this.label3.Text = "Cijena narudžbe";
            // 
            // txtCijenaNarudzbe
            // 
            this.txtCijenaNarudzbe.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCijenaNarudzbe.Location = new System.Drawing.Point(37, 261);
            this.txtCijenaNarudzbe.Name = "txtCijenaNarudzbe";
            this.txtCijenaNarudzbe.Size = new System.Drawing.Size(202, 22);
            this.txtCijenaNarudzbe.TabIndex = 90;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(35, 166);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 14);
            this.label2.TabIndex = 88;
            this.label2.Text = "Vrijeme narudžbe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 14);
            this.label1.TabIndex = 87;
            this.label1.Text = "Datum narudžbe";
            // 
            // txtVrijeme
            // 
            this.txtVrijeme.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVrijeme.Location = new System.Drawing.Point(35, 219);
            this.txtVrijeme.Name = "txtVrijeme";
            this.txtVrijeme.Size = new System.Drawing.Size(202, 22);
            this.txtVrijeme.TabIndex = 86;
            // 
            // frmNarudzbaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 464);
            this.Controls.Add(this.dgvNarudzbaJelo);
            this.Controls.Add(this.pictureOtkazi);
            this.Controls.Add(this.Otkazi);
            this.Controls.Add(this.Prihvati);
            this.Controls.Add(this.picturePrihvati);
            this.Controls.Add(this.Nabavke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCijenaNarudzbe);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVrijeme);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmNarudzbaDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmNarudzbaDetalji_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmNarudzbaDetalji_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmNarudzbaDetalji_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmNarudzbaDetalji_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbaJelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOtkazi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePrihvati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNarudzbaJelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NarudzbaJeloID;
        private System.Windows.Forms.DataGridViewTextBoxColumn JeloID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KolicinaJela;
        private System.Windows.Forms.PictureBox pictureOtkazi;
        private System.Windows.Forms.Label Otkazi;
        private System.Windows.Forms.Label Prihvati;
        private System.Windows.Forms.PictureBox picturePrihvati;
        private System.Windows.Forms.Label Nabavke;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCijenaNarudzbe;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVrijeme;
    }
}