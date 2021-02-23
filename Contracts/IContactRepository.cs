using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetAllContacts(bool trackChanges);
        Contact GetContact(int contactNr, bool trackChanges);
        void CreateContact(Contact contact);
        void DeleteContact(Contact contact);
    }

    //add reference to entities
}
