using Contracts;
using Entities;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    internal class KlantRepository : RepositoryBase<Klant> ,IKlantRepository
    {
        //private RepositoryContext _repositoryContext;

        public KlantRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            //_repositoryContext = repositoryContext;
        }

        public void CreateKlant(Klant klant)
        {
            Create(klant);
        }

        public void DeleteKlant(Klant klant)
        {
            Delete(klant);
        }

        public IEnumerable<Klant> GetAllKlanten(bool trackChanges)
        {
            return FindAll(trackChanges).OrderBy(s => s.Familienaam).ThenBy(s => s.Voornaam).ToList();
        }

        public Klant GetKlant(int klantNr, bool trackChanges)
        {
            return FindByCondition(k => k.KlantNr.Equals(klantNr), trackChanges).SingleOrDefault();
        }
    }
}