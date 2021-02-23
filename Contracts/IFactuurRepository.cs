using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IFactuurRepository
    {
        IEnumerable<Factuur> GetAllFacturen(bool trackChanges);
        Factuur GetFactuur(int factuurNr, bool trackChanges);
        void CreateFactuur(Factuur factuur);
        void DeleteFactuur(Factuur factuur);
    }
}
