using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IKlantRepository
    {
        IEnumerable<Klant> GetAllKlanten(bool trackChanges);
        Klant GetKlant(int klantNr, bool trackChanges);
        void CreateKlant(Klant klant);
        void DeleteKlant(Klant klant);
    }
}
