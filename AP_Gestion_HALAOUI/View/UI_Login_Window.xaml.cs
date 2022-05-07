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
using AP_Gestion_HALAOUI.DAO;
using AP_Gestion_HALAOUI.BDD;
using AP_Gestion_HALAOUI.View;
using AP_Gestion_HALAOUI.Controller;
using System.Windows.Threading;


namespace AP_Gestion_HALAOUI.View
{
    /// <summary>
    /// Logique d'interaction pour UI_Login_Window.xaml
    /// </summary>
    public partial class UI_Login_Window : Window
    {
        public MainWindow tac;
        public string bla = "a";

        public UI_Login_Window(MainWindow mn)
        {

            InitializeComponent();
            DAOEscapegame DAO = new DAOEscapegame();
            CT_AP CT = new CT_AP();
            DAO.reset_ConnexionString();


            DAO.set_ConnexionString("127.0.0.1", 3306, "root", "", "projet_ap");

            /* Mettre les dimensions voulues ici */
            tac = mn;

            TB_Password.Password = "mdp";
            TB_Username.Text = "yanish";
           


        }

      


    private void DB_Access_OK()
        {
            BTN_Connexion.IsEnabled = true;
        }

        private void BTN_Connexion_Click(object sender, RoutedEventArgs e)
        {
            // Vérifier si le champs de login est vide
            if (TB_Username.Text != "")
            {
                // Vérifier si le champs de mot de passe est vide
                if (TB_Password.Password != "")
                {
                    // Créations des objets
                    Utilisateur utilisateur = new Utilisateur();
                    DAOEscapegame DAO = new DAOEscapegame();

                    CT_AP CT = new CT_AP();

                    // Vérification si la DB est accessible
                    if (DAO.TestDBAcces() == true)
                    {
                        // Vérification si les identifiants sont bons
                        // Le mot de passe est crypté en MD5
                        if (DAO.Login(TB_Username.Text, CT.MD5(TB_Password.Password)) == true)
                        {
                            // Si les identifiants sont bons, on passe en argument les informations de l'utilisateur
                            this.Close();
                            tac.arg(TB_Username.Text);
                            tac.Show();
                        }
                        else
                        {
                            // Si les identifiants sont mauvais, on affiche un message d'erreur
                            MessageBox.Show("Identifiants incorrects", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        // Si la DB n'est pas accessible, on affiche un message d'erreur
                        MessageBox.Show("Impossible de se connecter à la base de données", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    // Si le champs de mot de passe est vide, on affiche un message d'erreur
                    MessageBox.Show("Veuillez entrer un mot de passe", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                // Si le champs de login est vide, on affiche un message d'erreur
                MessageBox.Show("Veuillez entrer un nom d'utilisateur", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BTN_Configuration_Click(object sender, RoutedEventArgs e)
        {
            UI_Configuration_Window uI_Configuration_Window = new UI_Configuration_Window();
            uI_Configuration_Window.Show();
        }

        private void BTN_Quitter_Click(object sender, RoutedEventArgs e)
        { 
        }
    }
}

