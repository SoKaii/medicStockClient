using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicStockClient
{
    class lotMedicament
    {
        String numeroLot;
        int nombreBoite;
        String dateConditionement;
        String localisation;
        int elevation;
        String mailFournisseurPrioritaire;
        int seuilMin;
        int quantiteCommandeAuto;
        bool commandeAuto;
        long numeroEan;

        public lotMedicament()
        {
            numeroLot = null;
            nombreBoite = 0;
            dateConditionement = null;
            localisation = null;
            elevation = 0;
            mailFournisseurPrioritaire = null;
            seuilMin = 0;
            quantiteCommandeAuto = ;
            commandeAuto = false;
            numeroEan = 0;
        }

        public String getNumeroLot()
        { return numeroLot; }

        public int getNombreBoite()
        { return nombreBoite; }

        public String getDateConditionnement()
        { return dateConditionement; }

        public String getLocalisation()
        { return localisation; }

        public int getElevation()
        { return elevation; }

        public String getMailFournisseurPrioritaire()
        { return mailFournisseurPrioritaire; }

        public int getSeuilMin()
        { return seuilMin; }

        public int getQuantiteCommandeAuto()
        { return quantiteCommandeAuto; }

        public bool getCommandeAuto()
        { return commandeAuto; }

        public long getNumeroEan()
        { return numeroEan; }
    }
}
