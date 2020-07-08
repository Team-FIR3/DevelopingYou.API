using DevelopingYou.API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace DevelopingYou.API.Data
{
    public class DiscoveringYouDBContext : IdentityDbContext<User>
    {
        public DiscoveringYouDBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }

        public DbSet<Goal> Goal { get; set; }
        public DbSet<Instance> Instance { get; set; }
    }
}
