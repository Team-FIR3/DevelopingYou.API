using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace DevelopingYou.API.Models
{
    public class User : IdentityUser
    {
        public List<Goal> Goals { get; set; }
    }
}
