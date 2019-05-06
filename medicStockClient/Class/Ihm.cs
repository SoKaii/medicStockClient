using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicStockClient
{
    public class Ihm
    {
        Metier metier;
        public Ihm()
        {
            metier = new Metier();
        }

        public int getAuthentification(String p_login, String p_password)
        {
            return metier.Authentification(p_login, p_password);
        }

        public Utilisateur getUtilisateur(String p_login)
        {
            return metier.getUser(p_login);
        }

        public List<String> configChoiceMedic()
        {
            return metier.configureChoiceMedic();
        }
        public List<String> configChoiceMedic(String p_nameMedic)
        {
            return metier.configureChoiceMedic(p_nameMedic);
        }
        public List<String> configChoiceMedic(String p_nameMedic, String p_formeMedic)
        {
            return metier.configureChoiceMedic(p_nameMedic,p_formeMedic);
        }

        public Medicament getMedic(String p_nom, String p_forme, int p_dosage)
        {
            return metier.getMedicament(p_nom, p_forme, p_dosage);
        }

        public Medicament getMedic(long p_ean)
        {
            return metier.getMedicament(p_ean);
        }

        public lotMedicament getLotMedic(long ean)
        {
            return metier.GetLotMedicament(ean);
        }

        public void recupMedicament(Medicament p_medic, int quantity)
        {

        }

        public int getActualStock(long p_ean)
        {
            return metier.getActualStock(p_ean);
        }

        public void addCommand(string p_id, string p_type, string p_date, string p_quantity, string p_ean, string p_login, string p_nLot)
        {
            metier.AddCommand(p_id,p_type,p_date,p_quantity,p_ean,p_login,p_nLot);
        }
        public void addCommandNewUser(string p_login, string p_nom, string p_prenom, string p_admin, string p_password)
        {
            metier.AddCommandNewUser(p_login, p_nom, p_prenom, p_admin, p_password);
        }
        public void addCommandNewMedicament(string p_ean, string p_nom, string p_categorie, string p_substance, string p_forme, string p_dosage)
        {
            metier.AddCommandNewMedic(p_ean, p_nom, p_categorie, p_substance, p_forme, p_dosage);
        }
        public void sendCommands()
        {
            metier.sendUpdateCommands();
        }

        public List<lotMedicament> verifPeremption()
        {
            return metier.verifPeremption();
        }

        public void closeConnection()
        {
            metier.closeConnection();
        }

        public void sendOrderMail(long p_ean)
        {
            metier.sendOrderMail(p_ean);
        }
    }
}
