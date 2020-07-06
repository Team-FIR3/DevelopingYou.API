using System.ComponentModel.DataAnnotations;

namespace DevelopingYou.API.Models.DTOs
{
    public class LoginUser
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
