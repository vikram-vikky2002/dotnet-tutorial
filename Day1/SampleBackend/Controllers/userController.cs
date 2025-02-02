using Microsoft.AspNetCore.Mvc;
using SampleBackend.Data;
using SampleBackend.Models;

namespace SampleBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_context.Users.ToList());
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetUsers), new { id = user.Id }, user);
        }
    }
}
