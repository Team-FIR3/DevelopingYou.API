using System;
using System.ComponentModel.DataAnnotations;

namespace DevelopingYou.API.Models
{
    public class Instance
    {
        public int Id { get; set; }

        public int GoalId { get; set; }

        public string GoalTitle { get; set; }

        // public string Date { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Comment { get; set; }



        [Required]
        public Goal Goal { get; set; }

    }
}
