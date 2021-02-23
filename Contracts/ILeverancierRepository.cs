using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface ILeverancierRepository
    {
        IEnumerable<Leverancier> GetAllLeveranciers(bool trackChanges);
        Leverancier GetLeverancier(int leverancierNr, bool trackChanges);
        void CreateLeverancier(Leverancier leverancier);
        void DeleteLeverancier(Leverancier leverancier);
    }
}
