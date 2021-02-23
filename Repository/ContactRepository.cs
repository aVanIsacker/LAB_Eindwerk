using Contracts;
using Entities;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public  class ContactRepository : RepositoryBase<Contact>, IContactRepository
    {
        //private RepositoryContext _repositoryContext;

        public ContactRepository(RepositoryContext repositoryContext) : base(repositoryContext)     //komt van base
        {
            //_repositoryContext = repositoryContext;
        }



        public void CreateContact(Contact contact)
        {
            Create(contact);
        }

        public void DeleteContact(Contact contact)
        {
            Delete(contact);
        }

        public IEnumerable<Contact> GetAllContacts(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public Contact GetContact(int contactNr, bool trackChanges)
        {
            return FindByCondition(c => c.ContactNr.Equals(contactNr), trackChanges).SingleOrDefault();
        }
    }
}