using System;

namespace DevelopingYou.API.Models.DTOs
{
    public class InstanceDTO
    {
        public int Id { get; set; }

        public string GoalTitle { get; set; }

        //  public string Date { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Comment { get; set; }
    }
}
