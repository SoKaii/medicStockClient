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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ihm.sendCommands();
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

        private void buttonConsultMedic_Click(object sender, EventArgs e)
        {
            consultMedic consult = new consultMedic(ihm, userConnected);
            consult.Show();
            this.Hide();
        }
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            addUser addUser = new addUser(ihm, userConnected);
            addUser.Show();
            this.Hide();
        }

        private void mainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            ihm.sendCommands();
            ihm.closeConnection();
            Application.Exit();
        }

        private void ButtonAddMedic_Click(object sender, EventArgs e)
        {
            addMedicament addMedic = new addMedicament(ihm, userConnected);
            addMedic.Show();
            this.Hide();
        }

        /* private void VerifPeremptionBt_Click(object sender, EventArgs e)
        {
            verifPeremption verifPeremption = new verifPeremption(ihm, userConnected);
            verifPeremption.Show();
            this.Hide();
        } */
    }
}
