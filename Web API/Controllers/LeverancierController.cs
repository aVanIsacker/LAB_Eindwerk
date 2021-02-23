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
    public class LeverancierController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public LeverancierController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetLeveranciers()
        {
            var leveranciers = _repository.Leverancier.GetAllLeveranciers(false);//query is sneller wanneer trackchanges af staat
            return Ok(leveranciers); //status OK = code 200       
        }

        [HttpGet("{leverancierNr}")]
        public IActionResult GetLeverancier(int leverancierNr)
        {
            var leverancier = _repository.Leverancier.GetLeverancier(leverancierNr, false);
            if (leverancier == null)
            {
                return NotFound(); //HTTP Response met status code 404 -- not found 
            }
            return Ok(leverancier); //HTTP Response met status code 200 --OK
        }

    }
}
