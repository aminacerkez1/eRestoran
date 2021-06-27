
namespace eRestoran.WinUI.Narudzba
{
    partial class frmNarudzba
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNarudzba));
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.Narudzbe = new System.Windows.Forms.Label();
            this.dgvNarudzbe = new System.Windows.Forms.DataGridView();
            this.NarudzbaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KlijentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otkazano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prihvaceno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaCekanju = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izvrseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(33, 74);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 6;
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            // 
            // Narudzbe
            // 
            this.Narudzbe.AutoSize = true;
            this.Narudzbe.BackColor = System.Drawing.Color.Transparent;
            this.Narudzbe.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Narudzbe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Narudzbe.Location = new System.Drawing.Point(69, 39);
            this.Narudzbe.Name = "Narudzbe";
            this.Narudzbe.Size = new System.Drawing.Size(112, 25);
            this.Narudzbe.TabIndex = 5;
            this.Narudzbe.Text = "Narudžbe";
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.AllowUserToAddRows = false;
            this.dgvNarudzbe.AllowUserToDeleteRows = false;
            this.dgvNarudzbe.AllowUserToResizeColumns = false;
            this.dgvNarudzbe.AllowUserToResizeRows = false;
            this.dgvNarudzbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNarudzbe.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvNarudzbe.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNarudzbe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NarudzbaID,
            this.DatumNarudzbe,
            this.VrijemeNarudzbe,
            this.CijenaNarudzbe,
            this.KlijentID,
            this.Status,
            this.Otkazano,
            this.Prihvaceno,
            this.NaCekanju,
            this.Izvrseno});
            this.dgvNarudzbe.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNarudzbe.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNarudzbe.EnableHeadersVisualStyles = false;
            this.dgvNarudzbe.GridColor = System.Drawing.Color.White;
            this.dgvNarudzbe.Location = new System.Drawing.Point(33, 248);
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.ReadOnly = true;
            this.dgvNarudzbe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNarudzbe.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNarudzbe.RowHeadersVisible = false;
            this.dgvNarudzbe.RowHeadersWidth = 43;
            this.dgvNarudzbe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNarudzbe.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNarudzbe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvNarudzbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzbe.ShowCellErrors = false;
            this.dgvNarudzbe.Size = new System.Drawing.Size(837, 359);
            this.dgvNarudzbe.TabIndex = 4;
            this.dgvNarudzbe.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvNarudzbe_MouseDoubleClick);
            // 
            // NarudzbaID
            // 
            this.NarudzbaID.DataPropertyName = "NarudzbaID";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.NarudzbaID.DefaultCellStyle = dataGridViewCellStyle2;
            this.NarudzbaID.HeaderText = "NarudzbaID";
            this.NarudzbaID.MinimumWidth = 6;
            this.NarudzbaID.Name = "NarudzbaID";
            this.NarudzbaID.ReadOnly = true;
            this.NarudzbaID.Visible = false;
            // 
            // DatumNarudzbe
            // 
            this.DatumNarudzbe.DataPropertyName = "DatumNarudzbe";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatumNarudzbe.DefaultCellStyle = dataGridViewCellStyle3;
            this.DatumNarudzbe.HeaderText = "Datum narudžbe";
            this.DatumNarudzbe.MinimumWidth = 6;
            this.DatumNarudzbe.Name = "DatumNarudzbe";
            this.DatumNarudzbe.ReadOnly = true;
            // 
            // VrijemeNarudzbe
            // 
            this.VrijemeNarudzbe.DataPropertyName = "VrijemeNarudzbe";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VrijemeNarudzbe.DefaultCellStyle = dataGridViewCellStyle4;
            this.VrijemeNarudzbe.HeaderText = "Vrijeme narudžbe";
            this.VrijemeNarudzbe.MinimumWidth = 6;
            this.VrijemeNarudzbe.Name = "VrijemeNarudzbe";
            this.VrijemeNarudzbe.ReadOnly = true;
            // 
            // CijenaNarudzbe
            // 
            this.CijenaNarudzbe.DataPropertyName = "CijenaNarudzbe";
            this.CijenaNarudzbe.HeaderText = "Cijena narudžbe";
            this.CijenaNarudzbe.Name = "CijenaNarudzbe";
            this.CijenaNarudzbe.ReadOnly = true;
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.DefaultCellStyle = dataGridViewCellStyle5;
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
            // frmNarudzba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 612);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.Narudzbe);
            this.Controls.Add(this.dgvNarudzbe);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNarudzba";
            this.Text = "frmNarudzba";
            this.Load += new System.EventHandler(this.frmNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Label Narudzbe;
        private System.Windows.Forms.DataGridView dgvNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NarudzbaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemeNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otkazano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prihvaceno;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaCekanju;
        private System.Windows.Forms.DataGridViewTextBoxColumn Izvrseno;
    }
}