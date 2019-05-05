namespace medicStockClient
{
    partial class consultMedic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultMedic));
            this.listLimitTB = new System.Windows.Forms.Label();
            this.noMedicError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listAddedMedic = new System.Windows.Forms.Panel();
            this.LBAddedMedic = new System.Windows.Forms.ListBox();
            this.BeginAddMedic = new System.Windows.Forms.Label();
            this.Validation = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dosageMedicList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.formeMedicList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameMedicList = new System.Windows.Forms.ComboBox();
            this.connectedAs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Disconnect = new System.Windows.Forms.LinkLabel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.listAddedMedic.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // listLimitTB
            // 
            this.listLimitTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listLimitTB.AutoSize = true;
            this.listLimitTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLimitTB.ForeColor = System.Drawing.Color.Red;
            this.listLimitTB.Location = new System.Drawing.Point(705, 556);
            this.listLimitTB.Name = "listLimitTB";
            this.listLimitTB.Size = new System.Drawing.Size(408, 20);
            this.listLimitTB.TabIndex = 36;
            this.listLimitTB.Text = "Vous avez atteint la limite de récupération simultanée";
            this.listLimitTB.Visible = false;
            // 
            // noMedicError
            // 
            this.noMedicError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noMedicError.AutoSize = true;
            this.noMedicError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noMedicError.ForeColor = System.Drawing.Color.Red;
            this.noMedicError.Location = new System.Drawing.Point(793, 428);
            this.noMedicError.Name = "noMedicError";
            this.noMedicError.Size = new System.Drawing.Size(251, 20);
            this.noMedicError.TabIndex = 33;
            this.noMedicError.Text = "Veuillez indiquer un médicament";
            this.noMedicError.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(864, 761);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Copyright (C) 2018 AGINFOS";
            // 
            // listAddedMedic
            // 
            this.listAddedMedic.AutoSize = true;
            this.listAddedMedic.BackColor = System.Drawing.Color.OldLace;
            this.listAddedMedic.Controls.Add(this.LBAddedMedic);
            this.listAddedMedic.Controls.Add(this.BeginAddMedic);
            this.listAddedMedic.Dock = System.Windows.Forms.DockStyle.Left;
            this.listAddedMedic.Location = new System.Drawing.Point(0, 162);
            this.listAddedMedic.Margin = new System.Windows.Forms.Padding(0);
            this.listAddedMedic.Name = "listAddedMedic";
            this.listAddedMedic.Size = new System.Drawing.Size(553, 589);
            this.listAddedMedic.TabIndex = 30;
            // 
            // LBAddedMedic
            // 
            this.LBAddedMedic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBAddedMedic.BackColor = System.Drawing.Color.OldLace;
            this.LBAddedMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBAddedMedic.FormattingEnabled = true;
            this.LBAddedMedic.ItemHeight = 25;
            this.LBAddedMedic.Location = new System.Drawing.Point(7, 54);
            this.LBAddedMedic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LBAddedMedic.Name = "LBAddedMedic";
            this.LBAddedMedic.Size = new System.Drawing.Size(543, 254);
            this.LBAddedMedic.TabIndex = 2;
            // 
            // BeginAddMedic
            // 
            this.BeginAddMedic.AutoSize = true;
            this.BeginAddMedic.BackColor = System.Drawing.Color.OldLace;
            this.BeginAddMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginAddMedic.Location = new System.Drawing.Point(3, 18);
            this.BeginAddMedic.Name = "BeginAddMedic";
            this.BeginAddMedic.Size = new System.Drawing.Size(482, 20);
            this.BeginAddMedic.TabIndex = 1;
            this.BeginAddMedic.Text = "Commencez à ajouter des médicaments pour configurer la liste";
            // 
            // Validation
            // 
            this.Validation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Validation.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Validation.Location = new System.Drawing.Point(993, 487);
            this.Validation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Validation.Name = "Validation";
            this.Validation.Size = new System.Drawing.Size(153, 54);
            this.Validation.TabIndex = 29;
            this.Validation.Text = "VALIDER";
            this.Validation.UseVisualStyleBackColor = false;
            this.Validation.Click += new System.EventHandler(this.Validate_Click);
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add.BackColor = System.Drawing.Color.OldLace;
            this.Add.Location = new System.Drawing.Point(693, 487);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(153, 54);
            this.Add.TabIndex = 28;
            this.Add.Text = "AJOUTER";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(599, 391);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Dosage (mg)  : ";
            // 
            // dosageMedicList
            // 
            this.dosageMedicList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dosageMedicList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dosageMedicList.FormattingEnabled = true;
            this.dosageMedicList.Location = new System.Drawing.Point(748, 386);
            this.dosageMedicList.Margin = new System.Windows.Forms.Padding(4);
            this.dosageMedicList.Name = "dosageMedicList";
            this.dosageMedicList.Size = new System.Drawing.Size(397, 24);
            this.dosageMedicList.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(568, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Forme Galénique : ";
            // 
            // formeMedicList
            // 
            this.formeMedicList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formeMedicList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formeMedicList.FormattingEnabled = true;
            this.formeMedicList.Location = new System.Drawing.Point(748, 293);
            this.formeMedicList.Margin = new System.Windows.Forms.Padding(4);
            this.formeMedicList.Name = "formeMedicList";
            this.formeMedicList.Size = new System.Drawing.Size(397, 24);
            this.formeMedicList.TabIndex = 24;
            this.formeMedicList.SelectedIndexChanged += new System.EventHandler(this.formeMedicList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(612, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Médicament : ";
            // 
            // nameMedicList
            // 
            this.nameMedicList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameMedicList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameMedicList.FormattingEnabled = true;
            this.nameMedicList.Location = new System.Drawing.Point(748, 194);
            this.nameMedicList.Margin = new System.Windows.Forms.Padding(4);
            this.nameMedicList.Name = "nameMedicList";
            this.nameMedicList.Size = new System.Drawing.Size(397, 24);
            this.nameMedicList.TabIndex = 22;
            this.nameMedicList.SelectedIndexChanged += new System.EventHandler(this.nameMedicList_SelectedIndexChanged);
            // 
            // connectedAs
            // 
            this.connectedAs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.connectedAs.AutoSize = true;
            this.connectedAs.BackColor = System.Drawing.Color.MistyRose;
            this.connectedAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedAs.ForeColor = System.Drawing.Color.OliveDrab;
            this.connectedAs.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.connectedAs.Location = new System.Drawing.Point(1041, 54);
            this.connectedAs.Margin = new System.Windows.Forms.Padding(3, 2, 11, 0);
            this.connectedAs.Name = "connectedAs";
            this.connectedAs.Size = new System.Drawing.Size(70, 25);
            this.connectedAs.TabIndex = 18;
            this.connectedAs.Text = "label1";
            this.connectedAs.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(792, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Connecté(e) en tant que : ";
            // 
            // Disconnect
            // 
            this.Disconnect.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.Disconnect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Disconnect.AutoSize = true;
            this.Disconnect.BackColor = System.Drawing.Color.MistyRose;
            this.Disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnect.LinkColor = System.Drawing.Color.Red;
            this.Disconnect.Location = new System.Drawing.Point(863, 105);
            this.Disconnect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(127, 25);
            this.Disconnect.TabIndex = 16;
            this.Disconnect.TabStop = true;
            this.Disconnect.Text = "Deconnexion";
            this.Disconnect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Disconnect_LinkClicked);
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.listLimitTB);
            this.headerPanel.Controls.Add(this.noMedicError);
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
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1933, 801);
            this.headerPanel.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 17);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 751);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1933, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1759, 6);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(159, 146);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1933, 162);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // consultMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1933, 801);
            this.Controls.Add(this.headerPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "consultMedic";
            this.Text = "consultMedic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.consultMedic_FormClosing);
            this.listAddedMedic.ResumeLayout(false);
            this.listAddedMedic.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label listLimitTB;
        private System.Windows.Forms.Label noMedicError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel listAddedMedic;
        private System.Windows.Forms.ListBox LBAddedMedic;
        private System.Windows.Forms.Label BeginAddMedic;
        public System.Windows.Forms.Button Validation;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dosageMedicList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox formeMedicList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox nameMedicList;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label connectedAs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel Disconnect;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel headerPanel;
    }
}