using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public partial class Factuur
    {
        public Factuur()        //factuur has many kasverrichtingen
        {
            KasVerrichting = new HashSet<KasVerrichting>();
        }

        public int FactuurNr { get; set; }
        public int ContactId { get; set; }
        public decimal? Bedrag { get; set; }
        public int? Btwtarief { get; set; }
        public string Status { get; set; }
        public int Type { get; set; }
        public string Omschrijving { get; set; }
        public DateTime FactuurDatum { get; set; }
        public DateTime? BetaalDatum { get; set; }

        public virtual Contact Contact { get; set; }                //1 contact to many facturen
        public virtual FactuurType TypeNavigation { get; set; }     //1 factuurtype to many facturen
        public virtual ICollection<KasVerrichting> KasVerrichting { get; set; }         //factuur has many kasverrichtingen
    }
}
