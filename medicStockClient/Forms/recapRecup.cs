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
    public partial class recapRecup : Form
    {
        Ihm ihm;
        Utilisateur userConnected;
        List<String> addedMedic = new List<String>();
        List<Medicament> addedFullMedic = new List<Medicament>();
        List<ListBox> listLB = new List<ListBox>();

        public recapRecup(Ihm p_ihm, Utilisateur p_userConnected, List<String> p_addedMedic, List<Medicament> p_addedFullMedic)
        {
            ihm = p_ihm;
            userConnected = p_userConnected;
            addedMedic = p_addedMedic;
            addedFullMedic = p_addedFullMedic;
            InitializeComponent();

            listLB.Add(listBox1);
            listLB.Add(listBox2);
            listLB.Add(listBox3);
            listLB.Add(listBox4);
            listLB.Add(listBox5);
            listLB.Add(listBox6);
            listLB.Add(listBox7);
            listLB.Add(listBox8);
           

            for (int i = 0; i < addedFullMedic.Count; i++)
            {
                listLB[i].Visible = true;
                listLB[i].Items.Add(addedFullMedic[i].getNom());
                listLB[i].Items.Add(addedFullMedic[i].getDosage() + "mg");
                listLB[i].Items.Add(addedFullMedic[i].getFormeGalenique());
                listLB[i].Items.Add(" ");
                listLB[i].Items.Add("Localisation : " + ihm.getLotMedic(addedFullMedic[i].getNumeroEan()).getLocalisation());
                listLB[i].Items.Add("Elevation : " + ihm.getLotMedic(addedFullMedic[i].getNumeroEan()).getElevation());
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

        private void recapRecup_FormClosing(object sender, FormClosingEventArgs e)
        {
            ihm.sendCommands();
            Application.Exit();
        }
    }
}
