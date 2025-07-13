using _4_CRUD_EmployeeApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace _4_CRUD_EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees = new()
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
                DateOfBirth = new DateTime(2004, 4, 23)
            }
        };

        [HttpGet]
        public ActionResult<List<Employee>> GetAll()
        {
            return Ok(_employees);
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetById(int id)
        {
            if (id <= 0) return BadRequest("Invalid employee id");

            var employee = _employees.FirstOrDefault(e => e.Id == id);
            return employee == null ? NotFound() : Ok(employee);
        }

        [HttpPost]
        public ActionResult<Employee> Create([FromBody] Employee employee)
        {
            if (employee == null) return BadRequest();

            employee.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(employee);

            return CreatedAtAction(nameof(GetById), new { id = employee.Id }, employee);
        }

        [HttpPut("{id}")]
        public ActionResult<Employee> Update(int id, [FromBody] Employee employee)
        {
            if (id <= 0) return BadRequest("Invalid employee id");

            var existing = _employees.FirstOrDefault(e => e.Id == id);
            if (existing == null) return BadRequest("Invalid employee id");

            existing.Name = employee.Name;
            existing.Salary = employee.Salary;
            existing.Permanent = employee.Permanent;
            existing.Department = employee.Department;
            existing.Skills = employee.Skills;
            existing.DateOfBirth = employee.DateOfBirth;

            return Ok(existing);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id <= 0) return BadRequest("Invalid employee id");

            var employee = _employees.FirstOrDefault(e => e.Id == id);
            if (employee == null) return BadRequest("Invalid employee id");

            _employees.Remove(employee);
            return NoContent();
        }
    }
}