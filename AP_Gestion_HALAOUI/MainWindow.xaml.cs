using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AP_Gestion_HALAOUI.View;
using AP_Gestion_HALAOUI.DAO;
namespace AP_Gestion_HALAOUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        public MainWindow()
        {
            InitializeComponent();



            DAOEscapegame DAO = new DAOEscapegame();
            DAO.reset_ConnexionString();


            UI_Login_Window uI_Login_Window = new UI_Login_Window(this);
            Window UI_Login_Window = new UI_Login_Window(this);
            UI_Login_Window.Show();

            this.Hide();
        }

        public void arg(string bla)
        {
            MessageBox.Show("Variable passée : " + bla);
            label.Content = "Bonjour " + bla;

        }


        
    }
}
