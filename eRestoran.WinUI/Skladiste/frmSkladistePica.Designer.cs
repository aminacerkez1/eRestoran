
namespace eRestoran.WinUI.Skladiste
{
    partial class frmSkladistePica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSkladistePica));
            this.dgvSkladistePice = new System.Windows.Forms.DataGridView();
            this.PiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StanjeNaSkladistu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nabavke = new System.Windows.Forms.Label();
            this.btnSkladistePica = new System.Windows.Forms.Button();
            this.btnSkladisteNamirnica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladistePice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSkladistePice
            // 
            this.dgvSkladistePice.AllowUserToAddRows = false;
            this.dgvSkladistePice.AllowUserToDeleteRows = false;
            this.dgvSkladistePice.AllowUserToResizeColumns = false;
            this.dgvSkladistePice.AllowUserToResizeRows = false;
            this.dgvSkladistePice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSkladistePice.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSkladistePice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSkladistePice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladistePice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PiceID,
            this.Naziv,
            this.Cijena,
            this.StanjeNaSkladistu});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSkladistePice.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSkladistePice.EnableHeadersVisualStyles = false;
            this.dgvSkladistePice.GridColor = System.Drawing.Color.White;
            this.dgvSkladistePice.Location = new System.Drawing.Point(71, 197);
            this.dgvSkladistePice.Name = "dgvSkladistePice";
            this.dgvSkladistePice.ReadOnly = true;
            this.dgvSkladistePice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSkladistePice.RowHeadersVisible = false;
            this.dgvSkladistePice.RowHeadersWidth = 43;
            this.dgvSkladistePice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSkladistePice.Size = new System.Drawing.Size(756, 350);
            this.dgvSkladistePice.TabIndex = 1;
            this.dgvSkladistePice.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSkladistePice_CellMouseDoubleClick);
            // 
            // PiceID
            // 
            this.PiceID.DataPropertyName = "PiceID";
            this.PiceID.HeaderText = "PiceID";
            this.PiceID.Name = "PiceID";
            this.PiceID.ReadOnly = true;
            this.PiceID.Visible = false;
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
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            this.Cijena.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // StanjeNaSkladistu
            // 
            this.StanjeNaSkladistu.DataPropertyName = "StanjeNaSkladistu";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            this.StanjeNaSkladistu.DefaultCellStyle = dataGridViewCellStyle4;
            this.StanjeNaSkladistu.HeaderText = "Stanje na skladištu";
            this.StanjeNaSkladistu.Name = "StanjeNaSkladistu";
            this.StanjeNaSkladistu.ReadOnly = true;
            // 
            // Nabavke
            // 
            this.Nabavke.AutoSize = true;
            this.Nabavke.BackColor = System.Drawing.Color.Transparent;
            this.Nabavke.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nabavke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nabavke.Location = new System.Drawing.Point(66, 43);
            this.Nabavke.Name = "Nabavke";
            this.Nabavke.Size = new System.Drawing.Size(108, 25);
            this.Nabavke.TabIndex = 6;
            this.Nabavke.Text = "Skladište";
            // 
            // btnSkladistePica
            // 
            this.btnSkladistePica.AutoSize = true;
            this.btnSkladistePica.BackColor = System.Drawing.Color.DarkRed;
            this.btnSkladistePica.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSkladistePica.FlatAppearance.BorderSize = 2;
            this.btnSkladistePica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSkladistePica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkladistePica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkladistePica.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSkladistePica.Location = new System.Drawing.Point(71, 87);
            this.btnSkladistePica.Name = "btnSkladistePica";
            this.btnSkladistePica.Size = new System.Drawing.Size(285, 64);
            this.btnSkladistePica.TabIndex = 5;
            this.btnSkladistePica.Text = "Pića";
            this.btnSkladistePica.UseVisualStyleBackColor = false;
            this.btnSkladistePica.Click += new System.EventHandler(this.btnSkladistePica_Click);
            // 
            // btnSkladisteNamirnica
            // 
            this.btnSkladisteNamirnica.BackColor = System.Drawing.Color.DarkRed;
            this.btnSkladisteNamirnica.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSkladisteNamirnica.FlatAppearance.BorderSize = 2;
            this.btnSkladisteNamirnica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSkladisteNamirnica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkladisteNamirnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkladisteNamirnica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSkladisteNamirnica.Location = new System.Drawing.Point(362, 87);
            this.btnSkladisteNamirnica.Name = "btnSkladisteNamirnica";
            this.btnSkladisteNamirnica.Size = new System.Drawing.Size(285, 64);
            this.btnSkladisteNamirnica.TabIndex = 4;
            this.btnSkladisteNamirnica.Text = "Namirnice";
            this.btnSkladisteNamirnica.UseVisualStyleBackColor = false;
            this.btnSkladisteNamirnica.Click += new System.EventHandler(this.btnSkladisteNamirnica_Click);
            // 
            // frmSkladistePica
            // 
            this.AccessibleName = "frmSkladistePica";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 577);
            this.Controls.Add(this.Nabavke);
            this.Controls.Add(this.btnSkladistePica);
            this.Controls.Add(this.btnSkladisteNamirnica);
            this.Controls.Add(this.dgvSkladistePice);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSkladistePica";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "frmSkladistePica";
            this.Load += new System.EventHandler(this.frmSkladistePica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladistePice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSkladistePice;
        private System.Windows.Forms.Label Nabavke;
        private System.Windows.Forms.Button btnSkladistePica;
        private System.Windows.Forms.Button btnSkladisteNamirnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn StanjeNaSkladistu;
    }
}