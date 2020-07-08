using DevelopingYou.API.Data.Interfaces;
using DevelopingYou.API.Models;
using DevelopingYou.API.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DevelopingYou.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class GoalsController : ControllerBase
    {
        IGoalRepository goalRepository;

        public GoalsController(IGoalRepository goalRepository)
        {
            this.goalRepository = goalRepository;
        }

        //Get api/Goals
        [HttpGet]

        public async Task<ActionResult<IEnumerable<GoalDTO>>> GetGoals()
        {
            return Ok(await goalRepository.GetGoals());
        }

        [HttpGet("Active")]

        public async Task<ActionResult<IEnumerable<GoalDTO>>> GetActiveGoals()
        {
            return Ok(await goalRepository.GetActiveGoals());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GoalDTO>> GetGoalById(int id)
        {
            GoalDTO goal = await goalRepository.GetGoalById(id);

            if (goal == null)
            {
                return NotFound();
            }

            return goal;
        }

        [HttpPost]
        public async Task<ActionResult<Goal>> PostGoal(Goal goal)
        {
            goal.UserId = GetUserId();
            await goalRepository.SaveNewGoal(goal);

            return CreatedAtAction("GetGoal", new { id = goal.Id }, goal);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutGoal(int id, Goal goal)
        {
            if (id != goal.Id)
            {
                return BadRequest();
            }

            bool updatedGoal = await goalRepository.UpdateGoal(id, goal);

            if (!updatedGoal)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Goal>> DeleteGoal(int id)
        {
            var goal = await goalRepository.DeleteGoal(id);

            if (goal == null)
            {
                return NotFound();
            }

            return goal;
        }
        private string GetUserId()
        {
            ClaimsIdentity identity = (ClaimsIdentity)User.Identity;
            Claim userIdClaim = identity.FindFirst(ClaimTypes.NameIdentifier);
            return userIdClaim?.Value;
        }

    }
}