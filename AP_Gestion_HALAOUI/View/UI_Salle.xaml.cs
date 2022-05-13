using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AP_Gestion_HALAOUI;
using AP_Gestion_HALAOUI.DAO;
using AP_Gestion_HALAOUI.Controller;
using AP_Gestion_HALAOUI.BDD;
namespace AP_Gestion_HALAOUI.View
{
    /// <summary>
    /// Logique d'interaction pour UI_Salle.xaml
    /// </summary>
    public partial class UI_Salle : UserControl
    {
        public Salle UneSalleDeJeu = new Salle();
        public UI_Salle(Salle UneSalle, Utilisateur utilisateur)
        {
            UneSalleDeJeu = UneSalle;
            InitializeComponent();

            if(utilisateur.Grade > 1)
            {
                Prix.Visibility = Visibility.Visible;
                PrixErreur.Visibility = Visibility.Hidden;
            } else if(utilisateur.Grade <= 1){
                Prix.Visibility = Visibility.Hidden;
                PrixErreur.Visibility = Visibility.Visible;
            }


            for (int i = 0; i < UneSalle.Difficulte; i++)
            {
                lbl_difficulte.Content = lbl_difficulte.Content + " " + "✸";

            }
            lbl_difficulte.HorizontalAlignment = HorizontalAlignment.Right;

            DAOEscapegame DAO = new DAOEscapegame();
            

            lbl_joueurs_total.Content = lbl_joueurs_total.Content + " " + DAO.NbTotalJoeuur(UneSalle);

            lbl_title.Content = lbl_title.Content + " " + UneSalle.NomSalle;

            lbl_title.HorizontalAlignment = HorizontalAlignment.Center;

            lbl_parties_jouees.Content = lbl_parties_jouees.Content + " " + DAO.NBTotalParties(UneSalle).ToString() + "";

            lbl_joueurs_max.Content = lbl_joueurs_max.Content + " " + UneSalle.NbJoueurMax.ToString() + "";

            lbl_localisation.Content = lbl_localisation.Content + " " + DAO.ID_To_Localisation(UneSalle.Localisation).Ville + ", " + DAO.ID_To_Localisation(UneSalle.Localisation).CodePostal;

            lbl_prix_joueur.Content = lbl_prix_joueur.Content + " " + DAO.TarificationBySalle(UneSalle).PrixJoueur.ToString() + "€";

            lbl_prix_obstacle.Content = lbl_prix_obstacle.Content + " " + DAO.TarificationBySalle(UneSalle).PrixObstacle.ToString() + "€";

            lbl_prix_heure.Content = lbl_prix_heure.Content + " " + DAO.TarificationBySalle(UneSalle).PrixHeure.ToString() + "€";


            lbl_parties_jouees.HorizontalAlignment = HorizontalAlignment.Center;
            lbl_prix_heure.HorizontalAlignment = HorizontalAlignment.Right;

            lbl_prix_joueur.HorizontalAlignment = HorizontalAlignment.Center;
            lbl_prix_heure.HorizontalAlignment = HorizontalAlignment.Right;

            LoadCB(UneSalle);
        }

        public void LoadCB(Salle salle)
        {
            for (int i = 1; i <= salle.NbJoueurMax; i++)
            {
                CB_nb_Joueurs.Items.Add(i);
            }
            
           for (int i = 1; i <= salle.NbOstacleMax; i++)
           {
                    CB_nb_Obstacle.Items.Add(i);
           }

            CB_nb_heures.Items.Add("1");
            CB_nb_heures.Items.Add("2");
            CB_nb_heures.Items.Add("3");

            CB_nb_Joueurs.SelectedIndex = 0;
            CB_nb_Obstacle.SelectedIndex = 0;
            CB_nb_heures.SelectedIndex = 0;

        }

        public void Calculer()
        {
            DAOEscapegame DAO = new DAOEscapegame();
            string s = "";
            int prix_total_joueurs = Convert.ToInt16(DAO.TarificationBySalle(UneSalleDeJeu).PrixJoueur) * Convert.ToInt16(CB_nb_Joueurs.SelectedValue);
            int prix_total_obstacles = Convert.ToInt16(DAO.TarificationBySalle(UneSalleDeJeu).PrixObstacle) * Convert.ToInt16(CB_nb_Obstacle.SelectedValue);

            if(Convert.ToInt16(CB_nb_heures.SelectedValue) > 1)
            {
                s = "s";
            }
            montant_simul.Content = "Le prix par heure est de " + prix_total_joueurs + "€ pour les joueurs, " +
                prix_total_obstacles + "€ pour les obstacles, soit un total de " +
                ((prix_total_joueurs + prix_total_obstacles)*Convert.ToInt16(CB_nb_heures.SelectedValue)) +
                "€ pour " + CB_nb_heures.SelectedValue + " heure" + s + ".";
        }

        private void CB_nb_Obstacle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Calculer();
        }

        private void CB_nb_Joueurs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Calculer();
        }

        private void CB_nb_heures_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Calculer();
        }
    }
}
