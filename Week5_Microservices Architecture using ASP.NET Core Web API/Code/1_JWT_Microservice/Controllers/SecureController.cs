using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Microservice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] 
    public class SecureController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "This is a secured endpoint!" });
        }

        [HttpGet("admin")]
        [Authorize(Roles = "Admin")] 
        public IActionResult AdminEndpoint()
        {
            return Ok(new { Message = "This is an admin-only endpoint!" });
        }
    }
}
