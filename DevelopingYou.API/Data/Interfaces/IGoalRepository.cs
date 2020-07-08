using DevelopingYou.API.Models;
using DevelopingYou.API.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevelopingYou.API.Data.Interfaces
{
    public interface IGoalRepository
    {
        Task<IEnumerable<GoalDTO>> GetGoals();

        Task<GoalDTO> GetGoalById(int id);

        Task<GoalDTO> SaveNewGoal(GoalDTO goal);

        Task<bool> UpdateGoal(int id, Goal goal);

        Task<Goal> DeleteGoal(int id);
        Task<IEnumerable<GoalDTO>> GetActiveGoals();
    }
}
