using System;
using System.Collections.Generic;

#nullable disable

namespace AP_Gestion_HALAOUI.BDD
{
    public partial class Salle
    {
        public int IdSalle { get; set; }
        public string NomSalle { get; set; }
        public int Localisation { get; set; }
        public string ImagePresentation { get; set; }
        public string DescriptionPresentation { get; set; }
        public int NbJoueurMax { get; set; }
        public int Difficulte { get; set; }

        public virtual Lieuxactivite LocalisationNavigation { get; set; }
    }
}
