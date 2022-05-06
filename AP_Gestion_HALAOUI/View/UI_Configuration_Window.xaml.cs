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
        DAOEscapegame DAO = new DAOEscapegame();
        public UI_Configuration_Window()
        {
            InitializeComponent();
            BTN_Valider.IsEnabled = false;

            DB db = DAO.ReturnDBObject();

            TB_bdd_host.Text = db.server;
            TB_bdd_port.Text = db.port.ToString();
            TB_bdd_username.Text = db.identifiant;
            TB_bdd_password.Text = db.motdepasse;

        }

        private void BTN_Test_Click(object sender, RoutedEventArgs e)
        {


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

            

        }

        private void BTN_Valider_Click(object sender, RoutedEventArgs e)
        {

            
            this.Close();
        }
    }
}
