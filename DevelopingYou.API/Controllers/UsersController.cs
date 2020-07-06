using DevelopingYou.API.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
    }
}
