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

        public int NbrSalles()
        {
            int total = 0;
            using (Context = new projet_apContext())
            {
                foreach (Salle s in Context.Salles)
                {
                    total++;
                }
            }
            return total;
        }

        public int NbrTotalParties()
        {
            int total = 0;
            using (Context = new projet_apContext())
            {
                foreach (Party p in Context.Parties)
                {
                    total++;
                }
            }
            return total;
        }

        public int NbTotalJoueurs()
        {
            int total = 0;
            using (Context = new projet_apContext())
            {
                foreach (Party p in Context.Parties)
                {
                    total = total + p.NbJoueurs;
                }
            }
            return total;
        }

        public double PourentageReussite()
        {
            double total = 0;
            using (Context = new projet_apContext())
            {
                foreach (Party p in Context.Parties)
                {
                    total = total + p.Reussite;
                }
            }
            return Math.Round((total / NbrTotalParties())* 100,0);
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


        // get_Salles
        public List<Salle> get_Salles()
        {
            using (Context = new projet_apContext())
            {
                return Context.Salles.ToList();
            }
        }

        public int NBTotalParties(Salle Salle)
        {
            using(Context = new projet_apContext())
            {
                return Context.Parties.Count(s => s.IdSalle == Salle.IdSalle);
            }
        }

        public int NbTotalJoeuur(Salle Salle)
        {
            int total = 0;
            using (Context = new projet_apContext())
            {
                foreach (Party p in Context.Parties)
                {
                    if (p.IdSalle == Salle.IdSalle)
                    {
                        total = total + p.NbJoueurs;
                    }
                }
            }
            return total;
        }


        public Utilisateur EmailToUser(string email)
        {
            using (Context = new projet_apContext())
            {
                return Context.Utilisateurs.FirstOrDefault(u => u.Email == email);
            }
        }



        public Tarification TarificationBySalle(Salle salle)
        {
            using (Context = new projet_apContext())
            {
                try
                {
                    return Context.Tarification.FirstOrDefault(s => s.IdSalle == salle.IdSalle);
                }
                catch
                {
                    Tarification tarif_error = new Tarification();
                    tarif_error.IdTarif = 0;
                    tarif_error.IdSalle = 0;
                    tarif_error.PrixHeure = 0;
                    tarif_error.PrixJoueur = 0;
                    tarif_error.PrixObstacle = 0;
                    return tarif_error;
                }
            }
        }



        public Lieuxactivite ID_To_Localisation(int id)
        {
            using (Context = new projet_apContext())
            {
                // retourne un objet de type Lieu
                return Context.Lieuxactivites.Where(s => s.IdLieu == id).First();
            }
        }
        
        public Salle ID_To_Salle(string nom)
        {
            using (Context = new projet_apContext())
            {
                return Context.Salles.FirstOrDefault(s => s.NomSalle == nom); // objet de type salle
            }
        }
            public DB ReturnDBObject()
        {
            DB db = new DB();
            
            string[] words = get_ConnexionString().Split(';');

            if (words[0].Replace("server=", "") != "")
            {
                foreach (string word in words)
                {
                    if (word.Contains("server="))
                    {
                        db.server = word.Replace("server=", "");
                    }
                    if (word.Contains("port="))
                    {
                        db.port = Convert.ToInt32(word.Replace("port=", ""));
                    }
                    if (word.Contains("user="))
                    {
                        db.identifiant = word.Replace("user=", "");
                    }
                    if (word.Contains("password="))
                    {
                        db.motdepasse = word.Replace("password=", "");
                    }
                    if (word.Contains("database="))
                    {
                        db.bdd = word.Replace("database=", "");
                    }
                }
            }
            
            return db;
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
