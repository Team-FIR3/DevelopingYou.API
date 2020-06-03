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
                    StartDate = new DateTime(2020, 6, 12, 2, 45, 12, 000, DateTimeKind.Utc),
                    EndDate = new DateTime(2020, 6, 16, 1, 45, 12, 000, DateTimeKind.Utc),
                    Category = Category.Technological,
                });

            modelBuilder.Entity<Instance>()
                .HasData(new Instance
                  {
                      Id = 1,
                      GoalId = 1,
                      StartTime = new DateTime(2020, 6, 13, 4, 30, 12, 000, DateTimeKind.Utc),
                      EndTime = new DateTime(2020, 6, 13, 4, 45, 12, 000, DateTimeKind.Utc),
                    Comment = "Played Candy Crush instead of coding, could have utilized my time better",
                },
                new Instance
                {
                    Id = 2,
                    GoalId = 1,
                    StartTime = new DateTime(2020, 6, 13, 6, 05, 12, 000, DateTimeKind.Utc),
                    EndTime = new DateTime(2020, 6, 13, 7, 00, 12, 000, DateTimeKind.Utc),
                    Comment = "Video called sister and nephew, was fun",

                },
                new Instance
                {
                      Id = 3,
                      GoalId = 1,
                      StartTime = new DateTime(2020, 6, 13, 9, 00, 12, 000, DateTimeKind.Utc),
                    EndTime = new DateTime(2020, 6, 13, 10, 00, 12, 000, DateTimeKind.Utc),
                      Comment = "Coffee Zoom Meeting, beneficial networking",
                }
                ) ;
        }

        public DbSet<Goal> Goal { get; set; }
        public DbSet<Instance> Instance { get; set; }
    }
}
