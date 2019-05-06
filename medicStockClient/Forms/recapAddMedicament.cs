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
    public partial class recapAddMedicament : Form
    {
        Ihm ihm;
        Utilisateur userConnected;
        public recapAddMedicament(Ihm p_ihm, Utilisateur p_userConnected, List<String> p_listMedicAdded)
        {
            ihm = p_ihm;
            userConnected = p_userConnected;
            InitializeComponent();
            connectedAs.Text = userConnected.getPrenom() + " " + userConnected.getNom().ToUpper();

            recapAddedMedicament.Items.Add("Les médicaments suivants ont été ajoutés :");
            foreach (String str in p_listMedicAdded)
            {
                recapAddedMedicament.Items.Add(str);
            }
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

        private void RecapAddMedicament_FormClosing(object sender, FormClosingEventArgs e)
        {
            ihm.sendCommands();
            ihm.closeConnection();
            Environment.Exit(0);
        }
    }
}
