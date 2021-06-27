
namespace eRestoran.WinUI.Rezervacija
{
    partial class frmRezervacija
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervacija));
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.RezervacijaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeRezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojOsoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KlijentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otkazano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prihvaceno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaCekanju = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izvrseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nabavke = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AllowUserToAddRows = false;
            this.dgvRezervacije.AllowUserToDeleteRows = false;
            this.dgvRezervacije.AllowUserToResizeColumns = false;
            this.dgvRezervacije.AllowUserToResizeRows = false;
            this.dgvRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRezervacije.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRezervacije.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRezervacije.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervacijaID,
            this.DatumRezervacije,
            this.VrijemeRezervacije,
            this.BrojOsoba,
            this.KlijentID,
            this.Status,
            this.Otkazano,
            this.Prihvaceno,
            this.NaCekanju,
            this.Izvrseno});
            this.dgvRezervacije.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRezervacije.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRezervacije.EnableHeadersVisualStyles = false;
            this.dgvRezervacije.GridColor = System.Drawing.Color.White;
            this.dgvRezervacije.Location = new System.Drawing.Point(36, 247);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.ReadOnly = true;
            this.dgvRezervacije.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRezervacije.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRezervacije.RowHeadersVisible = false;
            this.dgvRezervacije.RowHeadersWidth = 43;
            this.dgvRezervacije.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRezervacije.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRezervacije.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacije.ShowCellErrors = false;
            this.dgvRezervacije.Size = new System.Drawing.Size(837, 359);
            this.dgvRezervacije.TabIndex = 1;
            this.dgvRezervacije.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvRezervacije_MouseDoubleClick);
            // 
            // RezervacijaID
            // 
            this.RezervacijaID.DataPropertyName = "RezervacijaID";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.RezervacijaID.DefaultCellStyle = dataGridViewCellStyle2;
            this.RezervacijaID.HeaderText = "RezervacijaID";
            this.RezervacijaID.MinimumWidth = 6;
            this.RezervacijaID.Name = "RezervacijaID";
            this.RezervacijaID.ReadOnly = true;
            this.RezervacijaID.Visible = false;
            // 
            // DatumRezervacije
            // 
            this.DatumRezervacije.DataPropertyName = "DatumRezervacije";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatumRezervacije.DefaultCellStyle = dataGridViewCellStyle3;
            this.DatumRezervacije.HeaderText = "Datum rezervacije";
            this.DatumRezervacije.MinimumWidth = 6;
            this.DatumRezervacije.Name = "DatumRezervacije";
            this.DatumRezervacije.ReadOnly = true;
            // 
            // VrijemeRezervacije
            // 
            this.VrijemeRezervacije.DataPropertyName = "VrijemeRezervacije";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VrijemeRezervacije.DefaultCellStyle = dataGridViewCellStyle4;
            this.VrijemeRezervacije.HeaderText = "Vrijeme rezervacije";
            this.VrijemeRezervacije.MinimumWidth = 6;
            this.VrijemeRezervacije.Name = "VrijemeRezervacije";
            this.VrijemeRezervacije.ReadOnly = true;
            // 
            // BrojOsoba
            // 
            this.BrojOsoba.DataPropertyName = "BrojOsoba";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrojOsoba.DefaultCellStyle = dataGridViewCellStyle5;
            this.BrojOsoba.HeaderText = "Broj osoba";
            this.BrojOsoba.MinimumWidth = 6;
            this.BrojOsoba.Name = "BrojOsoba";
            this.BrojOsoba.ReadOnly = true;
            // 
            // KlijentID
            // 
            this.KlijentID.DataPropertyName = "KlijentID";
            this.KlijentID.HeaderText = "KlijentID";
            this.KlijentID.Name = "KlijentID";
            this.KlijentID.ReadOnly = true;
            this.KlijentID.Visible = false;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.DefaultCellStyle = dataGridViewCellStyle6;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Otkazano
            // 
            this.Otkazano.DataPropertyName = "Otkazano";
            this.Otkazano.HeaderText = "Otkazano";
            this.Otkazano.Name = "Otkazano";
            this.Otkazano.ReadOnly = true;
            this.Otkazano.Visible = false;
            // 
            // Prihvaceno
            // 
            this.Prihvaceno.DataPropertyName = "Prihvaceno";
            this.Prihvaceno.HeaderText = "Prihvaceno";
            this.Prihvaceno.Name = "Prihvaceno";
            this.Prihvaceno.ReadOnly = true;
            this.Prihvaceno.Visible = false;
            // 
            // NaCekanju
            // 
            this.NaCekanju.DataPropertyName = "NaCekanju";
            this.NaCekanju.HeaderText = "NaCekanju";
            this.NaCekanju.Name = "NaCekanju";
            this.NaCekanju.ReadOnly = true;
            this.NaCekanju.Visible = false;
            // 
            // Izvrseno
            // 
            this.Izvrseno.DataPropertyName = "Izvrseno";
            this.Izvrseno.HeaderText = "Izvrseno";
            this.Izvrseno.Name = "Izvrseno";
            this.Izvrseno.ReadOnly = true;
            this.Izvrseno.Visible = false;
            // 
            // Nabavke
            // 
            this.Nabavke.AutoSize = true;
            this.Nabavke.BackColor = System.Drawing.Color.Transparent;
            this.Nabavke.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nabavke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nabavke.Location = new System.Drawing.Point(69, 39);
            this.Nabavke.Name = "Nabavke";
            this.Nabavke.Size = new System.Drawing.Size(133, 25);
            this.Nabavke.TabIndex = 2;
            this.Nabavke.Text = "Rezervacije";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(36, 73);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // frmRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 617);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Nabavke);
            this.Controls.Add(this.dgvRezervacije);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRezervacija";
            this.Text = "FrmRezervacija";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.Label Nabavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemeRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojOsoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otkazano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prihvaceno;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaCekanju;
        private System.Windows.Forms.DataGridViewTextBoxColumn Izvrseno;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}