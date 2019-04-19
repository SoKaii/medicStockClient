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
    public partial class recupMedicament : Form
    {
        Ihm ihm;
        Utilisateur userConnected;
        List<String> addedMedicString = new List<String>();
        List<Medicament> addedMedic = new List<Medicament>();
        List<int> quantityAdded = new List<int>();
        int i = 0;
        public recupMedicament(Ihm p_ihm, Utilisateur p_userConnected)
        {
            ihm = p_ihm;
            userConnected = p_userConnected;
            InitializeComponent();
            connectedAs.Text = userConnected.getPrenom() + " " + userConnected.getNom().ToUpper();
            foreach(String str in ihm.configChoiceMedic())
            {
                nameMedicList.Items.Add(str);
            }
        }

        private void Disconnect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ihm.sendCommands();
            Authentification auth = new Authentification();
            auth.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualStockTitle.Visible = false;
            actualStock.Visible = false;
            alreadyChoosed.Visible = false;
            formeMedicList.Items.Clear();
            formeMedicList.ResetText();
            dosageMedicList.Items.Clear();
            dosageMedicList.ResetText();
            configureFormeList(nameMedicList.SelectedItem.ToString());
        }

        private void configureFormeList(String p_nameMedic)
        {
            foreach (String str in ihm.configChoiceMedic(p_nameMedic))
            {
                formeMedicList.Items.Add(str);
            }
        }
        private void formeMedicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualStockTitle.Visible = false;
            actualStock.Visible = false;
            alreadyChoosed.Visible = false;

            dosageMedicList.Items.Clear();
            dosageMedicList.ResetText();
            configureDosageList(nameMedicList.SelectedItem.ToString(), formeMedicList.SelectedItem.ToString());
        }
        private void configureDosageList(String p_nameMedic,String p_formeMedic)
        {
            foreach (String str in ihm.configChoiceMedic(p_nameMedic,p_formeMedic))
            {
                dosageMedicList.Items.Add(str);
            }
        }

        private void dosageMedicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Medicament tempMedic = ihm.getMedic(nameMedicList.Text, formeMedicList.Text, Int32.Parse(dosageMedicList.Text));
            actualStock.Text = ihm.getActualStock(tempMedic.getNumeroEan()).ToString();
            actualStockTitle.Visible = true;
            actualStock.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mainMenu mm = new mainMenu(ihm, userConnected.getLogin());
            this.Hide();
            mm.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            noMedicError.Visible = false;
            quantityError.Visible = false;
            listLimitTB.Visible = false;
            stockReached.Visible = false;
            alreadyChoosed.Visible = false;

            
            if (dosageMedicList.SelectedIndex == -1)
                noMedicError.Visible = true;
            if (quantityMedic.Text == "" || quantityMedic.Text == "0")
                quantityError.Visible = true;
            else if (Int32.Parse(quantityMedic.Text) > Int32.Parse(actualStock.Text))
                stockReached.Visible = true;

            foreach (Medicament medic in addedMedic)
            {
                if (ihm.getMedic(nameMedicList.Text, formeMedicList.Text, Int32.Parse(dosageMedicList.Text)) == medic)
                {
                    alreadyChoosed.Visible = true;
                    noMedicError.Visible = false;
                    quantityError.Visible = false;
                    listLimitTB.Visible = false;
                    stockReached.Visible = false;
                }
                }

            if (i == 8)
                listLimitTB.Visible = true;
            else if (dosageMedicList.SelectedIndex != -1 && quantityMedic.Text != "" && quantityMedic.Text != "0" && stockReached.Visible == false && alreadyChoosed.Visible == false)
            {
                actualStockTitle.Visible = false;
                actualStock.Visible = false;
                BeginAddMedic.Visible = false;
                addedMedicString.Add(quantityMedic.Text + " " + nameMedicList.Text + " " + dosageMedicList.Text + "mg en " + formeMedicList.Text);
                addedMedic.Add(ihm.getMedic(nameMedicList.Text, formeMedicList.Text, Int32.Parse(dosageMedicList.Text)));
                LBAddedMedic.Items.Add(addedMedicString[i]);
                quantityAdded.Add(Int32.Parse(quantityMedic.Text));
                nameMedicList.ResetText();
                formeMedicList.ResetText();
                dosageMedicList.ResetText();
                quantityMedic.Value = 0;
                quantityMedic.ResetText();
                i++;
            }

        }

        private void Validate_Click(object sender, EventArgs e)
        {
            string id = null;
            if (addedMedicString.Count == 0)
                noMedicError.Visible = true;
            else
            {
                for (int i = 0; i < addedMedic.Count; i++ )
                {
                    int quantity = quantityAdded[i] - 2 * quantityAdded[i];
                    id = DateTime.Now.ToString("ddMMyyyyHHmmss") + userConnected.getLogin() + addedMedic[i].getNumeroEan().ToString();
                    ihm.addCommand(id,"1",DateTime.Now.ToString("yyyy-MM-dd"), quantity.ToString(), 
                        addedMedic[i].getNumeroEan().ToString(), userConnected.getLogin().ToString(), ihm.getLotMedic(addedMedic[i].getNumeroEan()).getNumeroLot());
                    if (ihm.getLotMedic(addedMedic[i].getNumeroEan()).getCommandeAuto() == true)
                    {
                        if (ihm.getLotMedic(addedMedic[i].getNumeroEan()).getNombreBoite() <= ihm.getLotMedic(addedMedic[i].getNumeroEan()).getSeuilMin())
                        {
                            ihm.sendOrderMail(ihm.getLotMedic(addedMedic[i].getNumeroEan()).getNumeroEan());
                        }
                    }
                }

                recapRecup recap = new recapRecup(ihm, userConnected, addedMedicString, addedMedic);
                recap.Show();
                this.Hide();
            }
        }
        private void recupMedicament_FormClosing(object sender, FormClosingEventArgs e)
        {
            ihm.sendCommands();
            ihm.closeConnection();
            Application.Exit();
        }

      
    }
}
