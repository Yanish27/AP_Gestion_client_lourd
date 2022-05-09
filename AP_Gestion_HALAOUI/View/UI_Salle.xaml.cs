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
        public UI_Salle(Salle UneSalle)
        {
            InitializeComponent();

            for (int i = 0; i < UneSalle.Difficulte; i++)
            {
                lbl_difficulte.Content = lbl_difficulte.Content + " " + "✸";

            }
            lbl_difficulte.HorizontalAlignment = HorizontalAlignment.Right;

            DAOEscapegame DAO = new DAOEscapegame();

            MessageBox.Show(DAO.nbJoueurTotal(UneSalle).ToString());

            lbl_title.Content = lbl_title.Content + " " + UneSalle.NomSalle;

            lbl_title.HorizontalAlignment = HorizontalAlignment.Center;
            lbl_localisation.Content = lbl_localisation.Content + " " + DAO.ID_To_Localisation(UneSalle.Localisation).Ville + ", " + DAO.ID_To_Localisation(UneSalle.Localisation).CodePostal;

            LoadCB(UneSalle);
        }

        public void LoadCB(Salle salle)
        {
            for (int i = 0; i < salle.NbJoueurMax; i++)
            {
                CB_nb_Joueurs.Items.Add(i);
            }
            
           for (int i = 0; i < salle.NbJoueurMax; i++)
           {
                    CB_nb_Obstacle.Items.Add(i + 1);
           }
           
        }
    }
}
