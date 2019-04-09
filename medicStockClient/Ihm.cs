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

        public lotMedicament getLotMedic(long ean)
        {
            return metier.GetLotMedicament(ean);
        }

        public void recupMedicament(Medicament p_medic, int quantity)
        {

        }

        public void addCommand(string p_command)
        {
            metier.AddCommand(p_command);
        }

        public void sendCommands()
        {
            metier.sendUpdateCommands();
        }
    }
}
