using Contracts;
using Entities;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    internal class KasVerrichtingRepository : RepositoryBase<KasVerrichting> ,IKasVerrichtingRepository
    {
        //private RepositoryContext _repositoryContext;

        public KasVerrichtingRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            //_repositoryContext = repositoryContext;
        }

        public void CreateKasVerrichting(KasVerrichting kasVerrichting)
        {
            Create(kasVerrichting);
        }

        public void DeleteKasVerrichting(KasVerrichting kasVerrichting)
        {
            Delete(kasVerrichting);
        }

        public IEnumerable<KasVerrichting> GetAllKasVerrichtingen(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public KasVerrichting GetKasVerrichting(int kasNr, bool trackChanges)
        {
            return FindByCondition(s => s.KasNr.Equals(kasNr), trackChanges).SingleOrDefault();
        }
    }
}