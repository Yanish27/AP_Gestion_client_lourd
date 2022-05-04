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

        public bool CheckUsername(string username, string motdepasse)
        {
            bool present = false;
            IEnumerable<Utilisateur> AllUtilisateur = new List<Utilisateur>();
            using (Context = new projet_apContext())
            {
                AllUtilisateur = Context.Utilisateurs.ToList();
                try
                {
                    var tt = Context.Utilisateurs.Where(u => u.Email == username && u.Motdepasse == motdepasse).Single();
                    return true;
                }
                catch (Exception ex)
                {
                    string er = ex.ToString();
                    return false;
                }
              
            }
        }

     

    }
}
