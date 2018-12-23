using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicStockClient
{
    class Medicament
    {
        int codeMedic;
        string nom;
        string categorie;
        string substance;
        string formeGalenique;
        int dosage;
        DateTime datePeremption;
        int numeroLot;
        int stock;
        string position;
        int elevation;

        public Medicament()
        {
            codeMedic = 0;
            nom = null;
            categorie = null;
            substance = null;
            formeGalenique = null;
            dosage = 0;
            datePeremption = new DateTime(0, 0, 0, 0, 0, 0);
            numeroLot = 0;
            stock = 0;
            position = null;
            elevation = 0;
        }

        public Medicament(int p_codeMedic, string p_nom, string p_categorie, string p_substance, string p_formeGalenique, int p_dosage, DateTime p_datePeremption, int p_numeroLot, int p_stock, string p_position, int p_elevation)
        {
            codeMedic = p_codeMedic;
            nom = p_nom;
            categorie = p_categorie;
            substance = p_substance;
            formeGalenique = p_formeGalenique;
            dosage = p_dosage;
            datePeremption = p_datePeremption;
            numeroLot = p_numeroLot;
            stock = p_stock;
            position = p_position;
            elevation = p_elevation;
        }

        public int getCodeMedic()
        { return codeMedic; }

        public string getNom()
        { return nom; }
        
        public string getCategorie()
        { return categorie; }

        public string getSubstance()
        { return substance; }

        public string getFormeGalenique()
        { return formeGalenique; }

        public int getDosage()
        { return dosage; }

        public DateTime getDatePeremption()
        { return datePeremption; }

        public int getNumeroLot()
        { return numeroLot; }

        public int getStock()
        { return stock; }

        public string getPosition()
        { return position; }

        public int getElevation()
        { return elevation; }
    }

}
