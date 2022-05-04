using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AP_Gestion_HALAOUI.BDD;
using AP_Gestion_HALAOUI;
using System.Diagnostics;
using AP_Gestion_HALAOUI.Controller;
using System.Data;
namespace AP_Gestion_HALAOUI.DAO
{
    class DAOEscapegame
    {
        private projet_apContext Context;
        
        public bool TestDBAcces()
        {
            bool dbaccess = true;

            using (Context = new projet_apContext())
            {
                /* https://stackoverflow.com/questions/6232633/entity-framework-timeouts */
                Context.Database.SetCommandTimeout(100);

                Context.Database.GetConnectionString();

                try { Context.Utilisateurs.ToList(); }
                catch (Exception) { dbaccess = false; }

            }
            return dbaccess;
        }

        public string get_ConnexionString()
        {
            using (Context = new projet_apContext())
            {
                return Context.Database.GetConnectionString();

            }
        } 
        
        public bool set_ConnexionString(string Connexionstr)
        {
            using (Context = new projet_apContext())
            {

                Context.Database.SetConnectionString(Connexionstr);

                try
                {
                    Context.Database.OpenConnection();
                }
                catch (Exception)
                {
                    return false;
                }
                return true;

            }
        }
        
        public bool Login(string username, string motdepasse)
        {
            using (Context = new projet_apContext())
            {
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
