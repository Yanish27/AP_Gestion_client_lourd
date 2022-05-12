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
using AP_Gestion_HALAOUI.DAO;
using AP_Gestion_HALAOUI.BDD;
using AP_Gestion_HALAOUI.Controller;
namespace AP_Gestion_HALAOUI.View
{
    /// <summary>
    /// Logique d'interaction pour UI_General.xaml
    /// </summary>
    public partial class UI_General : UserControl
    {
        DAOEscapegame DAO = new DAOEscapegame();
        public UI_General()
        {
            InitializeComponent();
            Actualiser();
        }
        public void Actualiser()
        {
            lbl_nbr_salles.Content = lbl_nbr_salles.Content + " " + Convert.ToString(DAO.NbrSalles());
            lbl_nbr_parties.Content = lbl_nbr_parties.Content + " " + Convert.ToString(DAO.NbrTotalParties());
            lbl_nbr_joueur_total.Content = lbl_nbr_joueur_total.Content + " " + Convert.ToString(DAO.NbTotalJoueurs());

            lbl_pourcent_reussite.Content = lbl_pourcent_reussite.Content + " " + Convert.ToString(DAO.PourentageReussite()) + "%";

        }
    }
}
