using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopingYou.API.Models
{
    public class Goal
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public decimal StartValue { get; set; }

        [Required]
        public decimal TargetValue { get; set; }


        public Category Category { get; set; }
    }


    public enum Category
    {
        Fitness,
        Financial,
        Nutrition,
        Psychological,
        Technological,
        Work,
        Recreational,
        Other

    }
}
