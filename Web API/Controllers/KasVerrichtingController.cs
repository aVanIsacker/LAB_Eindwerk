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
    public class KasVerrichtingController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public KasVerrichtingController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetKasVerrichtingen()
        {
            var kasVerrichtingen = _repository.KasVerrichting.GetAllKasVerrichtingen(false);//query is sneller wanneer trackchanges af staat
            return Ok(kasVerrichtingen); //status OK = code 200       
        }

        [HttpGet("{kasNr}")]
        public IActionResult GetKasVerrichting(int kasNr)
        {
            var kasVerrichting = _repository.KasVerrichting.GetKasVerrichting(kasNr, false);
            if (kasVerrichting == null)
            {
                return NotFound(); //HTTP Response met status code 404 -- not found 
            }
            return Ok(kasVerrichting); //HTTP Response met status code 200 --OK
        }
    }
}
