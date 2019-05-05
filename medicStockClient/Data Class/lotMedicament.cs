using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicStockClient
{
    public class lotMedicament
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
        String datePeremption;

        public lotMedicament()
        {
            numeroLot = null;
            nombreBoite = 0;
            dateConditionement = null;
            localisation = null;
            elevation = 0;
            mailFournisseurPrioritaire = null;
            seuilMin = 0;
            quantiteCommandeAuto = 0;
            commandeAuto = false;
            numeroEan = 0;
            datePeremption = null;
        }

        public lotMedicament(String p_numeroLot, int p_nombreBoite, String p_dateConditionnement, String p_localisation, int p_elevation, String p_mailFournisseurPrioritaire, int p_seuilMin, int p_quantiteCommandeAuto, bool p_commandeAuto,long p_numeroEan,String p_datePeremption)
        {
            numeroLot = p_numeroLot;
            nombreBoite = p_nombreBoite;
            dateConditionement = p_dateConditionnement;
            localisation = p_localisation;
            elevation = p_elevation;
            mailFournisseurPrioritaire = p_mailFournisseurPrioritaire;
            seuilMin = p_seuilMin;
            quantiteCommandeAuto = p_quantiteCommandeAuto;
            commandeAuto = p_commandeAuto;
            numeroEan = p_numeroEan;
            datePeremption = p_datePeremption;
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

        public String getDatePeremption()
        { return datePeremption; }
    }
}
