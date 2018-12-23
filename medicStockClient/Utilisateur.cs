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
        string profession;
        string password;

        public Utilisateur()
        {
            login = null;
            nom = null;
            prenom = null;
            profession = null;
            password = null;
        }

        public Utilisateur(string p_login, string p_nom, string p_prenom,string p_profession, string p_password)
        {
            login = p_login;
            nom = p_nom;
            prenom = p_prenom;
            profession = p_profession;
            password = p_password;
        }

        public string getLogin()
        { return login; }

        public string getNom()
        { return nom; }

        public string getPrenom()
        { return prenom; }

        public string getProfession()
        { return profession; }

        public string getPassword()
        { return password; }
    }
}
