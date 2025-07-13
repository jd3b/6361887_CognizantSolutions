using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using _3_EmployeeApi.Filters;
using System;
using System.Linq;
using System.Collections.Generic;
using _3_EmployeeApi.Models;

namespace _3_EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [CustomAuthFilter]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees = new List<Employee>();

        public EmployeeController()
        {
            if (_employees.Count == 0)
            {
                _employees = GetStandardEmployeeList();
            }
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Debojyoti Jha",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "IT" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "ASP.NET" }
                    },
                    DateOfBirth = new DateTime(2003, 4, 23)
                },
                new Employee
                {
                    Id = 2,
                    Name = "Puilkit Prakhar",
                    Salary = 60000,
                    Permanent = false,
                    Department = new Department { Id = 2, Name = "HR" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 3, Name = "Recruiting" }
                    },
                    DateOfBirth = new DateTime(2002, 12, 2)
                }
            };
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(_employees);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Employee> Get(int id)
        {
            try
            {
                var employee = _employees.FirstOrDefault(e => e.Id == id);
                if (employee == null)
                {
                    return NotFound();
                }
                return Ok(employee);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving employee with ID {id}", ex);
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Employee> Post([FromBody] Employee employee)
        {
            try
            {
                if (employee == null)
                {
                    return BadRequest("Employee data is required");
                }

                employee.Id = _employees.Any() ? _employees.Max(e => e.Id) + 1 : 1;
                _employees.Add(employee);

                return CreatedAtAction(nameof(Get), new { id = employee.Id }, employee);
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating new employee", ex);
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Put(int id, [FromBody] Employee employee)
        {
            try
            {
                if (employee == null || employee.Id != id)
                {
                    return BadRequest("Invalid employee data");
                }

                var existingEmployee = _employees.FirstOrDefault(e => e.Id == id);
                if (existingEmployee == null)
                {
                    return NotFound();
                }

                existingEmployee.Name = employee.Name;
                existingEmployee.Salary = employee.Salary;
                existingEmployee.Permanent = employee.Permanent;
                existingEmployee.Department = employee.Department;
                existingEmployee.Skills = employee.Skills;
                existingEmployee.DateOfBirth = employee.DateOfBirth;

                return NoContent();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating employee with ID {id}", ex);
            }
        }
    }
}