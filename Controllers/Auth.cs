using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Freshprints.Data;
using Freshprints.JWT;
using Microsoft.AspNetCore.Mvc;

namespace Freshprints.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class Auth : Controller
    {
        
        private readonly IJwtAuthenticationManager _jwtAuthenticationManager;

        public Auth(IJwtAuthenticationManager jwtAuthenticationManager)
        {
            _jwtAuthenticationManager = jwtAuthenticationManager;
        }
        
        // POST
        [HttpPost("createUser")]
        public IActionResult Register([FromBody] User user)
        {
            if (user.UserName == null)
            {
                return NotFound("Username not found");
            }

            if (user.Password == null)
            {
                return NotFound("Password not found");
            }

            if (user.Email == null)
            {
                return NotFound("Email not found");
            }
            if (user.PhoneNumber == null)
            {
                return NotFound("PhoneNumber not found");
            }
            if (user.FullName == null)
            {
                return NotFound("FullName not found");
            }
            UsersMockRepository.Users.Add(user);
            return Ok("Successfully Registered");
        }
        
        // POST
        [HttpPost("validateUser")]
        public IActionResult ValidateUser([FromBody] Dictionary<string, string> user)
        {
            if (!user.ContainsKey("UserName"))
            {
                return BadRequest("Username not found in the request body");
            }

            if (!user.ContainsKey("Password"))
            {
                return BadRequest("Password not found in the request body");
            }
            try
            {
                var userNameAns = UsersMockRepository.Users.Any(t =>
                    (t.UserName == user["UserName"]));
                var passwordAns = UsersMockRepository.Users.Any(t =>
                    (t.Password == user["Password"]));
                if (!userNameAns)
                {
                    return NotFound("User Not Found");
                }

                if (!passwordAns)
                {
                    return Unauthorized("Invalid password");
                }

                var token = _jwtAuthenticationManager.Authenticate(user["UserName"], user["Password"]);
                if (token == null)
                {
                    return Unauthorized();
                }

                return Ok(new Dictionary<string, string> {{"bearer_token", token}});
            }
            catch (KeyNotFoundException e)
            {
                return Ok("Fields in the body are inappropriate");
            }

        }
         
//TODO validate pwd
    }
    
}