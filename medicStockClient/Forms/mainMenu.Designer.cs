namespace medicStockClient
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.buttonRecupMedic = new System.Windows.Forms.Button();
            this.buttonConsultMedic = new System.Windows.Forms.Button();
            this.buttonAddMedic = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.connectedLabel = new System.Windows.Forms.Label();
            this.connectedAs = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.verifPeremptionBt = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.Disconnect = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRecupMedic
            // 
            this.buttonRecupMedic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRecupMedic.Location = new System.Drawing.Point(627, 187);
            this.buttonRecupMedic.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRecupMedic.Name = "buttonRecupMedic";
            this.buttonRecupMedic.Size = new System.Drawing.Size(206, 43);
            this.buttonRecupMedic.TabIndex = 0;
            this.buttonRecupMedic.Text = "Récupération médicament";
            this.buttonRecupMedic.UseVisualStyleBackColor = true;
            this.buttonRecupMedic.Click += new System.EventHandler(this.buttonRecupMedic_Click);
            // 
            // buttonConsultMedic
            // 
            this.buttonConsultMedic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConsultMedic.Location = new System.Drawing.Point(627, 246);
            this.buttonConsultMedic.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConsultMedic.Name = "buttonConsultMedic";
            this.buttonConsultMedic.Size = new System.Drawing.Size(206, 43);
            this.buttonConsultMedic.TabIndex = 1;
            this.buttonConsultMedic.Text = "Consultation médicament";
            this.buttonConsultMedic.UseVisualStyleBackColor = true;
            this.buttonConsultMedic.Click += new System.EventHandler(this.buttonConsultMedic_Click);
            // 
            // buttonAddMedic
            // 
            this.buttonAddMedic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddMedic.Location = new System.Drawing.Point(490, 306);
            this.buttonAddMedic.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddMedic.Name = "buttonAddMedic";
            this.buttonAddMedic.Size = new System.Drawing.Size(206, 43);
            this.buttonAddMedic.TabIndex = 2;
            this.buttonAddMedic.Text = "Ajout médicament";
            this.buttonAddMedic.UseVisualStyleBackColor = true;
            this.buttonAddMedic.Visible = false;
            this.buttonAddMedic.Click += new System.EventHandler(this.ButtonAddMedic_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddUser.Location = new System.Drawing.Point(752, 306);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(206, 43);
            this.buttonAddUser.TabIndex = 3;
            this.buttonAddUser.Text = "Ajout utilisateur";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Visible = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // connectedLabel
            // 
            this.connectedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connectedLabel.AutoSize = true;
            this.connectedLabel.BackColor = System.Drawing.Color.MistyRose;
            this.connectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedLabel.Location = new System.Drawing.Point(507, 61);
            this.connectedLabel.Margin = new System.Windows.Forms.Padding(0);
            this.connectedLabel.Name = "connectedLabel";
            this.connectedLabel.Size = new System.Drawing.Size(194, 20);
            this.connectedLabel.TabIndex = 6;
            this.connectedLabel.Text = "Connecté(e) en tant que : ";
            // 
            // connectedAs
            // 
            this.connectedAs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connectedAs.AutoSize = true;
            this.connectedAs.BackColor = System.Drawing.Color.MistyRose;
            this.connectedAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedAs.ForeColor = System.Drawing.Color.OliveDrab;
            this.connectedAs.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.connectedAs.Location = new System.Drawing.Point(695, 61);
            this.connectedAs.Margin = new System.Windows.Forms.Padding(2, 2, 8, 0);
            this.connectedAs.Name = "connectedAs";
            this.connectedAs.Size = new System.Drawing.Size(114, 20);
            this.connectedAs.TabIndex = 7;
            this.connectedAs.Text = "connectedAs";
            this.connectedAs.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.contentPanel.Controls.Add(this.label2);
            this.contentPanel.Controls.Add(this.verifPeremptionBt);
            this.contentPanel.Controls.Add(this.buttonRecupMedic);
            this.contentPanel.Controls.Add(this.pictureBox2);
            this.contentPanel.Controls.Add(this.buttonConsultMedic);
            this.contentPanel.Controls.Add(this.buttonAddMedic);
            this.contentPanel.Controls.Add(this.buttonAddUser);
            this.contentPanel.Location = new System.Drawing.Point(-53, 137);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1911, 717);
            this.contentPanel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(678, 681);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Copyright (C) 2018 AGINFOS";
            // 
            // verifPeremptionBt
            // 
            this.verifPeremptionBt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.verifPeremptionBt.BackColor = System.Drawing.Color.LightSalmon;
            this.verifPeremptionBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifPeremptionBt.Location = new System.Drawing.Point(644, 23);
            this.verifPeremptionBt.Margin = new System.Windows.Forms.Padding(2);
            this.verifPeremptionBt.Name = "verifPeremptionBt";
            this.verifPeremptionBt.Size = new System.Drawing.Size(178, 58);
            this.verifPeremptionBt.TabIndex = 23;
            this.verifPeremptionBt.Text = "Vérification Péremption";
            this.verifPeremptionBt.UseVisualStyleBackColor = false;
            this.verifPeremptionBt.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 655);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1911, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.Disconnect);
            this.headerPanel.Controls.Add(this.pictureBox3);
            this.headerPanel.Controls.Add(this.connectedAs);
            this.headerPanel.Controls.Add(this.connectedLabel);
            this.headerPanel.Controls.Add(this.header);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1441, 857);
            this.headerPanel.TabIndex = 10;
            // 
            // Disconnect
            // 
            this.Disconnect.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.Disconnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Disconnect.AutoSize = true;
            this.Disconnect.BackColor = System.Drawing.Color.MistyRose;
            this.Disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnect.LinkColor = System.Drawing.Color.Red;
            this.Disconnect.Location = new System.Drawing.Point(49, 61);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(102, 20);
            this.Disconnect.TabIndex = 16;
            this.Disconnect.TabStop = true;
            this.Disconnect.Text = "Deconnexion";
            this.Disconnect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1268, 7);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 123);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // header
            // 
            this.header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.header.BackColor = System.Drawing.Color.MistyRose;
            this.header.Location = new System.Drawing.Point(-1, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1443, 137);
            this.header.TabIndex = 15;
            this.header.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(870, 893);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Copyright (C) 2018 AGINFOS";
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 853);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainMenu";
            this.Text = "mainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainMenu_FormClosing);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRecupMedic;
        private System.Windows.Forms.Button buttonConsultMedic;
        private System.Windows.Forms.Button buttonAddMedic;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Label connectedLabel;
        private System.Windows.Forms.Label connectedAs;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.LinkLabel Disconnect;
        private System.Windows.Forms.Button verifPeremptionBt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}