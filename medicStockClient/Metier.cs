using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;


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


            for (i = 0; i < listMedic.Count - 1; i++)
            {
                MedicAttributes = MedicAttributes + listMedic[i];
            }
            listMedicAttributes = MedicAttributes.Trim().Split(',').ToList();


            for (int y = 0; y < cleanList(listUserAttributes).Count; y = y + 5)
            {
                listUtilisateur.Add(new Utilisateur(listUserAttributes[y], listUserAttributes[y + 1], listUserAttributes[y + 2], ToBoolean(listUserAttributes[y + 3]), listUserAttributes[y + 4]));
            }

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
                    if (p_login.ToLower() == usr.getLogin().ToLower() && MD5(p_password) == usr.getPassword()) // Si les informations d'authentification correspondent
                    {
                        if (usr.getadministrateur() == true) // Si l'utilisateur est référencé en tant qu'adinistrateur 
                        {
                            return 2; // Utilisateur administrateur
                        }
                        else if (usr.getadministrateur() == false)
                        {
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
            bool tamer = true;

            foreach (Medicament medic in listMedicament)
            {
                foreach (String str in listMedicName)
                {
                    if (medic.getNom() == str)
                        tamer = false;
                }
                if (tamer == true)
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

        public List<String> configureChoiceMedic(String p_choicedName, String p_choicedForme)
        {
            List<String> listMedicDosage = new List<String>();

            foreach (Medicament medic in listMedicament)
            {
                if (medic.getNom() == p_choicedName && medic.getFormeGalenique() == p_choicedForme)
                    listMedicDosage.Add(medic.getDosage().ToString());
            }
            return listMedicDosage;
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

        public Utilisateur getUser(String p_login)
        {
            Utilisateur userConnected = new Utilisateur();
            foreach (Utilisateur usr in listUtilisateur)
            {
                if (usr.getLogin().ToLower() == p_login.ToLower())
                {
                    userConnected = usr;
                }
            }
            return userConnected;
        }

        public Medicament getMedicament(String p_nom, String p_forme, int p_dosage)
        {
            Medicament medic = new Medicament();
            foreach (Medicament mdc in listMedicament)
            {
                if (mdc.getNom() == p_nom && mdc.getFormeGalenique() == p_forme && mdc.getDosage() == p_dosage)
                    medic = mdc;
            }
            return medic;
        }

        public lotMedicament GetLotMedicament(long numeroEan)
        {
            List<lotMedicament> lm = new List<lotMedicament>();
            lotMedicament lotmedicament = new lotMedicament();

            foreach (lotMedicament lotmedic in listLotMedicament)
            {
                if (lotmedic.getNumeroEan() == numeroEan)
                    lotmedicament = lotmedic;
            }

            return lotmedicament;
        }

        public void AddCommand(string p_type, string p_date, string p_quantity, string p_ean, string p_login, string p_nLot)
        {
            TcpClient.AddCommands(p_type, p_date, p_quantity, p_ean, p_login, p_nLot);
        }

        public void sendUpdateCommands()
        {
            TcpClient.sendData();
        }

        private static string MD5(string stringToHash)
        {
            MD5CryptoServiceProvider MD5Code = new MD5CryptoServiceProvider();
            byte[] hashedString = Encoding.UTF8.GetBytes(stringToHash);
            hashedString = MD5Code.ComputeHash(hashedString);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in hashedString)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
    }
}
