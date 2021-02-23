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
    public class FactuurTypeController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public FactuurTypeController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetFactuurTypes()
        {
            var FactuurTypes = _repository.FactuurType.GetAllFactuurTypes(false);//query is sneller wanneer trackchanges af staat
            return Ok(FactuurTypes); //status OK = code 200       
        }

        [HttpGet("{id}")]
        public IActionResult GetFactuurType(int id)
        {
            var FactuurType = _repository.FactuurType.GetFactuurType(id, false);
            if (FactuurType == null)
            {
                return NotFound(); //HTTP Response met status code 404 -- not found 
            }
            return Ok(FactuurType); //HTTP Response met status code 200 --OK
        }
    }
}
