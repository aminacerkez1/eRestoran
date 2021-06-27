
namespace eRestoran.WinUI.Nabavka
{
    partial class frmNabavka
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNabavka));
            this.dgvNabavke = new System.Windows.Forms.DataGridView();
            this.NabavkaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumNabavke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupanIznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zaposlenik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nabavke = new System.Windows.Forms.Label();
            this.btnNovaNabavka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNabavke)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNabavke
            // 
            this.dgvNabavke.AllowUserToAddRows = false;
            this.dgvNabavke.AllowUserToDeleteRows = false;
            this.dgvNabavke.AllowUserToResizeColumns = false;
            this.dgvNabavke.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNabavke.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNabavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNabavke.BackgroundColor = System.Drawing.Color.White;
            this.dgvNabavke.CausesValidation = false;
            this.dgvNabavke.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNabavke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNabavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNabavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NabavkaID,
            this.DatumNabavke,
            this.UkupanIznos,
            this.Zaposlenik});
            this.dgvNabavke.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNabavke.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNabavke.EnableHeadersVisualStyles = false;
            this.dgvNabavke.GridColor = System.Drawing.Color.White;
            this.dgvNabavke.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvNabavke.Location = new System.Drawing.Point(40, 191);
            this.dgvNabavke.MultiSelect = false;
            this.dgvNabavke.Name = "dgvNabavke";
            this.dgvNabavke.ReadOnly = true;
            this.dgvNabavke.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNabavke.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNabavke.RowHeadersVisible = false;
            this.dgvNabavke.RowHeadersWidth = 34;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNabavke.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNabavke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNabavke.Size = new System.Drawing.Size(833, 352);
            this.dgvNabavke.TabIndex = 0;
            this.dgvNabavke.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvNabavke_MouseDoubleClick);
            // 
            // NabavkaID
            // 
            this.NabavkaID.DataPropertyName = "NabavkaID";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.NabavkaID.DefaultCellStyle = dataGridViewCellStyle3;
            this.NabavkaID.HeaderText = "NabavkaID";
            this.NabavkaID.Name = "NabavkaID";
            this.NabavkaID.ReadOnly = true;
            this.NabavkaID.Visible = false;
            // 
            // DatumNabavke
            // 
            this.DatumNabavke.DataPropertyName = "DatumNabavke";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatumNabavke.DefaultCellStyle = dataGridViewCellStyle4;
            this.DatumNabavke.HeaderText = "Datum nabavke";
            this.DatumNabavke.MinimumWidth = 6;
            this.DatumNabavke.Name = "DatumNabavke";
            this.DatumNabavke.ReadOnly = true;
            // 
            // UkupanIznos
            // 
            this.UkupanIznos.DataPropertyName = "UkupanIznos";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UkupanIznos.DefaultCellStyle = dataGridViewCellStyle5;
            this.UkupanIznos.HeaderText = "Ukupan iznos";
            this.UkupanIznos.MinimumWidth = 6;
            this.UkupanIznos.Name = "UkupanIznos";
            this.UkupanIznos.ReadOnly = true;
            // 
            // Zaposlenik
            // 
            this.Zaposlenik.DataPropertyName = "Zaposlenik";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zaposlenik.DefaultCellStyle = dataGridViewCellStyle6;
            this.Zaposlenik.HeaderText = "Zaposlenik";
            this.Zaposlenik.MinimumWidth = 6;
            this.Zaposlenik.Name = "Zaposlenik";
            this.Zaposlenik.ReadOnly = true;
            // 
            // Nabavke
            // 
            this.Nabavke.AutoSize = true;
            this.Nabavke.BackColor = System.Drawing.Color.Transparent;
            this.Nabavke.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nabavke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nabavke.Location = new System.Drawing.Point(29, 79);
            this.Nabavke.Name = "Nabavke";
            this.Nabavke.Size = new System.Drawing.Size(104, 25);
            this.Nabavke.TabIndex = 1;
            this.Nabavke.Text = "Nabavke";
            // 
            // btnNovaNabavka
            // 
            this.btnNovaNabavka.BackColor = System.Drawing.Color.Red;
            this.btnNovaNabavka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovaNabavka.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovaNabavka.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaNabavka.ForeColor = System.Drawing.Color.White;
            this.btnNovaNabavka.Location = new System.Drawing.Point(661, 125);
            this.btnNovaNabavka.Name = "btnNovaNabavka";
            this.btnNovaNabavka.Size = new System.Drawing.Size(217, 30);
            this.btnNovaNabavka.TabIndex = 9;
            this.btnNovaNabavka.Text = "Nova nabavka";
            this.btnNovaNabavka.UseVisualStyleBackColor = false;
            this.btnNovaNabavka.Click += new System.EventHandler(this.btnNovaNabavka_Click);
            // 
            // frmNabavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 571);
            this.Controls.Add(this.btnNovaNabavka);
            this.Controls.Add(this.Nabavke);
            this.Controls.Add(this.dgvNabavke);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNabavka";
            this.Text = "frmNabavka";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmNabavka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNabavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNabavke;
        private System.Windows.Forms.Label Nabavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn NabavkaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumNabavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupanIznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zaposlenik;
        private System.Windows.Forms.Button btnNovaNabavka;
    }
}