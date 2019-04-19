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
    public partial class addUser : Form
    {
        Ihm ihm;
        Utilisateur userConnected;
        int i = 0;
        List<TextBox> listTB = new List<TextBox>();
        List<String> addedUserStringList = new List<String>();
        List<String> addedUserToLB = new List<String>();
        public addUser(Ihm p_ihm, Utilisateur p_userConnected)
        {
            ihm = p_ihm;
            userConnected = p_userConnected;
            InitializeComponent();
            connectedAs.Text = userConnected.getPrenom() + " " + userConnected.getNom().ToUpper();

            listTB.Add(loginTB);
            listTB.Add(nomTB);
            listTB.Add(prenomTB);
            listTB.Add(passwordTB);
        }

        private void Disconnect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ihm.sendCommands();
            Authentification auth = new Authentification();
            auth.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mainMenu mm = new mainMenu(ihm, userConnected.getLogin());
            this.Hide();
            mm.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            noUserError.Visible = false;
            notAllCompletedError.Visible = false;
            listLimitTB.Visible = false; 

            if (yesAdmin.Checked == false && noAdmin.Checked == false)
               notAllCompletedError.Visible = true;
            foreach(TextBox tb in listTB)
            {
                if (tb.Text == null)
                    notAllCompletedError.Visible = true;
            }

            if (i == 8)
                listLimitTB.Visible = true;
            else if (notAllCompletedError.Visible == false)
            {

                string isAdmin = null;

                if (yesAdmin.Checked == true)
                    isAdmin = "1";
                else
                    isAdmin = "0";

                BeginAddUser.Visible = false;
                addedUserToLB.Add(loginTB.Text.ToUpper() + " : " + prenomTB.Text + " " + nomTB.Text.ToUpper());
                addedUserStringList.Add(loginTB.ToString());
                addedUserStringList.Add(prenomTB.ToString());
                addedUserStringList.Add(nomTB.ToString());
                addedUserStringList.Add(isAdmin);
                addedUserStringList.Add(passwordTB.ToString());
                LBAddedUser.Items.Add(addedUserToLB[i]);
                loginTB.ResetText();
                nomTB.ResetText();
                prenomTB.ResetText();
                yesAdmin.Checked = false;
                noAdmin.Checked = false;
                passwordTB.ResetText();
                i++;
            }
        }

        private void Validate_Click(object sender, EventArgs e)
        {
            if (addedUserStringList.Count == 0)
                noUserError.Visible = true;
            else
            {
                for (int i = 0; i < addedUserStringList.Count / 5; i = i+5)
                {
                    ihm.addCommandNewUser(addedUserStringList[i], addedUserStringList[i + 1], addedUserStringList[i + 2], addedUserStringList[i + 3], addedUserStringList[i + 4]);
                }
                recapAddUser recap = new recapAddUser(ihm, userConnected, addedUserToLB);
                recap.Show();
                this.Hide();
            }
        }
    }
}
