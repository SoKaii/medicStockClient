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
    public partial class consultMedic : Form
    {
        Ihm ihm;
        Utilisateur userConnected;
        List<String> addedMedicString = new List<String>();
        List<Medicament> addedMedic = new List<Medicament>();
        int i = 0;
        public consultMedic(Ihm p_ihm, Utilisateur p_userConnected)
        {
            ihm = p_ihm;
            userConnected = p_userConnected;
            InitializeComponent();
            connectedAs.Text = userConnected.getPrenom() + " " + userConnected.getNom().ToUpper();
            foreach (String str in ihm.configChoiceMedic())
            {
                this.nameMedicList.Items.Add(str);
            }
        }

        private void Disconnect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ihm.sendCommands();
            Authentification auth = new Authentification();
            auth.Show();
            this.Hide();
        }

        private void nameMedicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.formeMedicList.Items.Clear();
            this.formeMedicList.ResetText();
            this.dosageMedicList.Items.Clear();
            this.dosageMedicList.ResetText();
            this.configureFormeList(nameMedicList.SelectedItem.ToString());
        }

        private void configureFormeList(String p_nameMedic)
        {
            foreach (String str in ihm.configChoiceMedic(p_nameMedic))
            {
                this.formeMedicList.Items.Add(str);
            }
        }
        private void formeMedicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dosageMedicList.Items.Clear();
            this.dosageMedicList.ResetText();
            this.configureDosageList(nameMedicList.SelectedItem.ToString(), formeMedicList.SelectedItem.ToString());
        }
        private void configureDosageList(String p_nameMedic, String p_formeMedic)
        {
            foreach (String str in ihm.configChoiceMedic(p_nameMedic, p_formeMedic))
            {
                this.dosageMedicList.Items.Add(str);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mainMenu mm = new mainMenu(ihm, userConnected.getLogin());
            this.Hide();
            mm.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.noMedicError.Visible = false;
            this.listLimitTB.Visible = false;

            if (dosageMedicList.SelectedIndex == -1)
                this.noMedicError.Visible = true;
            if (i == 8)
                this.listLimitTB.Visible = true;
            else if (dosageMedicList.SelectedIndex != -1 )
            {
                this.BeginAddMedic.Visible = false;
                this.addedMedicString.Add(nameMedicList.Text + " " + dosageMedicList.Text + "mg en " + formeMedicList.Text);
                this.addedMedic.Add(ihm.getMedic(nameMedicList.Text, formeMedicList.Text, Int32.Parse(dosageMedicList.Text)));
                this.LBAddedMedic.Items.Add(addedMedicString[i]);
                this.nameMedicList.ResetText();
                this.formeMedicList.ResetText();
                this.dosageMedicList.ResetText();
                i++;
            }

        }
        private void Validate_Click(object sender, EventArgs e)
        {
            string id = null;
            if (addedMedicString.Count == 0)
                this.noMedicError.Visible = true;
            else
            {
                for (int i = 0; i < addedMedic.Count; i++)
                {
                    id = DateTime.Now.ToString("ddMMyyyyHHmmss") + userConnected.getLogin() + addedMedic[i].getNumeroEan().ToString();
                    ihm.addCommand(id, "2", DateTime.Now.ToString("yyyy-MM-dd"), "0", addedMedic[i].getNumeroEan().ToString(),
                        userConnected.getLogin().ToString(), ihm.getLotMedic(addedMedic[i].getNumeroEan()).getNumeroLot());
                }
                recapConsult recap = new recapConsult(ihm, userConnected, addedMedicString, addedMedic);
                recap.Show();
                this.Hide();
            }
        }

        private void consultMedic_FormClosing(object sender, FormClosingEventArgs e)
        {
            ihm.sendCommands();
            ihm.closeConnection();
            Environment.Exit(0);
        }
    }
}
