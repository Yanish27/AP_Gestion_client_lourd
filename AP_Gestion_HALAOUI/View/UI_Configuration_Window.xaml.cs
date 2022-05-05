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
using System.Windows.Shapes;
using AP_Gestion_HALAOUI.Controller;
using AP_Gestion_HALAOUI.DAO;
using AP_Gestion_HALAOUI.BDD;
using System;
using System.IO;

namespace AP_Gestion_HALAOUI.View
{
    /// <summary>
    /// Logique d'interaction pour UI_Configuration_Window.xaml
    /// </summary>
    public partial class UI_Configuration_Window : Window
    {
        public UI_Configuration_Window()
        {
            InitializeComponent();
            BTN_Valider.IsEnabled = false;
            
            //DAO.set_ConnexionString("199.999.999.999", 9999, "root", "mdp", "DB");



        }

        private void BTN_Test_Click(object sender, RoutedEventArgs e)
        {
            DAOEscapegame DAO = new DAOEscapegame();


            DAO.set_ConnexionString(TB_bdd_host.Text,3306, TB_bdd_username.Text, TB_bdd_password.Text, "projet_ap");


            if (DAO.TestDBAcces())
            {
                BTN_Valider.IsEnabled = true;
                MessageBox.Show("Connexion à la base de données réussie", "Connexion à la DB", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Connexion à la base de données échouée", "Connexion à la DB", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            /* ...... */

        }
    }
}
