using System;
using System.Collections.Generic;

#nullable disable

namespace AP_Gestion_HALAOUI.BDD
{
    public partial class Tarification
    {
        public int IdTarif { get; set; }
        public int PrixHeure { get; set; }
        public int PrixObstacle { get; set; }
        public int PrixJoueur { get; set; }
        public int IdSalle { get; set; }
    }
}
