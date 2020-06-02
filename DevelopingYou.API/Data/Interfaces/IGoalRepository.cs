using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevelopingYou.API.Models;
using DevelopingYou.API.Models.DTOs;

namespace DevelopingYou.API.Data.Interfaces
{
     public interface IGoalRepository
    {
        Task<IEnumerable<GoalDTO>> GetGoals();

        Task<GoalDTO> GetGoalById(int id);

        Task<Goal> SaveNewGoal(Goal goal);
    }
}
