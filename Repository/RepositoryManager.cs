using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
   
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;

        private IContactRepository _contactRepository;
        private IFactuurRepository _factuurRepository;
        private IFactuurTypeRepository _factuurTypeRepository;
        private IKasVerrichtingRepository _kasVerrichtingRepository;
        private IKlantRepository _klantRepository;
        private ILeverancierRepository _leverancierRepository;
        private ITypeBetalingRepository _typeBetalingRepository;

        
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        //generate in new file

        public IContactRepository Contact
        {
            get
            {
                if (_contactRepository == null)
                    _contactRepository = new ContactRepository(_repositoryContext);
                return _contactRepository;
            }
        }
        

        public IFactuurRepository Factuur
        {
            get
            {
                if (_factuurRepository == null)
                    _factuurRepository = new FactuurRepository(_repositoryContext);
                return _factuurRepository;
            }
        }

        public IFactuurTypeRepository FactuurType
        {
            get
            {
                if (_factuurTypeRepository == null)
                    _factuurTypeRepository = new FactuurTypeRepository(_repositoryContext);
                return _factuurTypeRepository;
            }
        }

        public IKasVerrichtingRepository KasVerrichting
        {
            get
            {
                if (_kasVerrichtingRepository == null)
                    _kasVerrichtingRepository = new KasVerrichtingRepository(_repositoryContext);
                return _kasVerrichtingRepository;
            }
        }

        public IKlantRepository Klant
        {
            get
            {
                if (_klantRepository == null)
                    _klantRepository = new KlantRepository(_repositoryContext);
                return _klantRepository;
            }
        }

        public ILeverancierRepository Leverancier
        {
            get
            {
                if (_leverancierRepository == null)
                    _leverancierRepository = new LeverancierRepository(_repositoryContext);
                return _leverancierRepository;
            }
        }

        public ITypeBetalingRepository TypeBetaling
        {
            get
            {
                if (_typeBetalingRepository == null)
                    _typeBetalingRepository = new TypeBetalingRepository(_repositoryContext);
                return _typeBetalingRepository;
            }
        }

        public void Save()
        {
            _repositoryContext.SaveChanges();
        }
    }
}

//verander de nieuwe repository classes van internal naar public en maak afgeleide van repositorybase
//daarna controllers aanmaken in main project (API controller empty template)