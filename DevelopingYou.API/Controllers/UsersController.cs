using DevelopingYou.API.Data.Interfaces;
using DevelopingYou.API.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DevelopingYou.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository userRepository;

        public UsersController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpPost("Register")]
        [AllowAnonymous]
        public async Task<ActionResult<UserWithToken>> Register(RegisterUser data)
        {
            var user = await userRepository.Register(data, ModelState);
            if (user == null)
            {
                return BadRequest(new ValidationProblemDetails(ModelState));
            }

            return user;
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<ActionResult<UserWithToken>> Login (LoginUser data)
        {
            var user = await userRepository.Authenticate(data.UserName, data.Password);
            if (user == null)
            {
                return Unauthorized();
            }

            return user;
        }

        /// <summary>
        /// This route doesn't function correctly yet but I don't think we need it formally
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet("Self")]
        public async Task<ActionResult<UserDTO>> Self()
        {

            return await userRepository.GetUser(User);
        }
    }
}
