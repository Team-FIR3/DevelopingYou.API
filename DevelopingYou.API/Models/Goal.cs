using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevelopingYou.API.Models
{
    public class Goal
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public decimal StartValue { get; set; }

        [Required]
        public decimal TargetValue { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public Category Category { get; set; }

        public ICollection<Instance> Instances { get; set; }

        public bool Completed { get; set; }

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
