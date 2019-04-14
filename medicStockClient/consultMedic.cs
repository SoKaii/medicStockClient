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
                nameMedicList.Items.Add(str);
            }
        }
        private void nameMedicList_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            dosageMedicList.Items.Clear();
            dosageMedicList.ResetText();
            configureDosageList(nameMedicList.SelectedItem.ToString(), formeMedicList.SelectedItem.ToString());
        }
        private void configureDosageList(String p_nameMedic, String p_formeMedic)
        {
            foreach (String str in ihm.configChoiceMedic(p_nameMedic, p_formeMedic))
            {
                dosageMedicList.Items.Add(str);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            noMedicError.Visible = false;
            listLimitTB.Visible = false;

            if (dosageMedicList.SelectedIndex == -1)
                noMedicError.Visible = true;
            if (i == 8)
                listLimitTB.Visible = true;
            else if (dosageMedicList.SelectedIndex != -1)
            {
                BeginAddMedic.Visible = false;
                addedMedicString.Add(nameMedicList.Text + " " + dosageMedicList.Text + "mg en " + formeMedicList.Text);
                addedMedic.Add(ihm.getMedic(nameMedicList.Text, formeMedicList.Text, Int32.Parse(dosageMedicList.Text)));
                LBAddedMedic.Items.Add(addedMedicString[i]);
                nameMedicList.ResetText();
                formeMedicList.ResetText();
                dosageMedicList.ResetText();
                i++;
            }
        }
    }
}
