using System.Collections.Generic;

namespace DevelopingYou.API.Models.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<Goal> Goals { get; set; }
    }
}
