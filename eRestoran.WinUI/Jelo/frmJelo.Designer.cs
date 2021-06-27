
namespace eRestoran.WinUI.Jelo
{
    partial class frmJelo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJelo));
            this.Nabavke = new System.Windows.Forms.Label();
            this.dgvJelo = new System.Windows.Forms.DataGridView();
            this.JeloID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaJela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaJelaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNoviZaposlenik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJelo)).BeginInit();
            this.SuspendLayout();
            // 
            // Nabavke
            // 
            this.Nabavke.AutoSize = true;
            this.Nabavke.BackColor = System.Drawing.Color.Transparent;
            this.Nabavke.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nabavke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nabavke.Location = new System.Drawing.Point(42, 60);
            this.Nabavke.Name = "Nabavke";
            this.Nabavke.Size = new System.Drawing.Size(54, 25);
            this.Nabavke.TabIndex = 6;
            this.Nabavke.Text = "Jela";
            // 
            // dgvJelo
            // 
            this.dgvJelo.AllowUserToAddRows = false;
            this.dgvJelo.AllowUserToDeleteRows = false;
            this.dgvJelo.AllowUserToResizeColumns = false;
            this.dgvJelo.AllowUserToResizeRows = false;
            this.dgvJelo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJelo.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJelo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJelo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JeloID,
            this.Naziv,
            this.VrstaJela,
            this.Cijena,
            this.VrstaJelaID});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJelo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvJelo.EnableHeadersVisualStyles = false;
            this.dgvJelo.GridColor = System.Drawing.Color.White;
            this.dgvJelo.Location = new System.Drawing.Point(47, 154);
            this.dgvJelo.Name = "dgvJelo";
            this.dgvJelo.ReadOnly = true;
            this.dgvJelo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvJelo.RowHeadersVisible = false;
            this.dgvJelo.RowHeadersWidth = 43;
            this.dgvJelo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvJelo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJelo.Size = new System.Drawing.Size(756, 350);
            this.dgvJelo.TabIndex = 5;
            // 
            // JeloID
            // 
            this.JeloID.DataPropertyName = "JeloID";
            this.JeloID.HeaderText = "JeloID";
            this.JeloID.Name = "JeloID";
            this.JeloID.ReadOnly = true;
            this.JeloID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.Naziv.DefaultCellStyle = dataGridViewCellStyle2;
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // VrstaJela
            // 
            this.VrstaJela.DataPropertyName = "VrstaJela";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            this.VrstaJela.DefaultCellStyle = dataGridViewCellStyle3;
            this.VrstaJela.HeaderText = "Vrsta jela";
            this.VrstaJela.Name = "VrstaJela";
            this.VrstaJela.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            this.Cijena.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // VrstaJelaID
            // 
            this.VrstaJelaID.DataPropertyName = "VrstaJelaID";
            this.VrstaJelaID.HeaderText = "VrstaJelaID";
            this.VrstaJelaID.Name = "VrstaJelaID";
            this.VrstaJelaID.ReadOnly = true;
            this.VrstaJelaID.Visible = false;
            // 
            // btnNoviZaposlenik
            // 
            this.btnNoviZaposlenik.BackColor = System.Drawing.Color.Red;
            this.btnNoviZaposlenik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNoviZaposlenik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNoviZaposlenik.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviZaposlenik.ForeColor = System.Drawing.Color.White;
            this.btnNoviZaposlenik.Location = new System.Drawing.Point(586, 61);
            this.btnNoviZaposlenik.Name = "btnNoviZaposlenik";
            this.btnNoviZaposlenik.Size = new System.Drawing.Size(217, 30);
            this.btnNoviZaposlenik.TabIndex = 8;
            this.btnNoviZaposlenik.Text = "Novo jelo";
            this.btnNoviZaposlenik.UseVisualStyleBackColor = false;
            this.btnNoviZaposlenik.Click += new System.EventHandler(this.btnNovoJelo_Click);
            // 
            // frmJelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 532);
            this.Controls.Add(this.btnNoviZaposlenik);
            this.Controls.Add(this.Nabavke);
            this.Controls.Add(this.dgvJelo);
            this.DoubleBuffered = true;
            this.Name = "frmJelo";
            this.Text = "frmJelo";
            this.Load += new System.EventHandler(this.frmJelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nabavke;
        private System.Windows.Forms.DataGridView dgvJelo;
        private System.Windows.Forms.Button btnNoviZaposlenik;
        private System.Windows.Forms.DataGridViewTextBoxColumn JeloID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaJela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaJelaID;
    }
}