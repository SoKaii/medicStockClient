using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;


namespace medicStockClient
{
    class Metier
    {
        private Client TcpClient; // Client permettant la connexion au serveur

        private List<Utilisateur> listUtilisateur; // Liste de tous les utilisateurs
        private List<Interaction> listInteraction; // Liste de toutes les interactions 
        private List<lotMedicament> listLotMedicament; // Liste de tous les lots de médicaments
        private List<Medicament> listMedicament; // Liste de tous les médicaments

        private List<long> listChoicedMedicament; // Liste de tous les médicaments choisis par l'utilisateur afin d'y effectuer une interaction
        private List<String> listUpdateCommands; // Liste de toutes les commandes SQL générées durant l'utilisation de l'application 

        public Metier()
        {
           
        }

        public int Authentification(String p_login, String p_password) // 0 = Login ou Pwd incorrect ; 1 = Normal user ; 2 = Admin user ; 3 = Erreur de vérification
        {
            foreach(Utilisateur usr in listUtilisateur)
            {
                if(p_login == usr.getLogin() && p_password == usr.getPassword())
                {
                    if (usr.getadministrateur() == true)
                        return 2;
                    else
                        return 1;
                }
                else
                {
                    return 0;
                }
            }

            return 3;
        }

        public List<String> configureChoiceMedic()
        {
            List<String> listMedicName = new List<String>();

            foreach(Medicament medic in listMedicament)
            {
                listMedicName.Add(medic.getNom());
            }

            return listMedicName;
        }

        public List<String> configureChoiceMedic(String p_choicedName)
        {
            List<String> listMedicForme = new List<String>();

            foreach (Medicament medic in listMedicament)
            {
                if(medic.getNom() == p_choicedName)
                    listMedicForme.Add(medic.getFormeGalenique());
            }
            return listMedicForme;
        }

        public List<int> configureChoiceMedic(String p_choicedName,String p_choicedForme)
        {
            List<int> listMedicDosage = new List<int>();

            foreach (Medicament medic in listMedicament)
            {
                if (medic.getNom() == p_choicedName && medic.getFormeGalenique() == p_choicedForme)
                    listMedicDosage.Add(medic.getDosage());
            }
            return listMedicDosage;
        }


        public void configureListChoicedMedic(String p_choicedName, String p_choicedForme, int p_choicedDosage)
        {
            foreach(Medicament medic in listMedicament)
            {
                if (medic.getNom() == p_choicedName && medic.getFormeGalenique() == p_choicedForme && medic.getDosage() == p_choicedDosage)
                    listChoicedMedicament.Add(medic.getNumeroEan());
            }
        }

        public List<Medicament> getFullMedic(List<long> p_listChoicedMedic)
        {
            List<Medicament> fullListChoicedMedic = new List<Medicament>();

            foreach(long ean in p_listChoicedMedic)
            {
                foreach(Medicament medic in listMedicament)
                {
                    if (medic.getNumeroEan() == ean)
                        fullListChoicedMedic.Add(medic);
                }
            }

            return fullListChoicedMedic;
        }

        public void sendOrderMail(long p_numeroEan)
        {
            Medicament medicToOrder = new Medicament();
            lotMedicament lotMedicToOrder = new lotMedicament();
            foreach(lotMedicament lotMedic in listLotMedicament)
            {
                if (lotMedic.getNumeroEan() == p_numeroEan)
                    lotMedicToOrder = lotMedic;
                foreach(Medicament medic in listMedicament)
                {
                    if (lotMedicToOrder.getNumeroEan() == medic.getNumeroEan())
                        medicToOrder = medic;
                }
            }

            var fromAddress = new MailAddress("medicStockAginfos@gmail.com", "medicStock");
            var toAddress = new MailAddress("t.martin92500@hotmail.fr", "Thomas Martin");
            const string fromPassword = "aginfosaforp";
            string subject = "Commande de " + medicToOrder.getNom() + " pour l'Hopital Innovation Aforp";
            string body = "Ceci est un message automatique envoyé par l'application medicalStock \n\n" +
                "Bonjour,\n" +
                "Nous souhaiterons vous passer commande de " + lotMedicToOrder.getQuantiteCommandeAuto() + " " + medicToOrder.getNom() + " " + medicToOrder.getDosage() + " mg en " + medicToOrder.getFormeGalenique() + "\n"
                + "Merci de nous livrer cette commande au plus tôt possible\n\n"
                + "Application medicalStock \n Gestion de Stock de l'Hopital Innovation Aforp\n\n"
                + "Ce mail est automatique, veuillez ne pas y répondre";


            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
            {
                smtp.Send(message);
            }
        }

        public void createMedic(List<String> p_newMedic)
        {
            listMedicament.Add(new Medicament(Int64.Parse(p_newMedic[0])))
        }
    }
}
