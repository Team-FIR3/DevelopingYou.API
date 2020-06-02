using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopingYou.API.Models
{
    public class Instance
    {
        public int Id { get; set; }

        public int GoalId { get; set; }

       // public string Date { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string Comment { get; set; }



        [Required]
        public Goal Goal { get; set; }

    }
}
