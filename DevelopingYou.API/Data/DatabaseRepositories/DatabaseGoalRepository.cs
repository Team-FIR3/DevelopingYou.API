using DevelopingYou.API.Data.Interfaces;
using DevelopingYou.API.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopingYou.API.Data.DatabaseRepositories
{
    public class DatabaseGoalRepository : IGoalRepository
    {
        private readonly DiscoveringYouDBContext _context;

        public DatabaseGoalRepository(DiscoveringYouDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GoalDTO>> GetGoals()
        {
            var goals = await _context.Goal
                .Select(goal => new GoalDTO
                {
                    Id = goal.Id,
                    UserId = goal.UserId,
                    Title = goal.Title,
                    StartValue = goal.StartValue,
                    TargetValue = goal.TargetValue,
                    Category = goal.Category,

                })
                .ToListAsync();
            return goals;
        }
    }
}
