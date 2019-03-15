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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorRecup = new System.Windows.Forms.Label();
            this.normalUser = new System.Windows.Forms.Label();
            this.adminUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(275, 130);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(121, 17);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Nom d\'utilisateur :";
            this.loginLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.Location = new System.Drawing.Point(278, 150);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(224, 22);
            this.login.TabIndex = 1;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(278, 200);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(102, 17);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Mot de Passe :";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.Location = new System.Drawing.Point(278, 220);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(224, 22);
            this.password.TabIndex = 3;
            // 
            // connect
            // 
            this.connect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connect.Location = new System.Drawing.Point(315, 300);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(156, 44);
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
            this.invalidAuth.Location = new System.Drawing.Point(275, 268);
            this.invalidAuth.Name = "invalidAuth";
            this.invalidAuth.Size = new System.Drawing.Size(248, 18);
            this.invalidAuth.TabIndex = 6;
            this.invalidAuth.Text = "Identifiant ou Mot de Passe incorrect";
            this.invalidAuth.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::medicStockClient.Properties.Resources.medicStock;
            this.pictureBox1.Location = new System.Drawing.Point(592, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(-19, 409);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(822, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // errorRecup
            // 
            this.errorRecup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorRecup.AutoSize = true;
            this.errorRecup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorRecup.ForeColor = System.Drawing.Color.Red;
            this.errorRecup.Location = new System.Drawing.Point(275, 268);
            this.errorRecup.Name = "errorRecup";
            this.errorRecup.Size = new System.Drawing.Size(275, 18);
            this.errorRecup.TabIndex = 8;
            this.errorRecup.Text = "Impossible de récupérer les informations";
            this.errorRecup.Visible = false;
            this.errorRecup.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // normalUser
            // 
            this.normalUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.normalUser.AutoSize = true;
            this.normalUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalUser.ForeColor = System.Drawing.Color.Red;
            this.normalUser.Location = new System.Drawing.Point(141, 300);
            this.normalUser.Name = "normalUser";
            this.normalUser.Size = new System.Drawing.Size(153, 18);
            this.normalUser.TabIndex = 9;
            this.normalUser.Text = "Normal User detected";
            this.normalUser.Visible = false;
            // 
            // adminUser
            // 
            this.adminUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adminUser.AutoSize = true;
            this.adminUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminUser.ForeColor = System.Drawing.Color.Red;
            this.adminUser.Location = new System.Drawing.Point(141, 326);
            this.adminUser.Name = "adminUser";
            this.adminUser.Size = new System.Drawing.Size(145, 18);
            this.adminUser.TabIndex = 10;
            this.adminUser.Text = "Admin User detected";
            this.adminUser.Visible = false;
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminUser);
            this.Controls.Add(this.normalUser);
            this.Controls.Add(this.errorRecup);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.invalidAuth);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.login);
            this.Controls.Add(this.loginLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authentification";
            this.Text = "Authentification";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Authentification_Load);
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label errorRecup;
        private System.Windows.Forms.Label normalUser;
        private System.Windows.Forms.Label adminUser;
    }
}