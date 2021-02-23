using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IKasVerrichtingRepository
    {
        IEnumerable<KasVerrichting> GetAllKasVerrichtingen(bool trackChanges);
        KasVerrichting GetKasVerrichting(int kasNr, bool trackChanges);
        void CreateKasVerrichting(KasVerrichting kasVerrichting);
        void DeleteKasVerrichting(KasVerrichting kasVerrichting);
    }
}
