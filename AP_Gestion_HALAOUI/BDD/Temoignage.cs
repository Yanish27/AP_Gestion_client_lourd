using System;
using System.Collections.Generic;

#nullable disable

namespace AP_Gestion_HALAOUI.BDD
{
    public partial class Temoignage
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public string Auteur { get; set; }
        public DateTime Date { get; set; }
    }
}
