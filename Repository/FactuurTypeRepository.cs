using Contracts;
using Entities;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    internal class FactuurTypeRepository : RepositoryBase<FactuurType> ,IFactuurTypeRepository
    {
        //private RepositoryContext _repositoryContext;

        public FactuurTypeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            //_repositoryContext = repositoryContext;
        }

        public void CreateFactuurType(FactuurType factuurType)
        {
            Create(factuurType);
        }

        public void DeleteFactuurType(FactuurType factuurType)
        {
            Delete(factuurType);
        }

        public IEnumerable<FactuurType> GetAllFactuurTypes(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public FactuurType GetFactuurType(int id, bool trackChanges)
        {
            return FindByCondition(s => s.Id.Equals(id), trackChanges).SingleOrDefault();
        }
    }
}