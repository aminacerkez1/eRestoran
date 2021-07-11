
namespace eRestoran.WinUI.Skladiste
{
    partial class frmSkladisteNamirnicaUredi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSkladisteNamirnicaUredi));
            this.btnSnimiNamirnica = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStanje = new System.Windows.Forms.TextBox();
            this.Nabavke = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtNamirnica = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSnimiNamirnica
            // 
            this.btnSnimiNamirnica.BackColor = System.Drawing.Color.Red;
            this.btnSnimiNamirnica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSnimiNamirnica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSnimiNamirnica.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimiNamirnica.ForeColor = System.Drawing.Color.White;
            this.btnSnimiNamirnica.Location = new System.Drawing.Point(61, 340);
            this.btnSnimiNamirnica.Name = "btnSnimiNamirnica";
            this.btnSnimiNamirnica.Size = new System.Drawing.Size(235, 30);
            this.btnSnimiNamirnica.TabIndex = 66;
            this.btnSnimiNamirnica.Text = "Snimi";
            this.btnSnimiNamirnica.UseVisualStyleBackColor = false;
            this.btnSnimiNamirnica.Click += new System.EventHandler(this.btnSnimiNamirnica_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 14);
            this.label4.TabIndex = 65;
            this.label4.Text = "Stanje na skladištu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 14);
            this.label3.TabIndex = 64;
            // 
            // txtStanje
            // 
            this.txtStanje.AccessibleName = "txtStanje";
            this.txtStanje.Location = new System.Drawing.Point(61, 288);
            this.txtStanje.Margin = new System.Windows.Forms.Padding(4);
            this.txtStanje.Name = "txtStanje";
            this.txtStanje.Size = new System.Drawing.Size(235, 20);
            this.txtStanje.TabIndex = 63;
            this.txtStanje.Validating += new System.ComponentModel.CancelEventHandler(this.txtStanje_Validating);
            // 
            // Nabavke
            // 
            this.Nabavke.AutoSize = true;
            this.Nabavke.BackColor = System.Drawing.Color.Transparent;
            this.Nabavke.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nabavke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nabavke.Location = new System.Drawing.Point(56, 80);
            this.Nabavke.Name = "Nabavke";
            this.Nabavke.Size = new System.Drawing.Size(168, 25);
            this.Nabavke.TabIndex = 62;
            this.Nabavke.Text = "Uredi skladište";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 14);
            this.label2.TabIndex = 61;
            this.label2.Text = "Cijena po komadu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 60;
            this.label1.Text = "Namirnica";
            // 
            // txtCijena
            // 
            this.txtCijena.AccessibleName = "txtCijena";
            this.txtCijena.Location = new System.Drawing.Point(61, 231);
            this.txtCijena.Margin = new System.Windows.Forms.Padding(4);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(235, 20);
            this.txtCijena.TabIndex = 59;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // txtNamirnica
            // 
            this.txtNamirnica.AccessibleName = "txtNamirnica";
            this.txtNamirnica.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamirnica.Location = new System.Drawing.Point(61, 174);
            this.txtNamirnica.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamirnica.Name = "txtNamirnica";
            this.txtNamirnica.Size = new System.Drawing.Size(235, 22);
            this.txtNamirnica.TabIndex = 58;
            this.txtNamirnica.Validating += new System.ComponentModel.CancelEventHandler(this.txtNamirnica_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmSkladisteNamirnicaUredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(353, 450);
            this.Controls.Add(this.btnSnimiNamirnica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStanje);
            this.Controls.Add(this.Nabavke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtNamirnica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSkladisteNamirnicaUredi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSkladisteNamirnicaUredi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSnimiNamirnica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStanje;
        private System.Windows.Forms.Label Nabavke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtNamirnica;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}