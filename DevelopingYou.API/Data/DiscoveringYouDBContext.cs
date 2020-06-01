using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopingYou.API.Data
{
    public class DiscoveringYouDBContext : DbContext
    {
        public DiscoveringYouDBContext(DbContextOptions options) : base(options)
        {
        }
    }
}
