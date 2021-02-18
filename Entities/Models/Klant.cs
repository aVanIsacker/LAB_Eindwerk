using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public partial class Klant
    {
        public int ContactNr { get; set; }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }

        public virtual Contact ContactNrNavigation { get; set; }
    }
}
