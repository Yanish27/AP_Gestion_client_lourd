using System;
using System.Collections.Generic;

#nullable disable

namespace AP_Gestion_HALAOUI.BDD
{
    public partial class Party
    {
        public int Id { get; set; }
        public string NomPartie { get; set; }
        public int NbJoueurs { get; set; }
        public int? IdSalle { get; set; }
        public int NbObstacle { get; set; }
        public DateTime DatePartie { get; set; }
        public int Reussite { get; set; }
    }
}
