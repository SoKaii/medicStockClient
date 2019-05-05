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
    public partial class addMedicament : Form
    {
        Ihm ihm;
        Utilisateur userConnected;
        int i = 0;
        List<TextBox> listTB = new List<TextBox>();
        List<String> addedMedicStringList = new List<String>();
        List<String> addedMedicToLB = new List<String>();
        public addMedicament(Ihm p_ihm, Utilisateur p_userConnected)
        {
            ihm = p_ihm;
            userConnected = p_userConnected;
            InitializeComponent();
            connectedAs.Text = userConnected.getPrenom() + " " + userConnected.getNom().ToUpper();
            listTB.Add(eanTB);
            listTB.Add(nomTB);
            listTB.Add(formeTB);
            listTB.Add(dosageTB);
            listTB.Add(categorieTB);
            listTB.Add(substanceTB);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            noMedicError.Visible = false;
            notAllCompletedError.Visible = false;
            listLimitTB.Visible = false;

            foreach (TextBox tb in listTB)
            {
                if (tb.Text == null || tb.Text == "")
                    notAllCompletedError.Visible = true;
            }

            if (i == 8)
                listLimitTB.Visible = true;
            else if (notAllCompletedError.Visible == false)
            {
                BeginAddUser.Visible = false;
                addedMedicToLB.Add(nomTB.Text.ToUpper() + " " + dosageTB.Text + "mg en " + formeTB.Text);
                addedMedicStringList.Add(eanTB.Text.ToString());
                addedMedicStringList.Add(nomTB.Text.ToString());
                addedMedicStringList.Add(formeTB.Text.ToString());
                addedMedicStringList.Add(dosageTB.Text.ToString());
                addedMedicStringList.Add(categorieTB.Text.ToString());
                addedMedicStringList.Add(substanceTB.Text.ToString());
                LBAddedUser.Items.Add(addedMedicToLB[i]);

                eanTB.ResetText();
                nomTB.ResetText();
                formeTB.ResetText();
                dosageTB.ResetText();
                categorieTB.ResetText();
                substanceTB.ResetText();

                i++;
            }
        }
    }
}
