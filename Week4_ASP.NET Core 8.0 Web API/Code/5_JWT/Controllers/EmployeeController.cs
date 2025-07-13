using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MyWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "Admin")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("You are authorized as Admin.");
        }

        [HttpGet("me")]
        public IActionResult GetUserRoles()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            var roles = identity?.FindAll(ClaimTypes.Role).Select(r => r.Value).ToList();
            return Ok(new { roles });
        }
    }
}
