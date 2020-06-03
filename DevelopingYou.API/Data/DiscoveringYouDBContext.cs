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
                      StartTime = "2020-06-01 09:41:23",
                      EndTime = "2020-06-01 13:41:23",
                      Comment = "Played Candy Crush instead of coding, could have utilized my time better",
                },
                new Instance
                {
                    Id = 2,
                    GoalId = 1,
                    StartTime = "2020-06-02 11:41:23",
                    EndTime = "2020-06-02 12:41:23",
                    Comment = "Video called sister and nephew, was fun",

                },
                new Instance
                {
                      Id = 3,
                      GoalId = 1,
                      StartTime = "2020-06-02 07:15:11",
                      EndTime = "2020-06-02 9:41:33",
                      Comment = "Coffee Zoom Meeting, beneficial networking",
                }
                ) ;
        }

        public DbSet<Goal> Goal { get; set; }
        public DbSet<Instance> Instance { get; set; }
    }
}
