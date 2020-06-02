using DevelopingYou.API.Models;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Goal>()
                .HasData(new Goal
                {
                    Id = 1,
                    Title = "Less social media",
                    StartValue = 5,
                    TargetValue = 2,
                    Category = Category.Technological,
                });
        }

        public DbSet<Goal> Goal { get; set; }
        public DbSet<Instance> Instance { get; set; }
    }
}
