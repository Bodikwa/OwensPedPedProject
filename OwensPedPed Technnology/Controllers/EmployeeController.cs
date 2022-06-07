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
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeRepository _employeeRepository;


        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employeeRepository.GetAllEmployees();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _employeeRepository.GetEmployeeById(id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromForm] Employee employee)
        {
            _employeeRepository.InsertEmployee(employee);
            _employeeRepository.SaveEmployee();
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put([FromForm] Employee employee)
        {
            _employeeRepository.UpdateEmployee(employee);
            _employeeRepository.SaveEmployee();
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeeRepository.DeleteEmployee(id);
            _employeeRepository.SaveEmployee();
        }
    }
}
