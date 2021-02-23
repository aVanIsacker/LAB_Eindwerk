using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IContactRepository Contact { get; }
        IFactuurRepository Factuur { get; }
        IFactuurTypeRepository FactuurType { get; }
        IKasVerrichtingRepository KasVerrichting { get; }
        IKlantRepository Klant { get; }
        ILeverancierRepository Leverancier { get; }
        ITypeBetalingRepository TypeBetaling { get; }  

        void Save();

        //interfaces aanmaken (generate in new file?)
        //daarna in repositories ook base en manager aanmaken
    }
}
