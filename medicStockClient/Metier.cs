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

        private List<Utilisateur> listUtilisateur = new List<Utilisateur>(); // Liste de tous les utilisateurs
        private List<Interaction> listInteraction = new List<Interaction>(); // Liste de toutes les interactions 
        private List<lotMedicament> listLotMedicament = new List<lotMedicament>(); // Liste de tous les lots de médicaments
        private List<Medicament> listMedicament = new List<Medicament>(); // Liste de tous les médicaments

        private List<long> listChoicedMedicament = new List<long>(); // Liste de tous les médicaments choisis par l'utilisateur afin d'y effectuer une interaction
        private List<String> listUpdateCommands = new List<String>(); // Liste de toutes les commandes SQL générées durant l'utilisation de l'application 

        private String serverAddress = "localhost"; // Configuration de l'adresse IP du serveur 
        private Int32 serverPort = 22; // Configuration du port pour le serveur

        public Metier()
        {
            TcpClient = new Client(serverAddress, serverPort);
            initDataClass(TcpClient.getDataString());
        }

        public void initDataClass(String dataString)
        {
            int i;
            List<String> listGlobal = dataString.Split('%').ToList();

            List<String> listUser = listGlobal[0].Split(';').ToList();
            List<String> listInter = listGlobal[1].Split(';').ToList();
            List<String> listLotMedic = listGlobal[2].Split(';').ToList();
            List<String> listMedic = listGlobal[3].Split(';').ToList();

            String UserAttributes = null;
            List<String> listUserAttributes = new List<String>();
            String InterAttributes = null;
            List<String> listInterAttributes = new List<String>();
            String LotMedicAttributes = null;
            List<String> listLotMedicAttributes = new List<String>();
            String MedicAttributes = null;
            List<String> listMedicAttributes = new List<String>();

            for (i = 0; i < listUser.Count - 1; i++)
            {
                UserAttributes = UserAttributes + listUser[i];
            }
            listUserAttributes = UserAttributes.Split(',').ToList();

            for (i = 0; i < listInter.Count - 1; i++)
            {
                InterAttributes = InterAttributes + listInter[i];
            }
            listInterAttributes = InterAttributes.Split(',').ToList();

            for (i = 0; i < listLotMedic.Count - 1; i++)
            {
                LotMedicAttributes = LotMedicAttributes + listLotMedic[i];
            }
            listLotMedicAttributes = LotMedicAttributes.Split(',').ToList();


            for (i = 0; i < listLotMedic.Count - 1; i++)
            {
                MedicAttributes = MedicAttributes + listMedic[i];
            }
            listMedicAttributes = MedicAttributes.Trim().Split(',').ToList();


            for (int y = 0; y < cleanList(listUserAttributes).Count; y = y + 5)
            {
                listUtilisateur.Add(new Utilisateur(listUserAttributes[y], listUserAttributes[y + 1], listUserAttributes[y + 2], ToBoolean(listUserAttributes[y + 3]), listUserAttributes[y + 4]));
            }
            Console.WriteLine(cleanList(listUserAttributes).Count / 5);

            for (int y = 0; y < cleanList(listInterAttributes).Count; y = y + 6)
            {
                listInteraction.Add(new Interaction(Int32.Parse(listInterAttributes[y]), listInterAttributes[y + 1], Int32.Parse(listInterAttributes[y + 2]), Int64.Parse(listInterAttributes[y + 3]), listInterAttributes[y + 4], Int32.Parse(listInterAttributes[y + 5])));
            }

            for (int y = 0; y < cleanList(listLotMedicAttributes).Count; y = y + 10)
            {
                listLotMedicament.Add(new lotMedicament(listLotMedicAttributes[y], Int32.Parse(listLotMedicAttributes[y + 1]), listLotMedicAttributes[y + 2], listLotMedicAttributes[y + 3], Int32.Parse(listLotMedicAttributes[y + 4]),
                    listLotMedicAttributes[y + 5], Int32.Parse(listLotMedicAttributes[y + 6]), Int32.Parse(listLotMedicAttributes[y + 7]), ToBoolean(listLotMedicAttributes[y + 8]), Int64.Parse(listLotMedicAttributes[y + 9])));
            }

            for (int y = 0; y < cleanList(listMedicAttributes).Count; y = y + 6)
            {
                listMedicament.Add(new Medicament(Int64.Parse(listMedicAttributes[y]), listMedicAttributes[y + 1], listMedicAttributes[y + 2], listMedicAttributes[y + 3], listMedicAttributes[y + 4], Int32.Parse(listMedicAttributes[y + 5])));
            }
        }

        public int Authentification(String p_login, String p_password) // 0 = Login ou Pwd incorrect ; 1 = Normal user ; 2 = Admin user ; 3 = Erreur de vérification
        {
            try
            {
                foreach (Utilisateur usr in listUtilisateur) // Pour chaque utilisateur référencé dans la base de données
                {
                    if (p_login == usr.getLogin() && p_password == usr.getPassword()) // Si les informations d'authentification correspondent
                    {
                        if (usr.getadministrateur() == true) // Si l'utilisateur est référencé en tant qu'adinistrateur 
                        {
                            Console.WriteLine(usr.getLogin());
                            return 2; // Utilisateur administrateur
                        }
                        else if (usr.getadministrateur() == false)
                        {
                            Console.WriteLine(usr.getLogin());
                            return 1; // Utilisateur normal
                        }
                    }
                }
            }
            catch
            {
                return 3; // Si la liste d'utilisateur de la dB est innacessible 
            }
            return 0; // Si les informations d'authentification ne sont pas reconnues
        }

        public List<String> configureChoiceMedic()
        {
            List<String> listMedicName = new List<String>();

            foreach (Medicament medic in listMedicament)
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
                if (medic.getNom() == p_choicedName)
                    listMedicForme.Add(medic.getFormeGalenique());
            }
            return listMedicForme;
        }

        public List<int> configureChoiceMedic(String p_choicedName, String p_choicedForme)
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
            foreach (Medicament medic in listMedicament)
            {
                if (medic.getNom() == p_choicedName && medic.getFormeGalenique() == p_choicedForme && medic.getDosage() == p_choicedDosage)
                    listChoicedMedicament.Add(medic.getNumeroEan());
            }
        }

        public List<Medicament> getFullMedic(List<long> p_listChoicedMedic)
        {
            List<Medicament> fullListChoicedMedic = new List<Medicament>();

            foreach (long ean in p_listChoicedMedic)
            {
                foreach (Medicament medic in listMedicament)
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
            foreach (lotMedicament lotMedic in listLotMedicament)
            {
                if (lotMedic.getNumeroEan() == p_numeroEan)
                    lotMedicToOrder = lotMedic;
                foreach (Medicament medic in listMedicament)
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
            listMedicament.Add(new Medicament(Int64.Parse(p_newMedic[0]), p_newMedic[1], p_newMedic[2], p_newMedic[3], p_newMedic[4], int.Parse(p_newMedic[5])));
        }

        public void createUser(List<String> p_newUser)
        {
            listUtilisateur.Add(new Utilisateur(p_newUser[0], p_newUser[1], p_newUser[2], bool.Parse(p_newUser[3]), p_newUser[4]));
        }

        public String createSimpleDataString(List<String> p_listToConvert)
        {
            String dataString = null;

            foreach (String str in p_listToConvert)
            {
                dataString = dataString + str + ";";
            }

            return dataString;
        }
        public static bool ToBoolean(string value)
        {
            switch (value.ToLower())
            {
                case "true":
                    return true;
                case "t":
                    return true;
                case "1":
                    return true;
                case "0":
                    return false;
                case "false":
                    return false;
                case "f":
                    return false;
                default:
                    throw new InvalidCastException("You can't cast that value to a bool!");
            }
        }

        public static List<String> cleanList(List<String> p_list)
        {
            int i = 0;
            while(i < p_list.Count)
            {
                if (p_list[i] == "" || p_list[i] == null)
                    p_list.Remove(p_list[i]);

                i++;
            }
            return p_list;
        }
    }
}
