namespace medicStockClient
{
    partial class recupMedicament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recupMedicament));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Disconnect = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.connectedAs = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nameMedicList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.formeMedicList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dosageMedicList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Validation = new System.Windows.Forms.Button();
            this.listAddedMedic = new System.Windows.Forms.Panel();
            this.LBAddedMedic = new System.Windows.Forms.ListBox();
            this.BeginAddMedic = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.alreadyChoosed = new System.Windows.Forms.Label();
            this.actualStock = new System.Windows.Forms.Label();
            this.actualStockTitle = new System.Windows.Forms.Label();
            this.stockReached = new System.Windows.Forms.Label();
            this.listLimitTB = new System.Windows.Forms.Label();
            this.quantityMedic = new System.Windows.Forms.NumericUpDown();
            this.quantityError = new System.Windows.Forms.Label();
            this.noMedicError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.listAddedMedic.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityMedic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1726, 5);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(119, 119);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // Disconnect
            // 
            this.Disconnect.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.Disconnect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Disconnect.AutoSize = true;
            this.Disconnect.BackColor = System.Drawing.Color.MistyRose;
            this.Disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnect.LinkColor = System.Drawing.Color.Red;
            this.Disconnect.Location = new System.Drawing.Point(850, 44);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(102, 20);
            this.Disconnect.TabIndex = 16;
            this.Disconnect.TabStop = true;
            this.Disconnect.Text = "Deconnexion";
            this.Disconnect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Disconnect_LinkClicked);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(787, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Connecté(e) en tant que : ";
            // 
            // connectedAs
            // 
            this.connectedAs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.connectedAs.AutoSize = true;
            this.connectedAs.BackColor = System.Drawing.Color.MistyRose;
            this.connectedAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedAs.ForeColor = System.Drawing.Color.OliveDrab;
            this.connectedAs.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.connectedAs.Location = new System.Drawing.Point(983, 14);
            this.connectedAs.Margin = new System.Windows.Forms.Padding(2, 2, 8, 0);
            this.connectedAs.Name = "connectedAs";
            this.connectedAs.Size = new System.Drawing.Size(57, 20);
            this.connectedAs.TabIndex = 18;
            this.connectedAs.Text = "label1";
            this.connectedAs.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 891);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1857, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // nameMedicList
            // 
            this.nameMedicList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameMedicList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameMedicList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameMedicList.FormattingEnabled = true;
            this.nameMedicList.Location = new System.Drawing.Point(764, 298);
            this.nameMedicList.MaxDropDownItems = 30;
            this.nameMedicList.Name = "nameMedicList";
            this.nameMedicList.Size = new System.Drawing.Size(299, 28);
            this.nameMedicList.Sorted = true;
            this.nameMedicList.TabIndex = 22;
            this.nameMedicList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(662, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Médicament : ";
            // 
            // formeMedicList
            // 
            this.formeMedicList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formeMedicList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formeMedicList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formeMedicList.FormattingEnabled = true;
            this.formeMedicList.Location = new System.Drawing.Point(763, 375);
            this.formeMedicList.MaxDropDownItems = 17;
            this.formeMedicList.Name = "formeMedicList";
            this.formeMedicList.Size = new System.Drawing.Size(299, 28);
            this.formeMedicList.Sorted = true;
            this.formeMedicList.TabIndex = 24;
            this.formeMedicList.SelectedIndexChanged += new System.EventHandler(this.formeMedicList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(629, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Forme Galénique : ";
            // 
            // dosageMedicList
            // 
            this.dosageMedicList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dosageMedicList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dosageMedicList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosageMedicList.FormattingEnabled = true;
            this.dosageMedicList.Location = new System.Drawing.Point(763, 454);
            this.dosageMedicList.MaxDropDownItems = 14;
            this.dosageMedicList.Name = "dosageMedicList";
            this.dosageMedicList.Size = new System.Drawing.Size(299, 28);
            this.dosageMedicList.Sorted = true;
            this.dosageMedicList.TabIndex = 26;
            this.dosageMedicList.SelectedIndexChanged += new System.EventHandler(this.dosageMedicList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(653, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Dosage (mg)  : ";
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add.BackColor = System.Drawing.Color.OldLace;
            this.Add.Location = new System.Drawing.Point(722, 573);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(115, 44);
            this.Add.TabIndex = 28;
            this.Add.Text = "AJOUTER";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Validation
            // 
            this.Validation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Validation.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Validation.Location = new System.Drawing.Point(947, 573);
            this.Validation.Margin = new System.Windows.Forms.Padding(2);
            this.Validation.Name = "Validation";
            this.Validation.Size = new System.Drawing.Size(115, 44);
            this.Validation.TabIndex = 29;
            this.Validation.Text = "VALIDER";
            this.Validation.UseVisualStyleBackColor = false;
            this.Validation.Click += new System.EventHandler(this.Validate_Click);
            // 
            // listAddedMedic
            // 
            this.listAddedMedic.AutoSize = true;
            this.listAddedMedic.BackColor = System.Drawing.Color.OldLace;
            this.listAddedMedic.Controls.Add(this.LBAddedMedic);
            this.listAddedMedic.Controls.Add(this.BeginAddMedic);
            this.listAddedMedic.Dock = System.Windows.Forms.DockStyle.Left;
            this.listAddedMedic.Location = new System.Drawing.Point(0, 132);
            this.listAddedMedic.Margin = new System.Windows.Forms.Padding(0);
            this.listAddedMedic.Name = "listAddedMedic";
            this.listAddedMedic.Size = new System.Drawing.Size(415, 759);
            this.listAddedMedic.TabIndex = 30;
            // 
            // LBAddedMedic
            // 
            this.LBAddedMedic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBAddedMedic.BackColor = System.Drawing.Color.OldLace;
            this.LBAddedMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBAddedMedic.FormattingEnabled = true;
            this.LBAddedMedic.ItemHeight = 20;
            this.LBAddedMedic.Location = new System.Drawing.Point(5, 44);
            this.LBAddedMedic.Margin = new System.Windows.Forms.Padding(2);
            this.LBAddedMedic.Name = "LBAddedMedic";
            this.LBAddedMedic.Size = new System.Drawing.Size(408, 464);
            this.LBAddedMedic.TabIndex = 2;
            // 
            // BeginAddMedic
            // 
            this.BeginAddMedic.AutoSize = true;
            this.BeginAddMedic.BackColor = System.Drawing.Color.OldLace;
            this.BeginAddMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginAddMedic.Location = new System.Drawing.Point(2, 15);
            this.BeginAddMedic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BeginAddMedic.Name = "BeginAddMedic";
            this.BeginAddMedic.Size = new System.Drawing.Size(404, 17);
            this.BeginAddMedic.TabIndex = 1;
            this.BeginAddMedic.Text = "Commencez à ajouter des médicaments pour configurer la liste";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(851, 899);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Copyright (C) 2018 AGINFOS";
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.Title);
            this.headerPanel.Controls.Add(this.alreadyChoosed);
            this.headerPanel.Controls.Add(this.actualStock);
            this.headerPanel.Controls.Add(this.actualStockTitle);
            this.headerPanel.Controls.Add(this.stockReached);
            this.headerPanel.Controls.Add(this.listLimitTB);
            this.headerPanel.Controls.Add(this.quantityMedic);
            this.headerPanel.Controls.Add(this.quantityError);
            this.headerPanel.Controls.Add(this.noMedicError);
            this.headerPanel.Controls.Add(this.label6);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.listAddedMedic);
            this.headerPanel.Controls.Add(this.Validation);
            this.headerPanel.Controls.Add(this.Add);
            this.headerPanel.Controls.Add(this.label5);
            this.headerPanel.Controls.Add(this.dosageMedicList);
            this.headerPanel.Controls.Add(this.label4);
            this.headerPanel.Controls.Add(this.formeMedicList);
            this.headerPanel.Controls.Add(this.label3);
            this.headerPanel.Controls.Add(this.nameMedicList);
            this.headerPanel.Controls.Add(this.pictureBox2);
            this.headerPanel.Controls.Add(this.pictureBox1);
            this.headerPanel.Controls.Add(this.connectedAs);
            this.headerPanel.Controls.Add(this.label2);
            this.headerPanel.Controls.Add(this.Disconnect);
            this.headerPanel.Controls.Add(this.pictureBox3);
            this.headerPanel.Controls.Add(this.pictureBox4);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1857, 932);
            this.headerPanel.TabIndex = 11;
            // 
            // alreadyChoosed
            // 
            this.alreadyChoosed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alreadyChoosed.AutoSize = true;
            this.alreadyChoosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alreadyChoosed.ForeColor = System.Drawing.Color.Red;
            this.alreadyChoosed.Location = new System.Drawing.Point(475, 587);
            this.alreadyChoosed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alreadyChoosed.Name = "alreadyChoosed";
            this.alreadyChoosed.Size = new System.Drawing.Size(244, 17);
            this.alreadyChoosed.TabIndex = 40;
            this.alreadyChoosed.Text = "Vous avez déjà choisi ce médicament";
            this.alreadyChoosed.Visible = false;
            // 
            // actualStock
            // 
            this.actualStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.actualStock.AutoSize = true;
            this.actualStock.BackColor = System.Drawing.Color.White;
            this.actualStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actualStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualStock.Location = new System.Drawing.Point(1162, 525);
            this.actualStock.Name = "actualStock";
            this.actualStock.Size = new System.Drawing.Size(18, 19);
            this.actualStock.TabIndex = 39;
            this.actualStock.Text = "0";
            this.actualStock.Visible = false;
            // 
            // actualStockTitle
            // 
            this.actualStockTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.actualStockTitle.AutoSize = true;
            this.actualStockTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualStockTitle.Location = new System.Drawing.Point(1100, 525);
            this.actualStockTitle.Name = "actualStockTitle";
            this.actualStockTitle.Size = new System.Drawing.Size(55, 17);
            this.actualStockTitle.TabIndex = 38;
            this.actualStockTitle.Text = "Stock : ";
            this.actualStockTitle.Visible = false;
            // 
            // stockReached
            // 
            this.stockReached.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stockReached.AutoSize = true;
            this.stockReached.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockReached.ForeColor = System.Drawing.Color.Red;
            this.stockReached.Location = new System.Drawing.Point(1079, 587);
            this.stockReached.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stockReached.Name = "stockReached";
            this.stockReached.Size = new System.Drawing.Size(101, 17);
            this.stockReached.TabIndex = 37;
            this.stockReached.Text = "Stock dépassé";
            this.stockReached.Visible = false;
            this.stockReached.Click += new System.EventHandler(this.StockReached_Click);
            // 
            // listLimitTB
            // 
            this.listLimitTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listLimitTB.AutoSize = true;
            this.listLimitTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLimitTB.ForeColor = System.Drawing.Color.Red;
            this.listLimitTB.Location = new System.Drawing.Point(731, 630);
            this.listLimitTB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.listLimitTB.Name = "listLimitTB";
            this.listLimitTB.Size = new System.Drawing.Size(344, 17);
            this.listLimitTB.TabIndex = 36;
            this.listLimitTB.Text = "Vous avez atteint la limite de récupération simultanée";
            this.listLimitTB.Visible = false;
            // 
            // quantityMedic
            // 
            this.quantityMedic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantityMedic.Location = new System.Drawing.Point(764, 525);
            this.quantityMedic.Margin = new System.Windows.Forms.Padding(2);
            this.quantityMedic.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.quantityMedic.Name = "quantityMedic";
            this.quantityMedic.Size = new System.Drawing.Size(298, 20);
            this.quantityMedic.TabIndex = 35;
            // 
            // quantityError
            // 
            this.quantityError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantityError.AutoSize = true;
            this.quantityError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityError.ForeColor = System.Drawing.Color.Red;
            this.quantityError.Location = new System.Drawing.Point(748, 554);
            this.quantityError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantityError.Name = "quantityError";
            this.quantityError.Size = new System.Drawing.Size(314, 17);
            this.quantityError.TabIndex = 34;
            this.quantityError.Text = "Veuillez ajouter au moins 1 médicament à la liste";
            this.quantityError.Visible = false;
            // 
            // noMedicError
            // 
            this.noMedicError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noMedicError.AutoSize = true;
            this.noMedicError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noMedicError.ForeColor = System.Drawing.Color.Red;
            this.noMedicError.Location = new System.Drawing.Point(799, 490);
            this.noMedicError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noMedicError.Name = "noMedicError";
            this.noMedicError.Size = new System.Drawing.Size(212, 17);
            this.noMedicError.TabIndex = 33;
            this.noMedicError.Text = "Veuillez indiquer un médicament";
            this.noMedicError.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(679, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Quantité : ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1857, 132);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.MistyRose;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(797, 85);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(263, 25);
            this.Title.TabIndex = 41;
            this.Title.Text = "Récupération Médicament(s)";
            // 
            // recupMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1857, 932);
            this.Controls.Add(this.headerPanel);
            this.Name = "recupMedicament";
            this.Text = "recupMedicament";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.recupMedicament_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.listAddedMedic.ResumeLayout(false);
            this.listAddedMedic.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityMedic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel Disconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label connectedAs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox nameMedicList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox formeMedicList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dosageMedicList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add;
        public System.Windows.Forms.Button Validation;
        private System.Windows.Forms.Panel listAddedMedic;
        private System.Windows.Forms.ListBox LBAddedMedic;
        private System.Windows.Forms.Label BeginAddMedic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label noMedicError;
        private System.Windows.Forms.Label quantityError;
        private System.Windows.Forms.NumericUpDown quantityMedic;
        private System.Windows.Forms.Label listLimitTB;
        private System.Windows.Forms.Label actualStock;
        private System.Windows.Forms.Label actualStockTitle;
        private System.Windows.Forms.Label stockReached;
        private System.Windows.Forms.Label alreadyChoosed;
        private System.Windows.Forms.Label Title;
    }
}