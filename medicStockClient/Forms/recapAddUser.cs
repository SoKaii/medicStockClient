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
    public partial class recapAddUser : Form
    {
        Ihm ihm;
        Utilisateur userConnected;
        public recapAddUser(Ihm p_ihm, Utilisateur p_userConnected,List<String> p_listUserAdded)
        {
            ihm = p_ihm;
            userConnected = p_userConnected;
            InitializeComponent();
            connectedAs.Text = userConnected.getPrenom() + " " + userConnected.getNom().ToUpper();

            recapAddedUser.Items.Add("Les utilisateurs suivants ont été ajoutés :");
            foreach (String str in p_listUserAdded)
            {
                recapAddedUser.Items.Add(str);
            }
            InitializeComponent();
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

        private void recapAddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            ihm.sendCommands();
            ihm.closeConnection();
            Application.Exit();
        }
    }
}
