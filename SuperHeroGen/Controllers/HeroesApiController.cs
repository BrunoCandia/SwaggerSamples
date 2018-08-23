using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroGen.Models;

namespace SuperHeroGen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    [Produces("application/json")]
    public class HeroesApiController : ControllerBase
    {
        [HttpGet("{firstName}/{lastName}")]
        public Person Get(string firstName, string lastName)
        {
            var person = new Person { FirstName = firstName, LastName = lastName };

            //person.SetHeroName();

            return person;
        }
    }
}