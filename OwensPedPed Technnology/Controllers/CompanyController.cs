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
    public class CompanyController : ControllerBase
    {

        private readonly ICompanyRepository _companyRepository;


        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        // GET: api/<CompanyController>
        [HttpGet]
        public IEnumerable<Company> Get()
        {
            return _companyRepository.GetAllCompanies();
        }

        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public Company Get(int id)
        {
            return _companyRepository.GetCompanyById(id);
        }

        // POST api/<CompanyController>
        [HttpPost]
        public void Post([FromForm] Company company)
        {
            _companyRepository.InsertCompany(company);
            _companyRepository.SaveCompany();
        }

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public void Put([FromForm] Company company)
        {
            _companyRepository.UpdateCompany(company);
            _companyRepository.SaveCompany();
        }

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _companyRepository.DeleteCompany(id);
            _companyRepository.SaveCompany();
        }
    }
}
