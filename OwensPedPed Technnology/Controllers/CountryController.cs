using BackEndServices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using OwensPedPed.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OwensPedPed_Technnology.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {

        private readonly ICountryRepository _countryRepository;


        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }


        // GET: api/<CountryController>
        [HttpGet]
        public IEnumerable<Country> Get()
        {
            return _countryRepository.GetAllCountries();
        }

        // GET api/<CountryController>/5
        [HttpGet("{id}")]
        public Country Get(int id)
        {
            return _countryRepository.GetCountryById(id);
        }

        // POST api/<CountryController>
        [HttpPost]
        public void Post([FromForm] Country country)
        {
            _countryRepository.InsertCountry(country);
            _countryRepository.SaveCountry();
        }

        // PUT api/<CountryController>/5
        [HttpPut("{id}")]
        public void Put([FromForm] Country country)
        {
            _countryRepository.UpdateCountry(country);
            _countryRepository.SaveCountry();
        }

        // DELETE api/<CountryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _countryRepository.DeleteCountry(id);
            _countryRepository.SaveCountry();
        }
    }
}
