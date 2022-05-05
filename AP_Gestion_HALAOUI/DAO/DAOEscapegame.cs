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
    public class DB
    {
        public string server { get; set; }
        public string identifiant { get; set; }
        public string motdepasse { get; set; }
        public int port { get; set; }
        public string bdd { get; set; }

   
    }

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
            string abc = "";
            try
            {
                abc = System.IO.File.ReadAllLines("FILE")[0];
            }
            catch
            {
                abc = null;
            }
            return abc;
           
        }
    
        public void set_ConnexionString(string host, int port, string id, string mdp, string DB)
        {

            System.IO.File.WriteAllText("FILE", "server="+host+";port="+port+";user="+id +";password="+ mdp + ";database=" +DB);
        }


        public void reset_ConnexionString()
        {
            System.IO.File.WriteAllText("FILE", "server=;port=;user=;password=;database=;");
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
