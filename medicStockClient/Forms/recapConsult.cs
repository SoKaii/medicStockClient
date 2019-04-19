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
    public partial class recapConsult : Form
    {
        Ihm ihm;
        Utilisateur userConnected;
        List<String> addedMedic = new List<String>();
        List<Medicament> addedFullMedic = new List<Medicament>();
        List<ListBox> listLB = new List<ListBox>();

        public recapConsult(Ihm p_ihm, Utilisateur p_userConnected, List<String> p_addedMedic, List<Medicament> p_addedFullMedic)
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
                listLB[i].Items.Add("EAN : " + addedFullMedic[i].getNumeroEan());
                listLB[i].Items.Add("Nom : " + addedFullMedic[i].getNom());
                listLB[i].Items.Add(" ");
                listLB[i].Items.Add("Substance Active : " + addedFullMedic[i].getSubstanceActive());
                listLB[i].Items.Add("Dosage : " + addedFullMedic[i].getDosage() + "mg");
                listLB[i].Items.Add("Catégorie : " + addedFullMedic[i].getCategorie());
                listLB[i].Items.Add("Forme : " + addedFullMedic[i].getFormeGalenique());
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
        
        private void recapConsult_FormClosing(object sender, FormClosingEventArgs e)
        {
            ihm.sendCommands();
            ihm.closeConnection();
            Application.Exit();
        }
    }
}
