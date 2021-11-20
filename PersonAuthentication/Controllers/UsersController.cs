using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonAuthentication.Models;
using PersonAuthentication.Services;


namespace PersonAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  //  [Authorize]  
    public class UsersController : ControllerBase
    {
        private IUserServices _userService;

        public UsersController(IUserServices userService)
        {
            _userService = userService;
        }

        [HttpPost("auth")]
        public IActionResult Authenticate(AuthenticationRequests model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });
         
            return Ok(response);
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}
