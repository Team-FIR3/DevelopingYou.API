using System;
using System.Collections.Generic;

namespace DevelopingYou.API.Models.DTOs
{
    public class GoalDTO
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string Title { get; set; }

        public decimal StartValue { get; set; }

        public decimal TargetValue { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Category Category { get; set; }

        public List<InstanceDTO> Instances { get; set; }

        public bool Completed { get; set; }
    }
}
