using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Controllers
{
    //add reference to contracts

    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public ContactController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetContacts()
        {
            var contacts = _repository.Contact.GetAllContacts(false);//query is sneller wanneer trackchanges af staat
            return Ok(contacts); //status OK = code 200       
        }

        [HttpGet("{contactNr}")]
        public IActionResult GetContact(int contactNr)
        {
            var contact = _repository.Contact.GetContact(contactNr, false);
            if (contact == null)
            {
                return NotFound(); //HTTP Response met status code 404 -- not found 
            }
            return Ok(contact); //HTTP Response met status code 200 --OK
        }
    }
}
