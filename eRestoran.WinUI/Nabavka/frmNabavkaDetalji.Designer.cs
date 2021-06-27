
namespace eRestoran.WinUI.Nabavka
{
    partial class frmNabavkaDetalji
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNabavkaDetalji));
            this.dgvNamirnice = new System.Windows.Forms.DataGridView();
            this.dgvNabavkePice = new System.Windows.Forms.DataGridView();
            this.PiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NabakvaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCijenaPice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NabavkaPiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nabavke = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NamirnicaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NabavkaNamirnicaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNamirnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNabavkePice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNamirnice
            // 
            this.dgvNamirnice.AllowUserToAddRows = false;
            this.dgvNamirnice.AllowUserToDeleteRows = false;
            this.dgvNamirnice.AllowUserToResizeRows = false;
            this.dgvNamirnice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNamirnice.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNamirnice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNamirnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNamirnice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamirnicaID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.UkupnaCijena,
            this.NabavkaNamirnicaID});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNamirnice.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNamirnice.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvNamirnice.EnableHeadersVisualStyles = false;
            this.dgvNamirnice.GridColor = System.Drawing.Color.White;
            this.dgvNamirnice.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvNamirnice.Location = new System.Drawing.Point(42, 65);
            this.dgvNamirnice.Name = "dgvNamirnice";
            this.dgvNamirnice.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNamirnice.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNamirnice.RowHeadersVisible = false;
            this.dgvNamirnice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.dgvNamirnice.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNamirnice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNamirnice.Size = new System.Drawing.Size(671, 185);
            this.dgvNamirnice.TabIndex = 1;
            // 
            // dgvNabavkePice
            // 
            this.dgvNabavkePice.AllowUserToAddRows = false;
            this.dgvNabavkePice.AllowUserToDeleteRows = false;
            this.dgvNabavkePice.AllowUserToResizeRows = false;
            this.dgvNabavkePice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNabavkePice.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNabavkePice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNabavkePice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNabavkePice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PiceId,
            this.Naziv,
            this.Kolicina,
            this.NabakvaId,
            this.UkupnaCijenaPice,
            this.NabavkaPiceId});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNabavkePice.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvNabavkePice.EnableHeadersVisualStyles = false;
            this.dgvNabavkePice.Location = new System.Drawing.Point(42, 320);
            this.dgvNabavkePice.Name = "dgvNabavkePice";
            this.dgvNabavkePice.ReadOnly = true;
            this.dgvNabavkePice.RowHeadersVisible = false;
            this.dgvNabavkePice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNabavkePice.Size = new System.Drawing.Size(671, 197);
            this.dgvNabavkePice.TabIndex = 0;
            // 
            // PiceId
            // 
            this.PiceId.DataPropertyName = "PiceID";
            this.PiceId.HeaderText = "PiceId";
            this.PiceId.Name = "PiceId";
            this.PiceId.ReadOnly = true;
            this.PiceId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Pice";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Red;
            this.Naziv.DefaultCellStyle = dataGridViewCellStyle8;
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Red;
            this.Kolicina.DefaultCellStyle = dataGridViewCellStyle9;
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // NabakvaId
            // 
            this.NabakvaId.DataPropertyName = "NabavkaID";
            this.NabakvaId.HeaderText = "NabakvaId";
            this.NabakvaId.Name = "NabakvaId";
            this.NabakvaId.ReadOnly = true;
            this.NabakvaId.Visible = false;
            // 
            // UkupnaCijenaPice
            // 
            this.UkupnaCijenaPice.DataPropertyName = "UkupnaCijenaPice";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Red;
            this.UkupnaCijenaPice.DefaultCellStyle = dataGridViewCellStyle10;
            this.UkupnaCijenaPice.HeaderText = "Ukupna cijena";
            this.UkupnaCijenaPice.Name = "UkupnaCijenaPice";
            this.UkupnaCijenaPice.ReadOnly = true;
            // 
            // NabavkaPiceId
            // 
            this.NabavkaPiceId.DataPropertyName = "NabavkaPiceID";
            this.NabavkaPiceId.HeaderText = "NabavkaPiceId";
            this.NabavkaPiceId.Name = "NabavkaPiceId";
            this.NabavkaPiceId.ReadOnly = true;
            this.NabavkaPiceId.Visible = false;
            // 
            // Nabavke
            // 
            this.Nabavke.AutoSize = true;
            this.Nabavke.BackColor = System.Drawing.Color.Transparent;
            this.Nabavke.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nabavke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nabavke.Location = new System.Drawing.Point(37, 24);
            this.Nabavke.Name = "Nabavke";
            this.Nabavke.Size = new System.Drawing.Size(118, 25);
            this.Nabavke.TabIndex = 2;
            this.Nabavke.Text = "Namirnice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(37, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Piće";
            // 
            // NamirnicaID
            // 
            this.NamirnicaID.DataPropertyName = "NamirnicaID";
            this.NamirnicaID.HeaderText = "NamirnicaID";
            this.NamirnicaID.Name = "NamirnicaID";
            this.NamirnicaID.ReadOnly = true;
            this.NamirnicaID.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Namirnica";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Kolicina";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "Količina";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NabavkaID";
            this.dataGridViewTextBoxColumn3.HeaderText = "NabakvaId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // UkupnaCijena
            // 
            this.UkupnaCijena.DataPropertyName = "UkupnaCijena";
            this.UkupnaCijena.HeaderText = "Ukupna cijena";
            this.UkupnaCijena.Name = "UkupnaCijena";
            this.UkupnaCijena.ReadOnly = true;
            // 
            // NabavkaNamirnicaID
            // 
            this.NabavkaNamirnicaID.DataPropertyName = "NabavkaNamirnicaID";
            this.NabavkaNamirnicaID.HeaderText = "NabavkaNamirnicaID";
            this.NabavkaNamirnicaID.Name = "NabavkaNamirnicaID";
            this.NabavkaNamirnicaID.ReadOnly = true;
            this.NabavkaNamirnicaID.Visible = false;
            // 
            // frmNabavkaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nabavke);
            this.Controls.Add(this.dgvNabavkePice);
            this.Controls.Add(this.dgvNamirnice);
            this.DoubleBuffered = true;
            this.Name = "frmNabavkaDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNabavkaDetalji";
            this.Load += new System.EventHandler(this.frmNabavkaDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNamirnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNabavkePice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNabavkePice;
        private System.Windows.Forms.Label Nabavke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNamirnice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn NabakvaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCijenaPice;
        private System.Windows.Forms.DataGridViewTextBoxColumn NabavkaPiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamirnicaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn NabavkaNamirnicaID;
    }
}