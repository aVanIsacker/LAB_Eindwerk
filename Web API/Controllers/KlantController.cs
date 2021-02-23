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
    [Route("api/[controller]")]
    [ApiController]
    public class KlantController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public KlantController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetKlanten()
        {
            var klanten = _repository.Klant.GetAllKlanten(false);//query is sneller wanneer trackchanges af staat
            return Ok(klanten); //status OK = code 200       
        }

        [HttpGet("{klantNr}")]
        public IActionResult GetKlant(int klantNr)
        {
            var klant = _repository.Klant.GetKlant(klantNr, false);
            if (klant == null)
            {
                return NotFound(); //HTTP Response met status code 404 -- not found 
            }
            return Ok(klant); //HTTP Response met status code 200 --OK
        }
    }
}
