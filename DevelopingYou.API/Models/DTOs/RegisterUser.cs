using System.ComponentModel.DataAnnotations;

namespace DevelopingYou.API.Models.DTOs
{
    public class RegisterUser
    {
        [Required]
        public string Email { get; set; }
    }
}
