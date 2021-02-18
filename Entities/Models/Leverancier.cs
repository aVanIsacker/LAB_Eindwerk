using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public partial class Leverancier
    {
        public int ContactNr { get; set; }
        public string NaamBedrijf { get; set; }

        public virtual Contact ContactNrNavigation { get; set; }
    }
}
