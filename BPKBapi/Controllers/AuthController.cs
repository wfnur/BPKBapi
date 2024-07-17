using BPKBapi.Models.DTO;
using BPKBapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BPKBapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLoginDTO userLogin)
        {
            var user = _context.ms_user.SingleOrDefault(u => u.user_name == userLogin.UserName && u.password == userLogin.Password && u.is_active);

            if (user == null)
            {
                return Unauthorized("Invalid credentials or inactive user.");
            }

            HttpContext.Session.SetString("UserId", user.user_id.ToString());
            HttpContext.Session.SetString("UserName", user.user_name);

            return Ok("Login successful.");
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Ok("Logout successful.");
        }

        [HttpGet("current")]
        public IActionResult GetCurrentUser()
        {
            var userId = HttpContext.Session.GetString("UserId");
            var userName = HttpContext.Session.GetString("UserName");

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(userName))
            {
                return Unauthorized("No user is logged in.");
            }

            return Ok(new { UserId = userId, UserName = userName });
        }
    }
}
