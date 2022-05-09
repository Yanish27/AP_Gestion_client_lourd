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
        public UI_Salle(Salle nomSalle)
        {
            InitializeComponent();

            for (int i = 0; i < nomSalle.Difficulte; i++)
            {
                lbltxt.Content = lbltxt.Content + " " + "✸";
            }

            lbl_title.Content = lbl_title.Content + " " + nomSalle.NomSalle;

        }
    }
}
