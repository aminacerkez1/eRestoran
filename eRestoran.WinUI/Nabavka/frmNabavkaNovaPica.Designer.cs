
namespace eRestoran.WinUI.Nabavka
{
    partial class frmNabavkaNovaPica
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
            this.numericUpDownPice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.btnSnimiPice = new System.Windows.Forms.Button();
            this.Nabavke = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPice)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownPice
            // 
            this.numericUpDownPice.Location = new System.Drawing.Point(46, 240);
            this.numericUpDownPice.Name = "numericUpDownPice";
            this.numericUpDownPice.Size = new System.Drawing.Size(235, 20);
            this.numericUpDownPice.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 14);
            this.label3.TabIndex = 68;
            this.label3.Text = "Stanje na skladištu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 67;
            this.label2.Text = "Cijena";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(46, 183);
            this.txtCijena.Margin = new System.Windows.Forms.Padding(4);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(235, 20);
            this.txtCijena.TabIndex = 66;
            // 
            // btnSnimiPice
            // 
            this.btnSnimiPice.BackColor = System.Drawing.Color.Red;
            this.btnSnimiPice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSnimiPice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSnimiPice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimiPice.ForeColor = System.Drawing.Color.White;
            this.btnSnimiPice.Location = new System.Drawing.Point(46, 292);
            this.btnSnimiPice.Name = "btnSnimiPice";
            this.btnSnimiPice.Size = new System.Drawing.Size(235, 30);
            this.btnSnimiPice.TabIndex = 65;
            this.btnSnimiPice.Text = "Snimi";
            this.btnSnimiPice.UseVisualStyleBackColor = false;
            this.btnSnimiPice.Click += new System.EventHandler(this.btnSnimiPice_Click);
            // 
            // Nabavke
            // 
            this.Nabavke.AutoSize = true;
            this.Nabavke.BackColor = System.Drawing.Color.Transparent;
            this.Nabavke.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nabavke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nabavke.Location = new System.Drawing.Point(41, 32);
            this.Nabavke.Name = "Nabavke";
            this.Nabavke.Size = new System.Drawing.Size(123, 25);
            this.Nabavke.TabIndex = 64;
            this.Nabavke.Text = "Dodaj piće";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 63;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(46, 126);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(235, 22);
            this.txtNaziv.TabIndex = 62;
            // 
            // frmNabavkaNovaPica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 381);
            this.Controls.Add(this.numericUpDownPice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.btnSnimiPice);
            this.Controls.Add(this.Nabavke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmNabavkaNovaPica";
            this.Text = "frmNabavkaNovaPica";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownPice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Button btnSnimiPice;
        private System.Windows.Forms.Label Nabavke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
    }
}