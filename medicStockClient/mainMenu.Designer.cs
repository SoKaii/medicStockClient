﻿namespace medicStockClient
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.Disconnect = new System.Windows.Forms.LinkLabel();
            this.header = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRecupMedic
            // 
            this.buttonRecupMedic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRecupMedic.Location = new System.Drawing.Point(785, 176);
            this.buttonRecupMedic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRecupMedic.Name = "buttonRecupMedic";
            this.buttonRecupMedic.Size = new System.Drawing.Size(275, 53);
            this.buttonRecupMedic.TabIndex = 0;
            this.buttonRecupMedic.Text = "Récupération médicament";
            this.buttonRecupMedic.UseVisualStyleBackColor = true;
            this.buttonRecupMedic.Click += new System.EventHandler(this.buttonRecupMedic_Click);
            // 
            // buttonConsultMedic
            // 
            this.buttonConsultMedic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConsultMedic.Location = new System.Drawing.Point(785, 254);
            this.buttonConsultMedic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConsultMedic.Name = "buttonConsultMedic";
            this.buttonConsultMedic.Size = new System.Drawing.Size(275, 53);
            this.buttonConsultMedic.TabIndex = 1;
            this.buttonConsultMedic.Text = "Consultation médicament";
            this.buttonConsultMedic.UseVisualStyleBackColor = true;
            this.buttonConsultMedic.Click += new System.EventHandler(this.buttonConsultMedic_Click);
            // 
            // buttonAddMedic
            // 
            this.buttonAddMedic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddMedic.Location = new System.Drawing.Point(645, 338);
            this.buttonAddMedic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddMedic.Name = "buttonAddMedic";
            this.buttonAddMedic.Size = new System.Drawing.Size(275, 53);
            this.buttonAddMedic.TabIndex = 2;
            this.buttonAddMedic.Text = "Ajout médicament";
            this.buttonAddMedic.UseVisualStyleBackColor = true;
            this.buttonAddMedic.Visible = false;
            this.buttonAddMedic.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddUser.Location = new System.Drawing.Point(941, 338);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(275, 53);
            this.buttonAddUser.TabIndex = 3;
            this.buttonAddUser.Text = "Ajout utilisateur";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Visible = false;
            this.buttonAddUser.Click += new System.EventHandler(this.button4_Click);
            // 
            // connectedLabel
            // 
            this.connectedLabel.AutoSize = true;
            this.connectedLabel.BackColor = System.Drawing.Color.MistyRose;
            this.connectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedLabel.Location = new System.Drawing.Point(678, 75);
            this.connectedLabel.Margin = new System.Windows.Forms.Padding(0);
            this.connectedLabel.Name = "connectedLabel";
            this.connectedLabel.Size = new System.Drawing.Size(206, 25);
            this.connectedLabel.TabIndex = 6;
            this.connectedLabel.Text = "You\'re connected as : ";
            // 
            // connectedAs
            // 
            this.connectedAs.AutoSize = true;
            this.connectedAs.BackColor = System.Drawing.Color.MistyRose;
            this.connectedAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedAs.ForeColor = System.Drawing.Color.OliveDrab;
            this.connectedAs.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.connectedAs.Location = new System.Drawing.Point(928, 75);
            this.connectedAs.Margin = new System.Windows.Forms.Padding(3, 2, 11, 0);
            this.connectedAs.Name = "connectedAs";
            this.connectedAs.Size = new System.Drawing.Size(138, 25);
            this.connectedAs.TabIndex = 7;
            this.connectedAs.Text = "connectedAs";
            this.connectedAs.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.connectedAs.Click += new System.EventHandler(this.connectedAs_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1694, 9);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(171, 151);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.contentPanel.Controls.Add(this.label2);
            this.contentPanel.Controls.Add(this.pictureBox1);
            this.contentPanel.Controls.Add(this.buttonRecupMedic);
            this.contentPanel.Controls.Add(this.buttonConsultMedic);
            this.contentPanel.Controls.Add(this.buttonAddMedic);
            this.contentPanel.Controls.Add(this.buttonAddUser);
            this.contentPanel.Location = new System.Drawing.Point(-70, 173);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(2548, 910);
            this.contentPanel.TabIndex = 10;
            this.contentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentPanel_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(821, 844);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Copyright (C) 2018 AGINFOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(0, 810);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2478, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.Disconnect);
            this.headerPanel.Controls.Add(this.pictureBox3);
            this.headerPanel.Controls.Add(this.connectedAs);
            this.headerPanel.Controls.Add(this.connectedLabel);
            this.headerPanel.Controls.Add(this.header);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1924, 1055);
            this.headerPanel.TabIndex = 10;
            this.headerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.headerPanel_Paint);
            // 
            // Disconnect
            // 
            this.Disconnect.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.Disconnect.AutoSize = true;
            this.Disconnect.BackColor = System.Drawing.Color.MistyRose;
            this.Disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnect.LinkColor = System.Drawing.Color.Red;
            this.Disconnect.Location = new System.Drawing.Point(67, 75);
            this.Disconnect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(127, 25);
            this.Disconnect.TabIndex = 16;
            this.Disconnect.TabStop = true;
            this.Disconnect.Text = "Deconnexion";
            this.Disconnect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.BackColor = System.Drawing.Color.MistyRose;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1924, 169);
            this.header.TabIndex = 15;
            this.header.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(1161, 1104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Copyright (C) 2018 AGINFOS";
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainMenu";
            this.Text = "mainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}