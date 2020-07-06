﻿using System.ComponentModel.DataAnnotations;

namespace DevelopingYou.API.Models
{
    public class CreateUser
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
