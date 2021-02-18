using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public partial class TypeBetaling 
    {
        public TypeBetaling() //1 typebetaling to many kasverrichtingen
        {
            KasVerrichting = new HashSet<KasVerrichting>();
        }

        public int Id { get; set; }
        public string BetalingsType { get; set; }       //contant, bankcontact, overschrijving?

        public virtual ICollection<KasVerrichting> KasVerrichting { get; set; }     //1 typebetaling to many kasverrichtingen
    }
}
