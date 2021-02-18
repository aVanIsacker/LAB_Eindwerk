using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public partial class Contact
    {
        public Contact()        //contact has many facturen
        {
            Factuur = new HashSet<Factuur>();
        }

        public int ContactNr { get; set; }
        public string Btwnr { get; set; }
        public string Straat { get; set; }
        public int Postcode { get; set; }
        public string Gemeente { get; set; }

        public virtual Klant Klant { get; set; }                //ContactNrNavigation in classe klant
        public virtual Leverancier Leverancier { get; set; }    //ContactNrNavigation in classe leverancier
        public virtual ICollection<Factuur> Factuur { get; set; }   //contact has many facturen
    }
}
