using Contracts;
using Entities;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    internal class TypeBetalingRepository : RepositoryBase<TypeBetaling>, ITypeBetalingRepository
    {
        //private RepositoryContext _repositoryContext;

        public TypeBetalingRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            //_repositoryContext = repositoryContext;
        }

        public void CreateTypeBetaling(TypeBetaling typeBetaling)
        {
            Create(typeBetaling);
        }

        public void DeleteTypeBetaling(TypeBetaling typeBetaling)
        {
            Delete(typeBetaling);
        }

        public IEnumerable<TypeBetaling> GetAllTypeBetalingen(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public TypeBetaling GetTypeBetaling(int id, bool trackChanges)
        {
            return FindByCondition(s => s.Id.Equals(id), trackChanges).SingleOrDefault();
        }
    }
}