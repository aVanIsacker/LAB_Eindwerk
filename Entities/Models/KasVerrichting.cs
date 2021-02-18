using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public partial class KasVerrichting
    {
        public int KasNrId { get; set; }
        public int? FactuurNr { get; set; }
        public int TypeBetaling { get; set; }
        public decimal BedragExcl { get; set; }
        public decimal BtwTarief { get; set; }

        public virtual Factuur FactuurNrNavigation { get; set; }                   //many kasverrichting to 1 factuur 
        public virtual TypeBetaling TypeBetalingNavigation { get; set; }        //many kasverrichting to 1 typebetaling
    }
}
