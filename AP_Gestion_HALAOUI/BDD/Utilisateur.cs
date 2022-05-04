using System;
using System.Collections.Generic;

#nullable disable

namespace AP_Gestion_HALAOUI.BDD
{
    public partial class Utilisateur
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Motdepasse { get; set; }
        public int Grade { get; set; }
    }
}
