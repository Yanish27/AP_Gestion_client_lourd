using System;
using System.Collections.Generic;

#nullable disable

namespace AP_Gestion_HALAOUI.BDD
{
    public partial class UsersAdmin
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }
        public int Grade { get; set; }
    }
}
