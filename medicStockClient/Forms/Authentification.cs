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
    public partial class Authentification : Form
    {
        Ihm ihm;
        public Authentification()
        {
            ihm = new Ihm();
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            invalidAuth.Visible = false;
            errorRecup.Visible = false;

            if (ihm.getAuthentification(login.Text.Trim(), password.Text.Trim()) == 0)
                invalidAuth.Visible = true;
            else if (ihm.getAuthentification(login.Text, password.Text) == 1)
            {
                mainMenu mainMenu = new mainMenu(ihm, login.Text);
                mainMenu.Show();
                this.Hide();
            }
            else if (ihm.getAuthentification(login.Text, password.Text) == 2)
            {
                mainMenu mainMenu = new mainMenu(ihm, login.Text);
                mainMenu.Show();
                this.Hide();
            }
            else
                errorRecup.Visible = true;
            
        }

        private void Authentification_FormClosing(object sender, FormClosingEventArgs e)
        {
            ihm.closeConnection();
            Environment.Exit(0);
        }
    }
}
