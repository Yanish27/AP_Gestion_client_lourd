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
using AP_Gestion_HALAOUI.Controller;
using AP_Gestion_HALAOUI.BDD;
using AP_Gestion_HALAOUI.View;

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
            /* Mettre les dimensiosn voulu ici */
            tac = mn;


        }


        private void BTN_Connexion_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Username.Text != "")
            {
                if (TB_Password.Password != "")
                {
                    Utilisateur utilisateur = new Utilisateur();
                    DAOEscapegame DAO = new DAOEscapegame();
                    if (DAO.CheckUsername(TB_Username.Text, TB_Password.Password) == true)
                    {
                            this.Close();
                            tac.arg(TB_Username.Text);
                            tac.Show();
                    }
                    else
                    {
                        MessageBox.Show("Identifiants incorrects");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un mot de passe");
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nom d'utilisateur");
            }
        }

        private void BTN_Configuration_Click(object sender, RoutedEventArgs e)
        {
            UI_Configuration uI_Configuration = new UI_Configuration();
            Window con = new Window();
            con.Content = uI_Configuration;
            con.Show();


        }

        private void BTN_Quitter_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}

