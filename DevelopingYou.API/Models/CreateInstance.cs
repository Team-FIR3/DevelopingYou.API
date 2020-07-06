using System;
using System.ComponentModel.DataAnnotations;

namespace DevelopingYou.API.Models
{
    public class CreateInstance
    {
        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public string Comment { get; set; }
    }
}
