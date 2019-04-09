using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicStockClient
{
    public partial class mainMenu : Form
    {
        Ihm ihm;
        Utilisateur userConnected;
        public mainMenu(Ihm p_ihm, String p_login)
        {
            ihm = p_ihm;
            userConnected = ihm.getUtilisateur(p_login);
            InitializeComponent();
            connectedAs.Text = userConnected.getPrenom() + " " + userConnected.getNom().ToUpper();
            if (userConnected.getadministrateur() == true)
            {
                buttonAddMedic.Visible = true;
                buttonAddUser.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void mainMenu_Load(object sender, EventArgs e)
        {

        }

        private void connectedAs_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Authentification auth = new Authentification();
            auth.Show();
            this.Hide();
        }

        private void buttonRecupMedic_Click(object sender, EventArgs e)
        {
            recupMedicament recup = new recupMedicament(ihm, userConnected);
            recup.Show();
            this.Hide();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonConsultMedic_Click(object sender, EventArgs e)
        {

        }
    }
}
