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
    public class ProvenceController : ControllerBase
    {

        private readonly IProvenceRepository _provenceRepository;


        public ProvenceController(IProvenceRepository provenceRepository)
        {
            _provenceRepository = provenceRepository;
        }


        // GET: api/<ProvenceController>
        [HttpGet]
        public IEnumerable<Provence> Get()
        {
            return _provenceRepository.GetAllProvences();
        }

        // GET api/<ProvenceController>/5
        [HttpGet("{id}")]
        public Provence Get(int id)
        {
            return _provenceRepository.GetProvenceById(id);
        }

        // POST api/<ProvenceController>
        [HttpPost]
        public void Post([FromBody] Provence provence)
        {
            _provenceRepository.InsertProvence(provence);
            _provenceRepository.SaveProvence();
        }

        // PUT api/<ProvenceController>/5
        [HttpPut("{id}")]
        public void Put([FromForm] Provence provence)
        {
            _provenceRepository.InsertProvence(provence);
            _provenceRepository.SaveProvence();
        }

        // DELETE api/<ProvenceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _provenceRepository.DeleteProvence(id);
            _provenceRepository.SaveProvence();
        }
    }
}
