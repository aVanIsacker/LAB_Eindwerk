using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IFactuurTypeRepository
    {
        IEnumerable<FactuurType> GetAllFactuurTypes(bool trackChanges);
        FactuurType GetFactuurType(int id, bool trackChanges);
        void CreateFactuurType(FactuurType factuurType);
        void DeleteFactuurType(FactuurType factuurType);
    }
}
