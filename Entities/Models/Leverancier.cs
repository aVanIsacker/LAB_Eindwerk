using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public partial class Leverancier
    {
        public int LeverancierNr { get; set; }
        public string NaamBedrijf { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
