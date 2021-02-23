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
    public class FactuurController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public FactuurController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetFacturen()
        {
            var facturen = _repository.Factuur.GetAllFacturen(false);//query is sneller wanneer trackchanges af staat
            return Ok(facturen); //status OK = code 200       
        }

        [HttpGet("{factuurNr}")]
        public IActionResult GetFactuur(int factuurNr)
        {
            var factuur = _repository.Factuur.GetFactuur(factuurNr, trackChanges: false);
            if (factuur == null)
            {
                return NotFound();
            }
            else
            {

                return Ok(factuur);
            }
        }


    }
}
