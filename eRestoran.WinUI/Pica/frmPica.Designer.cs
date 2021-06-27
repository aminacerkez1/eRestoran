
namespace eRestoran.WinUI.Pica
{
    partial class frmPica
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPica));
            this.btnNovoPice = new System.Windows.Forms.Button();
            this.Nabavke = new System.Windows.Forms.Label();
            this.dgvPice = new System.Windows.Forms.DataGridView();
            this.PiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovoPice
            // 
            this.btnNovoPice.AccessibleName = "btnNovoPice";
            this.btnNovoPice.BackColor = System.Drawing.Color.Red;
            this.btnNovoPice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovoPice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoPice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoPice.ForeColor = System.Drawing.Color.White;
            this.btnNovoPice.Location = new System.Drawing.Point(586, 61);
            this.btnNovoPice.Name = "btnNovoPice";
            this.btnNovoPice.Size = new System.Drawing.Size(217, 30);
            this.btnNovoPice.TabIndex = 11;
            this.btnNovoPice.Text = "Novo piće";
            this.btnNovoPice.UseVisualStyleBackColor = false;
            this.btnNovoPice.Click += new System.EventHandler(this.btnNovoPice_Click);
            // 
            // Nabavke
            // 
            this.Nabavke.AutoSize = true;
            this.Nabavke.BackColor = System.Drawing.Color.Transparent;
            this.Nabavke.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nabavke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nabavke.Location = new System.Drawing.Point(42, 60);
            this.Nabavke.Name = "Nabavke";
            this.Nabavke.Size = new System.Drawing.Size(56, 25);
            this.Nabavke.TabIndex = 10;
            this.Nabavke.Text = "Pića";
            // 
            // dgvPice
            // 
            this.dgvPice.AllowUserToAddRows = false;
            this.dgvPice.AllowUserToDeleteRows = false;
            this.dgvPice.AllowUserToResizeColumns = false;
            this.dgvPice.AllowUserToResizeRows = false;
            this.dgvPice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPice.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PiceId,
            this.Naziv,
            this.Cijena});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPice.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPice.EnableHeadersVisualStyles = false;
            this.dgvPice.GridColor = System.Drawing.Color.White;
            this.dgvPice.Location = new System.Drawing.Point(47, 154);
            this.dgvPice.Name = "dgvPice";
            this.dgvPice.ReadOnly = true;
            this.dgvPice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPice.RowHeadersVisible = false;
            this.dgvPice.RowHeadersWidth = 43;
            this.dgvPice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPice.Size = new System.Drawing.Size(756, 350);
            this.dgvPice.TabIndex = 9;
            // 
            // PiceId
            // 
            this.PiceId.DataPropertyName = "PiceID";
            this.PiceId.HeaderText = "PiceID";
            this.PiceId.Name = "PiceId";
            this.PiceId.ReadOnly = true;
            this.PiceId.Visible = false;
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
            // frmPica
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 532);
            this.Controls.Add(this.btnNovoPice);
            this.Controls.Add(this.Nabavke);
            this.Controls.Add(this.dgvPice);
            this.DoubleBuffered = true;
            this.Name = "frmPica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPica";
            this.Load += new System.EventHandler(this.frmPica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovoPice;
        private System.Windows.Forms.Label Nabavke;
        private System.Windows.Forms.DataGridView dgvPice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}