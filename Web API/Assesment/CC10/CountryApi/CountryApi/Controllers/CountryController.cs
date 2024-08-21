using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CountryApi.Models;

namespace CountryApi.Controllers
{
    public class CountryController : ApiController
    {
        private static List<Country> countries = new List<Country>
        {
            new Country { ID = 1, CountryName = "India", Capital = "New Delhi" },
            new Country { ID = 2, CountryName = "USA", Capital = "Washington D.C." },
            new Country { ID = 3, CountryName = "Japan", Capital = "Tokyo" },
            new Country { ID = 4, CountryName = "South Korea", Capital = "Seoul" }
        };
        // GET
        [HttpGet]
        public IEnumerable<Country> GetCountries()
        {
            return countries;
        }
        // GET
        [HttpGet]
        public IHttpActionResult GetCountry(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }
        // POST
        [HttpPost]
        public IHttpActionResult PostCountry([FromBody] Country country)
        {
            if (country == null)
            {
                return BadRequest("Invalid country data.");
            }
            countries.Add(country);
            return CreatedAtRoute("DefaultApi", new { id = country.ID }, country);
        }
        // PUT
        [HttpPut]
        public IHttpActionResult PutCountry(int id, [FromBody] Country updatedCountry)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            country.CountryName = updatedCountry.CountryName;
            country.Capital = updatedCountry.Capital;
            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }
        // DELETE
        [HttpDelete]
        public IHttpActionResult DeleteCountry(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            countries.Remove(country);
            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }
    }
}
