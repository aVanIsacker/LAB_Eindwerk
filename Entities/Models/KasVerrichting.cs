using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public partial class KasVerrichting
    {
        public int KasNr { get; set; }
        public int? FactuurNr { get; set; }
        public int TypeBetalingId { get; set; }
        public decimal BedragExcl { get; set; }
        public decimal BtwTarief { get; set; }

        public virtual Factuur Factuur { get; set; }                   //many kasverrichting to 1 factuur 
        public virtual TypeBetaling TypeBetaling { get; set; }        //many kasverrichting to 1 typebetaling
    }
}
