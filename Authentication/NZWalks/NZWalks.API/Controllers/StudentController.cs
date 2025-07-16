using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet("krishna")]
        public IActionResult GetAllStudent()
        {
            string[] students = new string[] {"krishna", "Parth", "Babe"};
            return Ok(students);
        }
        
    }
}
