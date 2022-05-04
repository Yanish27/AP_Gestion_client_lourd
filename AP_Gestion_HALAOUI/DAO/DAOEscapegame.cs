using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using AP_Gestion_HALAOUI.BDD;
using AP_Gestion_HALAOUI;

using System.Data;
namespace AP_Gestion_HALAOUI.DAO
{
    class DAOEscapegame
    {
        private projet_apContext Context;
        
        public Utilisateur GetID(string nom)
        {
           return null;
        }

        public bool CheckUsername(string username)
        {
            bool present = false;
            IEnumerable<Utilisateur> AllUtilisateur = new List<Utilisateur>();
            using (Context = new projet_apContext())
            {
                AllUtilisateur = Context.Utilisateurs.ToList();
            }

            foreach (Utilisateur utilisateur in AllUtilisateur)
            {
                if(utilisateur.Email == username)
                {
                    present = true;
                }
            }
            return present;
        }

        public bool CheckUsernamePassword(string username, string password)
        {
            bool valide = false;
            IEnumerable<Utilisateur> AllUtilisateur = new List<Utilisateur>();
            using (Context = new projet_apContext())
            {
                AllUtilisateur = Context.Utilisateurs.ToList();
            }

            foreach (Utilisateur utilisateur in AllUtilisateur)
            {
                if (utilisateur.Email == username && utilisateur.Motdepasse == password)
                {
                    valide = true;
                }
            }
            return valide;
        }

    }
}
