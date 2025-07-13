using EmployeeApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [Route("api/Emp")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Debojyoti Jha", Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Pulkit Prakhar", Department = "HR", Salary = 45000 },
            new Employee { Id = 3, Name = "Ritesh Sharma", Department = "Finance", Salary = 55000 }
        };
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Employee>))]
        public IActionResult Get()
        {
            return Ok(employees);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Employee))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Employee))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest();
            }

            employee.Id = employees.Max(e => e.Id) + 1;
            employees.Add(employee);

            return CreatedAtAction(nameof(Get), new { id = employee.Id }, employee);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Put(int id, [FromBody] Employee employee)
        {
            if (employee == null || employee.Id != id)
            {
                return BadRequest();
            }

            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);
            if (existingEmployee == null)
            {
                return NotFound();
            }

            existingEmployee.Name = employee.Name;
            existingEmployee.Department = employee.Department;
            existingEmployee.Salary = employee.Salary;

            return NoContent();
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            employees.Remove(employee);
            return NoContent();
        }
    }
}