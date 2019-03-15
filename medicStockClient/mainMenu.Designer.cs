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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRecupMedic
            // 
            this.buttonRecupMedic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRecupMedic.Location = new System.Drawing.Point(285, 41);
            this.buttonRecupMedic.Name = "buttonRecupMedic";
            this.buttonRecupMedic.Size = new System.Drawing.Size(206, 53);
            this.buttonRecupMedic.TabIndex = 0;
            this.buttonRecupMedic.Text = "Récupération médicament";
            this.buttonRecupMedic.UseVisualStyleBackColor = true;
            // 
            // buttonConsultMedic
            // 
            this.buttonConsultMedic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConsultMedic.Location = new System.Drawing.Point(285, 122);
            this.buttonConsultMedic.Name = "buttonConsultMedic";
            this.buttonConsultMedic.Size = new System.Drawing.Size(206, 53);
            this.buttonConsultMedic.TabIndex = 1;
            this.buttonConsultMedic.Text = "Consultation médicament";
            this.buttonConsultMedic.UseVisualStyleBackColor = true;
            // 
            // buttonAddMedic
            // 
            this.buttonAddMedic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddMedic.Location = new System.Drawing.Point(285, 201);
            this.buttonAddMedic.Name = "buttonAddMedic";
            this.buttonAddMedic.Size = new System.Drawing.Size(206, 53);
            this.buttonAddMedic.TabIndex = 2;
            this.buttonAddMedic.Text = "Ajout médicament";
            this.buttonAddMedic.UseVisualStyleBackColor = true;
            this.buttonAddMedic.Visible = false;
            this.buttonAddMedic.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddUser.Location = new System.Drawing.Point(285, 277);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(206, 53);
            this.buttonAddUser.TabIndex = 3;
            this.buttonAddUser.Text = "Ajout utilisateur";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Visible = false;
            this.buttonAddUser.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 380);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 70);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(299, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Copyright (C) 2018 AGINFOS";
            // 
            // connectedLabel
            // 
            this.connectedLabel.AutoSize = true;
            this.connectedLabel.Location = new System.Drawing.Point(600, 13);
            this.connectedLabel.Name = "connectedLabel";
            this.connectedLabel.Size = new System.Drawing.Size(150, 17);
            this.connectedLabel.TabIndex = 6;
            this.connectedLabel.Text = "You\'re connected as : ";
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.connectedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.buttonAddMedic);
            this.Controls.Add(this.buttonConsultMedic);
            this.Controls.Add(this.buttonRecupMedic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainMenu";
            this.Text = "mainMenu";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRecupMedic;
        private System.Windows.Forms.Button buttonConsultMedic;
        private System.Windows.Forms.Button buttonAddMedic;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label connectedLabel;
    }
}