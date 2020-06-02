using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopingYou.API.Models
{
    public class Instance
    {
        public int GoalId { get; set; }

        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        [Display(Name = "Date Goal Started")]
        public DateTime StartTime { get; set; }

        [Display(Name = "Ending Goal Time")]
        public DateTime EndTime { get; set; }

        [Display(Name = "Comments")]
        public string Comment { get; set; }

    }
}
