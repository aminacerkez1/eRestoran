
namespace eRestoran.WinUI.Nabavka
{
    partial class frmNabavkaNova
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNabavkaNova));
            this.label1 = new System.Windows.Forms.Label();
            this.Nabavke = new System.Windows.Forms.Label();
            this.dgvPice = new System.Windows.Forms.DataGridView();
            this.PiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NabakvaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCijenaPice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NabavkaPiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNamirnice = new System.Windows.Forms.DataGridView();
            this.NamirnicaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NabavkaNamirnicaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNovoPice = new System.Windows.Forms.Button();
            this.btnNovaNamirnica = new System.Windows.Forms.Button();
            this.comboBoxNamirnice = new System.Windows.Forms.ComboBox();
            this.comboBoxPice = new System.Windows.Forms.ComboBox();
            this.numericNamirnice = new System.Windows.Forms.NumericUpDown();
            this.numericPice = new System.Windows.Forms.NumericUpDown();
            this.btnDodajNamirnicu = new System.Windows.Forms.Button();
            this.btnDodajPice = new System.Windows.Forms.Button();
            this.btnZakljuci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNamirnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNamirnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(83, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Piće";
            // 
            // Nabavke
            // 
            this.Nabavke.AutoSize = true;
            this.Nabavke.BackColor = System.Drawing.Color.Transparent;
            this.Nabavke.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nabavke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nabavke.Location = new System.Drawing.Point(62, -21);
            this.Nabavke.Name = "Nabavke";
            this.Nabavke.Size = new System.Drawing.Size(118, 25);
            this.Nabavke.TabIndex = 6;
            this.Nabavke.Text = "Namirnice";
            // 
            // dgvPice
            // 
            this.dgvPice.AllowUserToAddRows = false;
            this.dgvPice.AllowUserToDeleteRows = false;
            this.dgvPice.AllowUserToResizeRows = false;
            this.dgvPice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPice.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PiceId,
            this.Naziv,
            this.Kolicina,
            this.NabakvaId,
            this.UkupnaCijenaPice,
            this.NabavkaPiceId});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPice.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPice.EnableHeadersVisualStyles = false;
            this.dgvPice.Location = new System.Drawing.Point(88, 346);
            this.dgvPice.Name = "dgvPice";
            this.dgvPice.ReadOnly = true;
            this.dgvPice.RowHeadersVisible = false;
            this.dgvPice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPice.Size = new System.Drawing.Size(671, 197);
            this.dgvPice.TabIndex = 4;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.Naziv.DefaultCellStyle = dataGridViewCellStyle2;
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            this.Kolicina.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            this.UkupnaCijenaPice.DefaultCellStyle = dataGridViewCellStyle4;
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
            // dgvNamirnice
            // 
            this.dgvNamirnice.AllowUserToAddRows = false;
            this.dgvNamirnice.AllowUserToDeleteRows = false;
            this.dgvNamirnice.AllowUserToResizeRows = false;
            this.dgvNamirnice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNamirnice.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNamirnice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNamirnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNamirnice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamirnicaID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.UkupnaCijena,
            this.dataGridViewTextBoxColumn3,
            this.NabavkaNamirnicaID});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNamirnice.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNamirnice.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvNamirnice.EnableHeadersVisualStyles = false;
            this.dgvNamirnice.GridColor = System.Drawing.Color.White;
            this.dgvNamirnice.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvNamirnice.Location = new System.Drawing.Point(88, 96);
            this.dgvNamirnice.Name = "dgvNamirnice";
            this.dgvNamirnice.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNamirnice.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvNamirnice.RowHeadersVisible = false;
            this.dgvNamirnice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            this.dgvNamirnice.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvNamirnice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNamirnice.Size = new System.Drawing.Size(671, 185);
            this.dgvNamirnice.TabIndex = 5;
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
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Kolicina";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn2.HeaderText = "Količina";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // UkupnaCijena
            // 
            this.UkupnaCijena.DataPropertyName = "UkupnaCijena";
            this.UkupnaCijena.HeaderText = "Ukupna cijena";
            this.UkupnaCijena.Name = "UkupnaCijena";
            this.UkupnaCijena.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NabavkaID";
            this.dataGridViewTextBoxColumn3.HeaderText = "NabakvaId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // NabavkaNamirnicaID
            // 
            this.NabavkaNamirnicaID.DataPropertyName = "NabavkaNamirnicaID";
            this.NabavkaNamirnicaID.HeaderText = "NabavkaNamirnicaID";
            this.NabavkaNamirnicaID.Name = "NabavkaNamirnicaID";
            this.NabavkaNamirnicaID.ReadOnly = true;
            this.NabavkaNamirnicaID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(83, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Namirnice";
            // 
            // btnNovoPice
            // 
            this.btnNovoPice.BackColor = System.Drawing.Color.Red;
            this.btnNovoPice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovoPice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoPice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoPice.ForeColor = System.Drawing.Color.White;
            this.btnNovoPice.Location = new System.Drawing.Point(622, 303);
            this.btnNovoPice.Name = "btnNovoPice";
            this.btnNovoPice.Size = new System.Drawing.Size(137, 30);
            this.btnNovoPice.TabIndex = 10;
            this.btnNovoPice.Text = "Novo piće";
            this.btnNovoPice.UseVisualStyleBackColor = false;
            this.btnNovoPice.Click += new System.EventHandler(this.btnNovoPice_Click);
            // 
            // btnNovaNamirnica
            // 
            this.btnNovaNamirnica.BackColor = System.Drawing.Color.Red;
            this.btnNovaNamirnica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovaNamirnica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovaNamirnica.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaNamirnica.ForeColor = System.Drawing.Color.White;
            this.btnNovaNamirnica.Location = new System.Drawing.Point(622, 48);
            this.btnNovaNamirnica.Name = "btnNovaNamirnica";
            this.btnNovaNamirnica.Size = new System.Drawing.Size(137, 30);
            this.btnNovaNamirnica.TabIndex = 11;
            this.btnNovaNamirnica.Text = "Nova namirnica";
            this.btnNovaNamirnica.UseVisualStyleBackColor = false;
            this.btnNovaNamirnica.Click += new System.EventHandler(this.btnNovaNamirnica_Click);
            // 
            // comboBoxNamirnice
            // 
            this.comboBoxNamirnice.FormattingEnabled = true;
            this.comboBoxNamirnice.Location = new System.Drawing.Point(230, 57);
            this.comboBoxNamirnice.Name = "comboBoxNamirnice";
            this.comboBoxNamirnice.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNamirnice.TabIndex = 12;
            // 
            // comboBoxPice
            // 
            this.comboBoxPice.FormattingEnabled = true;
            this.comboBoxPice.Location = new System.Drawing.Point(230, 309);
            this.comboBoxPice.Name = "comboBoxPice";
            this.comboBoxPice.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPice.TabIndex = 13;
            // 
            // numericNamirnice
            // 
            this.numericNamirnice.Location = new System.Drawing.Point(385, 58);
            this.numericNamirnice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNamirnice.Name = "numericNamirnice";
            this.numericNamirnice.Size = new System.Drawing.Size(121, 20);
            this.numericNamirnice.TabIndex = 14;
            this.numericNamirnice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericPice
            // 
            this.numericPice.Location = new System.Drawing.Point(385, 309);
            this.numericPice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPice.Name = "numericPice";
            this.numericPice.Size = new System.Drawing.Size(121, 20);
            this.numericPice.TabIndex = 15;
            this.numericPice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDodajNamirnicu
            // 
            this.btnDodajNamirnicu.BackColor = System.Drawing.Color.Red;
            this.btnDodajNamirnicu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodajNamirnicu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajNamirnicu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNamirnicu.ForeColor = System.Drawing.Color.White;
            this.btnDodajNamirnicu.Location = new System.Drawing.Point(523, 48);
            this.btnDodajNamirnicu.Name = "btnDodajNamirnicu";
            this.btnDodajNamirnicu.Size = new System.Drawing.Size(82, 30);
            this.btnDodajNamirnicu.TabIndex = 16;
            this.btnDodajNamirnicu.Text = "Dodaj";
            this.btnDodajNamirnicu.UseVisualStyleBackColor = false;
            this.btnDodajNamirnicu.Click += new System.EventHandler(this.btnDodajNamirnicu_Click);
            // 
            // btnDodajPice
            // 
            this.btnDodajPice.BackColor = System.Drawing.Color.Red;
            this.btnDodajPice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodajPice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajPice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPice.ForeColor = System.Drawing.Color.White;
            this.btnDodajPice.Location = new System.Drawing.Point(523, 303);
            this.btnDodajPice.Name = "btnDodajPice";
            this.btnDodajPice.Size = new System.Drawing.Size(82, 30);
            this.btnDodajPice.TabIndex = 17;
            this.btnDodajPice.Text = "Dodaj";
            this.btnDodajPice.UseVisualStyleBackColor = false;
            this.btnDodajPice.Click += new System.EventHandler(this.btnDodajPice_Click);
            // 
            // btnZakljuci
            // 
            this.btnZakljuci.BackColor = System.Drawing.Color.Red;
            this.btnZakljuci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZakljuci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZakljuci.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZakljuci.ForeColor = System.Drawing.Color.White;
            this.btnZakljuci.Location = new System.Drawing.Point(776, 48);
            this.btnZakljuci.Name = "btnZakljuci";
            this.btnZakljuci.Size = new System.Drawing.Size(95, 30);
            this.btnZakljuci.TabIndex = 18;
            this.btnZakljuci.Text = "Zaključi";
            this.btnZakljuci.UseVisualStyleBackColor = false;
            this.btnZakljuci.Click += new System.EventHandler(this.btnZakljuci_Click);
            // 
            // frmNabavkaNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 554);
            this.ControlBox = false;
            this.Controls.Add(this.btnZakljuci);
            this.Controls.Add(this.btnDodajPice);
            this.Controls.Add(this.btnDodajNamirnicu);
            this.Controls.Add(this.numericPice);
            this.Controls.Add(this.numericNamirnice);
            this.Controls.Add(this.comboBoxPice);
            this.Controls.Add(this.comboBoxNamirnice);
            this.Controls.Add(this.btnNovaNamirnica);
            this.Controls.Add(this.btnNovoPice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nabavke);
            this.Controls.Add(this.dgvPice);
            this.Controls.Add(this.dgvNamirnice);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNabavkaNova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNabavkaNova";
            this.Load += new System.EventHandler(this.frmNabavkaNova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNamirnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNamirnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nabavke;
        private System.Windows.Forms.DataGridView dgvPice;
        private System.Windows.Forms.DataGridView dgvNamirnice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNovoPice;
        private System.Windows.Forms.Button btnNovaNamirnica;
        private System.Windows.Forms.ComboBox comboBoxNamirnice;
        private System.Windows.Forms.ComboBox comboBoxPice;
        private System.Windows.Forms.NumericUpDown numericNamirnice;
        private System.Windows.Forms.NumericUpDown numericPice;
        private System.Windows.Forms.Button btnDodajNamirnicu;
        private System.Windows.Forms.Button btnDodajPice;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamirnicaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NabavkaNamirnicaID;
        private System.Windows.Forms.Button btnZakljuci;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn NabakvaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCijenaPice;
        private System.Windows.Forms.DataGridViewTextBoxColumn NabavkaPiceId;
    }
}