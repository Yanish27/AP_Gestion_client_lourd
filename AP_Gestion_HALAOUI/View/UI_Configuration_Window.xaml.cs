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
            DAOEscapegame DAO = new DAOEscapegame();
            string ConnexionString_Save = DAO.get_ConnexionString();
            MessageBox.Show(DAO.get_ConnexionString());
            DAO.set_ConnexionString("server=127.0.0.1;port=3306;user=yaya;password=yaya;database=projet_ap;");
            MessageBox.Show(DAO.get_ConnexionString());



        }

        private void BTN_Test_Click(object sender, RoutedEventArgs e)
        {
            DAOEscapegame DAO = new DAOEscapegame();
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
