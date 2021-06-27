
namespace eRestoran.WinUI.Nabavka
{
    partial class frmNabavkaNovaNamirnica
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
            this.btnSnimiNamirnica = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Nabavke = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtNamirnica = new System.Windows.Forms.TextBox();
            this.Prilog = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSnimiNamirnica
            // 
            this.btnSnimiNamirnica.BackColor = System.Drawing.Color.Red;
            this.btnSnimiNamirnica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSnimiNamirnica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSnimiNamirnica.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimiNamirnica.ForeColor = System.Drawing.Color.White;
            this.btnSnimiNamirnica.Location = new System.Drawing.Point(48, 266);
            this.btnSnimiNamirnica.Name = "btnSnimiNamirnica";
            this.btnSnimiNamirnica.Size = new System.Drawing.Size(235, 30);
            this.btnSnimiNamirnica.TabIndex = 75;
            this.btnSnimiNamirnica.Text = "Snimi";
            this.btnSnimiNamirnica.UseVisualStyleBackColor = false;
            this.btnSnimiNamirnica.Click += new System.EventHandler(this.btnSnimiNamirnica_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 14);
            this.label3.TabIndex = 73;
            // 
            // Nabavke
            // 
            this.Nabavke.AutoSize = true;
            this.Nabavke.BackColor = System.Drawing.Color.Transparent;
            this.Nabavke.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nabavke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nabavke.Location = new System.Drawing.Point(43, 38);
            this.Nabavke.Name = "Nabavke";
            this.Nabavke.Size = new System.Drawing.Size(185, 25);
            this.Nabavke.TabIndex = 71;
            this.Nabavke.Text = "Dodaj namirnicu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 14);
            this.label2.TabIndex = 70;
            this.label2.Text = "Cijena po komadu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 69;
            this.label1.Text = "Namirnica";
            // 
            // txtCijena
            // 
            this.txtCijena.AccessibleName = "txtCijena";
            this.txtCijena.Location = new System.Drawing.Point(48, 189);
            this.txtCijena.Margin = new System.Windows.Forms.Padding(4);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(235, 20);
            this.txtCijena.TabIndex = 68;
            // 
            // txtNamirnica
            // 
            this.txtNamirnica.AccessibleName = "txtNamirnica";
            this.txtNamirnica.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamirnica.Location = new System.Drawing.Point(48, 132);
            this.txtNamirnica.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamirnica.Name = "txtNamirnica";
            this.txtNamirnica.Size = new System.Drawing.Size(235, 22);
            this.txtNamirnica.TabIndex = 67;
            // 
            // Prilog
            // 
            this.Prilog.AutoSize = true;
            this.Prilog.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prilog.Location = new System.Drawing.Point(48, 229);
            this.Prilog.Name = "Prilog";
            this.Prilog.Size = new System.Drawing.Size(61, 18);
            this.Prilog.TabIndex = 76;
            this.Prilog.Text = "Prilog";
            this.Prilog.UseVisualStyleBackColor = true;
            // 
            // frmNabavkaNovaNamirnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 381);
            this.Controls.Add(this.Prilog);
            this.Controls.Add(this.btnSnimiNamirnica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nabavke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtNamirnica);
            this.Name = "frmNabavkaNovaNamirnica";
            this.Text = "frmNabavkaNovaNamirnica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSnimiNamirnica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nabavke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtNamirnica;
        private System.Windows.Forms.CheckBox Prilog;
    }
}