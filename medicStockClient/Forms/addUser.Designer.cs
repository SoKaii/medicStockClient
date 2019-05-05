namespace medicStockClient
{
    partial class addUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addUser));
            this.listLimitTB = new System.Windows.Forms.Label();
            this.Validation = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.noUserError = new System.Windows.Forms.Label();
            this.noAdmin = new System.Windows.Forms.RadioButton();
            this.yesAdmin = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.prenomTB = new System.Windows.Forms.TextBox();
            this.nomTB = new System.Windows.Forms.TextBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.notAllCompletedError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listAddedMedic = new System.Windows.Forms.Panel();
            this.LBAddedUser = new System.Windows.Forms.ListBox();
            this.BeginAddUser = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.connectedAs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Disconnect = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.headerPanel.SuspendLayout();
            this.listAddedMedic.SuspendLayout();
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
            this.listLimitTB.Location = new System.Drawing.Point(618, 633);
            this.listLimitTB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.listLimitTB.Name = "listLimitTB";
            this.listLimitTB.Size = new System.Drawing.Size(292, 17);
            this.listLimitTB.TabIndex = 36;
            this.listLimitTB.Text = "Vous avez atteint la limite d\'ajouts simultanés";
            this.listLimitTB.Visible = false;
            // 
            // Validation
            // 
            this.Validation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Validation.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Validation.Location = new System.Drawing.Point(816, 575);
            this.Validation.Margin = new System.Windows.Forms.Padding(2);
            this.Validation.Name = "Validation";
            this.Validation.Size = new System.Drawing.Size(115, 44);
            this.Validation.TabIndex = 29;
            this.Validation.Text = "VALIDER";
            this.Validation.UseVisualStyleBackColor = false;
            this.Validation.Click += new System.EventHandler(this.Validate_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.noUserError);
            this.headerPanel.Controls.Add(this.noAdmin);
            this.headerPanel.Controls.Add(this.yesAdmin);
            this.headerPanel.Controls.Add(this.label7);
            this.headerPanel.Controls.Add(this.passwordTB);
            this.headerPanel.Controls.Add(this.prenomTB);
            this.headerPanel.Controls.Add(this.nomTB);
            this.headerPanel.Controls.Add(this.loginTB);
            this.headerPanel.Controls.Add(this.listLimitTB);
            this.headerPanel.Controls.Add(this.notAllCompletedError);
            this.headerPanel.Controls.Add(this.label6);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.listAddedMedic);
            this.headerPanel.Controls.Add(this.Validation);
            this.headerPanel.Controls.Add(this.Add);
            this.headerPanel.Controls.Add(this.label5);
            this.headerPanel.Controls.Add(this.label4);
            this.headerPanel.Controls.Add(this.label3);
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
            this.headerPanel.Size = new System.Drawing.Size(1443, 777);
            this.headerPanel.TabIndex = 12;
            // 
            // noUserError
            // 
            this.noUserError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noUserError.AutoSize = true;
            this.noUserError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noUserError.ForeColor = System.Drawing.Color.Red;
            this.noUserError.Location = new System.Drawing.Point(621, 650);
            this.noUserError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noUserError.Name = "noUserError";
            this.noUserError.Size = new System.Drawing.Size(289, 17);
            this.noUserError.TabIndex = 44;
            this.noUserError.Text = "Veuillez ajouter au moins 1 nouvel utilisateur";
            this.noUserError.Visible = false;
            // 
            // noAdmin
            // 
            this.noAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noAdmin.AutoSize = true;
            this.noAdmin.Location = new System.Drawing.Point(759, 443);
            this.noAdmin.Name = "noAdmin";
            this.noAdmin.Size = new System.Drawing.Size(49, 17);
            this.noAdmin.TabIndex = 43;
            this.noAdmin.TabStop = true;
            this.noAdmin.Text = "NON";
            this.noAdmin.UseVisualStyleBackColor = true;
            // 
            // yesAdmin
            // 
            this.yesAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yesAdmin.AutoSize = true;
            this.yesAdmin.Location = new System.Drawing.Point(680, 443);
            this.yesAdmin.Name = "yesAdmin";
            this.yesAdmin.Size = new System.Drawing.Size(44, 17);
            this.yesAdmin.TabIndex = 42;
            this.yesAdmin.TabStop = true;
            this.yesAdmin.Text = "OUI";
            this.yesAdmin.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(500, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Mot de passe : ";
            // 
            // passwordTB
            // 
            this.passwordTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTB.Location = new System.Drawing.Point(621, 499);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(273, 20);
            this.passwordTB.TabIndex = 40;
            // 
            // prenomTB
            // 
            this.prenomTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prenomTB.Location = new System.Drawing.Point(621, 380);
            this.prenomTB.Name = "prenomTB";
            this.prenomTB.Size = new System.Drawing.Size(273, 20);
            this.prenomTB.TabIndex = 39;
            // 
            // nomTB
            // 
            this.nomTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomTB.Location = new System.Drawing.Point(621, 301);
            this.nomTB.Name = "nomTB";
            this.nomTB.Size = new System.Drawing.Size(273, 20);
            this.nomTB.TabIndex = 38;
            // 
            // loginTB
            // 
            this.loginTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.loginTB.Location = new System.Drawing.Point(621, 221);
            this.loginTB.MaxLength = 8;
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(273, 20);
            this.loginTB.TabIndex = 37;
            this.loginTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginTB_KeyPress);
            // 
            // notAllCompletedError
            // 
            this.notAllCompletedError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notAllCompletedError.AutoSize = true;
            this.notAllCompletedError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notAllCompletedError.ForeColor = System.Drawing.Color.Red;
            this.notAllCompletedError.Location = new System.Drawing.Point(657, 541);
            this.notAllCompletedError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.notAllCompletedError.Name = "notAllCompletedError";
            this.notAllCompletedError.Size = new System.Drawing.Size(210, 17);
            this.notAllCompletedError.TabIndex = 34;
            this.notAllCompletedError.Text = "Veuillez remplir tous les champs";
            this.notAllCompletedError.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(494, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Administrateur : ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(644, 744);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Copyright (C) 2018 AGINFOS";
            // 
            // listAddedMedic
            // 
            this.listAddedMedic.AutoSize = true;
            this.listAddedMedic.BackColor = System.Drawing.Color.OldLace;
            this.listAddedMedic.Controls.Add(this.LBAddedUser);
            this.listAddedMedic.Controls.Add(this.BeginAddUser);
            this.listAddedMedic.Dock = System.Windows.Forms.DockStyle.Left;
            this.listAddedMedic.Location = new System.Drawing.Point(0, 132);
            this.listAddedMedic.Margin = new System.Windows.Forms.Padding(0);
            this.listAddedMedic.Name = "listAddedMedic";
            this.listAddedMedic.Size = new System.Drawing.Size(481, 604);
            this.listAddedMedic.TabIndex = 30;
            // 
            // LBAddedUser
            // 
            this.LBAddedUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBAddedUser.BackColor = System.Drawing.Color.OldLace;
            this.LBAddedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBAddedUser.FormattingEnabled = true;
            this.LBAddedUser.ItemHeight = 20;
            this.LBAddedUser.Location = new System.Drawing.Point(5, 44);
            this.LBAddedUser.Margin = new System.Windows.Forms.Padding(2);
            this.LBAddedUser.Name = "LBAddedUser";
            this.LBAddedUser.Size = new System.Drawing.Size(474, 324);
            this.LBAddedUser.TabIndex = 2;
            // 
            // BeginAddUser
            // 
            this.BeginAddUser.AutoSize = true;
            this.BeginAddUser.BackColor = System.Drawing.Color.OldLace;
            this.BeginAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginAddUser.Location = new System.Drawing.Point(2, 15);
            this.BeginAddUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BeginAddUser.Name = "BeginAddUser";
            this.BeginAddUser.Size = new System.Drawing.Size(404, 17);
            this.BeginAddUser.TabIndex = 1;
            this.BeginAddUser.Text = "Commencez à ajouter des médicaments pour configurer la liste";
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add.BackColor = System.Drawing.Color.OldLace;
            this.Add.Location = new System.Drawing.Point(591, 575);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(115, 44);
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
            this.label5.Location = new System.Drawing.Point(536, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Prénom : ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(556, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nom : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(550, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Login : ";
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 736);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1443, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // connectedAs
            // 
            this.connectedAs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.connectedAs.AutoSize = true;
            this.connectedAs.BackColor = System.Drawing.Color.MistyRose;
            this.connectedAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedAs.ForeColor = System.Drawing.Color.OliveDrab;
            this.connectedAs.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.connectedAs.Location = new System.Drawing.Point(777, 44);
            this.connectedAs.Margin = new System.Windows.Forms.Padding(2, 2, 8, 0);
            this.connectedAs.Name = "connectedAs";
            this.connectedAs.Size = new System.Drawing.Size(57, 20);
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
            this.label2.Location = new System.Drawing.Point(590, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
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
            this.Disconnect.Location = new System.Drawing.Point(643, 85);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(102, 20);
            this.Disconnect.TabIndex = 16;
            this.Disconnect.TabStop = true;
            this.Disconnect.Text = "Deconnexion";
            this.Disconnect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Disconnect_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1312, 5);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(119, 119);
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
            this.pictureBox4.Size = new System.Drawing.Size(1443, 132);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 777);
            this.Controls.Add(this.headerPanel);
            this.Name = "addUser";
            this.Text = "addUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddUser_FormClosing);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.listAddedMedic.ResumeLayout(false);
            this.listAddedMedic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label listLimitTB;
        public System.Windows.Forms.Button Validation;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel listAddedMedic;
        private System.Windows.Forms.ListBox LBAddedUser;
        private System.Windows.Forms.Label BeginAddUser;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label connectedAs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel Disconnect;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label notAllCompletedError;
        private System.Windows.Forms.RadioButton noAdmin;
        private System.Windows.Forms.RadioButton yesAdmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox prenomTB;
        private System.Windows.Forms.TextBox nomTB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Label noUserError;
    }
}