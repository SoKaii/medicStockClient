namespace medicStockClient
{
    partial class Authentification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentification));
            this.loginLabel = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.invalidAuth = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorRecup = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(206, 106);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(90, 13);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Nom d\'utilisateur :";
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.Location = new System.Drawing.Point(208, 122);
            this.login.Margin = new System.Windows.Forms.Padding(2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(169, 20);
            this.login.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(208, 162);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Mot de Passe :";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.Location = new System.Drawing.Point(208, 179);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(169, 20);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            // 
            // connect
            // 
            this.connect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connect.Location = new System.Drawing.Point(236, 244);
            this.connect.Margin = new System.Windows.Forms.Padding(2);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(117, 36);
            this.connect.TabIndex = 5;
            this.connect.Text = "Connexion";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // invalidAuth
            // 
            this.invalidAuth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.invalidAuth.AutoSize = true;
            this.invalidAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidAuth.ForeColor = System.Drawing.Color.Red;
            this.invalidAuth.Location = new System.Drawing.Point(206, 218);
            this.invalidAuth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.invalidAuth.Name = "invalidAuth";
            this.invalidAuth.Size = new System.Drawing.Size(205, 15);
            this.invalidAuth.TabIndex = 6;
            this.invalidAuth.Text = "Identifiant ou Mot de Passe incorrect";
            this.invalidAuth.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::medicStockClient.Properties.Resources.medicStock;
            this.pictureBox1.Location = new System.Drawing.Point(444, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // errorRecup
            // 
            this.errorRecup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorRecup.AutoSize = true;
            this.errorRecup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorRecup.ForeColor = System.Drawing.Color.Red;
            this.errorRecup.Location = new System.Drawing.Point(181, 218);
            this.errorRecup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorRecup.Name = "errorRecup";
            this.errorRecup.Size = new System.Drawing.Size(230, 15);
            this.errorRecup.TabIndex = 8;
            this.errorRecup.Text = "Impossible de récupérer les informations";
            this.errorRecup.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(224, 332);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Copyright (C) 2018 AGINFOS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 309);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(600, 57);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Authentification
            // 
            this.AcceptButton = this.connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.errorRecup);
            this.Controls.Add(this.invalidAuth);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.login);
            this.Controls.Add(this.loginLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Authentification";
            this.Text = "Authentification";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authentification_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label invalidAuth;
        private System.Windows.Forms.Label errorRecup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}