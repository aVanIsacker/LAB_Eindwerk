using Contracts;
using Entities;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    internal class LeverancierRepository : RepositoryBase<Leverancier>, ILeverancierRepository
    {
        //private RepositoryContext _repositoryContext;

        public LeverancierRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            //_repositoryContext = repositoryContext;
        }

        public void CreateLeverancier(Leverancier leverancier)
        {
            Create(leverancier);
        }

        public void DeleteLeverancier(Leverancier leverancier)
        {
            Delete(leverancier);
        }

        public IEnumerable<Leverancier> GetAllLeveranciers(bool trackChanges)
        {
            return FindAll(trackChanges).OrderBy(s => s.NaamBedrijf).ToList();
        }

        public Leverancier GetLeverancier(int leverancierNr, bool trackChanges)
        {
            return FindByCondition(l => l.LeverancierNr.Equals(leverancierNr), trackChanges).SingleOrDefault();
        }
    }
}