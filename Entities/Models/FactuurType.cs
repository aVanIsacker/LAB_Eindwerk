using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public partial class FactuurType
    {
        public FactuurType()        //factuurtype has many facturen
        {
            Factuur = new HashSet<Factuur>();
        }

        public int Id { get; set; }
        public string FactuurType1 { get; set; }

        public virtual ICollection<Factuur> Factuur { get; set; }   //factuurtype has many facturen
    }
}
