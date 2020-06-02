using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopingYou.API.Models.DTOs
{
    public class InstanceDTO
    {
        public int Id { get; set; }

      //  public string Date { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string Comment { get; set; }
    }
}
