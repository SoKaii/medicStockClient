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
    public partial class verifPeremption : Form
    {
        Ihm ihm;
        Utilisateur userConnected;
        public verifPeremption(Ihm p_ihm, Utilisateur p_userConnected)
        {
            ihm = p_ihm;
            userConnected = p_userConnected;
            InitializeComponent();

            foreach(lotMedicament lm in ihm.verifPeremption())
            {
                medicPerimedLB.Items.Add(ihm.getMedic(lm.getNumeroEan()).getNom() + " " + ihm.getMedic(lm.getNumeroEan()).getDosage() + "mg en " + ihm.getMedic(lm.getNumeroEan()).getFormeGalenique() + " situé en " + lm.getLocalisation() + "," + lm.getElevation());
            }
            connectedAs.Text = userConnected.getPrenom() + " " + userConnected.getNom().ToUpper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainMenu mm = new mainMenu(ihm, userConnected.getLogin());
            this.Hide();
            mm.Show();
        }

        private void Disconnect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ihm.sendCommands();
            Authentification auth = new Authentification();
            auth.Show();
            this.Hide();
        }
        private void verifPeremption_FormClosing(object sender, FormClosingEventArgs e)
        {
            ihm.sendCommands();
            Application.Exit();
        }

    }
}
