using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SuperHeroStrikesBack.Models;

namespace SuperHeroStrikesBack.Controllers
{
    
    /// <summary>
    /// Heroes Controller
    /// </summary>
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class HeroesController : Controller
    {
        /// <summary>
        /// Initializes an instances of the Heroes Controller
        /// </summary>
        public HeroesController()
        {
        }

        /// <summary>
        /// Generate a super hero name based on first and last name
        /// </summary>
        /// <param name="firstName">First Name</param>
        /// <param name="lastName">Last Name</param>
        /// <returns>Instance of Person class</returns>
        /// <response code="200">Returns the newly created item</response>
        /// <response code="400">If the first name or last name is null</response>   
        [HttpGet("{firstName}/{lastName}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<Person> Get([Required]string firstName, [Required]string lastName)
        {
            if (String.IsNullOrEmpty(firstName) || String.IsNullOrEmpty(firstName.Trim()))
                return BadRequest("firstName cannot be blank");

            if (String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(lastName.Trim()))
                return BadRequest("lastName cannot be blank");

            var person = new Person()
            {
                FirstName = firstName,
                LastName = lastName
            };

            person.SetHeroName();
            return new ActionResult<Person>(person);
        }

    }
}
