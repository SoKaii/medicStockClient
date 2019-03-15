using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicStockClient
{
    class Interaction
    {
        int type;
        string date;
        int nombreBoite;
        long numeroEan;
        String loginUser;
        int numeroLot;

        public Interaction()
        {
            type = 0;
            date = null;
            nombreBoite = 0;
            numeroEan = 0;
            loginUser = null;
            numeroLot = 0;
        }

        public Interaction(int p_type,String p_date,int p_nombreBoite, long p_numeroEan, String p_loginUser, int p_numeroLot)
        {
            type = p_type;
            date = p_date;
            nombreBoite = p_nombreBoite;
            numeroEan = p_numeroEan;
            loginUser = p_loginUser;
            numeroLot = p_numeroLot;
        }


        public int getType()
        { return type; }

        public String getDate()
        { return date; }

        public int getNombreBoite()
        { return nombreBoite; }

        public long getNumeroEan()
        { return numeroEan; }

        public String getLoginuser()
        { return loginUser; }

        public int getNumeroLot()
        { return numeroLot; }

    }
}
