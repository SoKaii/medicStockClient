using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicStockClient
{
    class Medicament
    {
        long numeroEan;
        String nom;
        String categorie;
        String substanceActive;
        String formeGalenique;
        int dosage;

        public Medicament()
        {
            numeroEan = 0;
            nom = null;
            categorie = null;
            substanceActive = null;
            formeGalenique = null;
            dosage = 0;
        }

        public Medicament(long p_numeroEan, String p_nom, String p_categorie, String p_substanceActive, String p_formeGalenique, int p_dosage)
        {
            numeroEan = p_numeroEan;
            nom = p_nom;
            categorie = p_categorie;
            substanceActive = p_substanceActive;
            formeGalenique = p_formeGalenique;
            dosage = p_dosage;
        }

        public long getNumeroEan()
        { return numeroEan; }

        public String getNom()
        { return nom; }

        public String getCategorie()
        { return categorie; }

        public String getSubstanceActive()
        { return substanceActive; }

        public String getFormeGalenique()
        { return formeGalenique; }

        public int getDosage()
        { return dosage; }


    }

}
