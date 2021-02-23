using Contracts;
using Entities;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    internal class FactuurRepository : RepositoryBase<Factuur> ,IFactuurRepository
    {
        //private RepositoryContext _repositoryContext;

        public FactuurRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            //_repositoryContext = repositoryContext;
        }

        public void CreateFactuur(Factuur factuur)
        {
            Create(factuur);
        }

        public void DeleteFactuur(Factuur factuur)
        {
            Delete(factuur);
        }

        public IEnumerable<Factuur> GetAllFacturen(bool trackChanges)
        {
            return FindAll(trackChanges).OrderBy(s => s.Type).ThenBy(s => s.ContactId).ThenBy(s => s.FactuurDatum).ToList();
        }

        public Factuur GetFactuur(int factuurNr, bool trackChanges)
        {
            return FindByCondition(s => s.FactuurNr.Equals(factuurNr), trackChanges).SingleOrDefault();
        }
    }
}