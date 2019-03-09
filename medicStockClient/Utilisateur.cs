using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicStockClient
{
    class Utilisateur
    {
        string login;
        string nom;
        string prenom;
        bool administrateur;
        string password;

        public Utilisateur()
        {
            login = null;
            nom = null;
            prenom = null;
            administrateur = false;
            password = null;
        }

        public Utilisateur(string p_login, string p_nom, string p_prenom,bool p_administrateur, string p_password)
        {
            login = p_login;
            nom = p_nom;
            prenom = p_prenom;
            administrateur = p_administrateur;
            password = p_password;
        }

        public string getLogin()
        { return login; }

        public string getNom()
        { return nom; }

        public string getPrenom()
        { return prenom; }

        public bool getadministrateur()
        { return administrateur; }

        public string getPassword()
        { return password; }
    }
}
