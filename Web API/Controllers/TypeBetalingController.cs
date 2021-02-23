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
    public class TypeBetalingController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public TypeBetalingController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetTypeBetaling()
        {
            var typeBetalingen = _repository.TypeBetaling.GetAllTypeBetalingen(false);//query is sneller wanneer trackchanges af staat
            return Ok(typeBetalingen); //status OK = code 200       
        }

        [HttpGet("{id}")]
        public IActionResult GetTypeBetaling(int id)
        {
            var typeBetaling = _repository.TypeBetaling.GetTypeBetaling(id, false);
            if (typeBetaling == null)
            {
                return NotFound(); //HTTP Response met status code 404 -- not found 
            }
            return Ok(typeBetaling); //HTTP Response met status code 200 --OK
        }

    }
}

//naar startup.cs
