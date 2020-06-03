using DevelopingYou.API.Data.Interfaces;
using DevelopingYou.API.Models;
using DevelopingYou.API.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevelopingYou.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class InstancesController : ControllerBase
    {
        IInstanceRepository instanceRepository;

        public InstancesController(IInstanceRepository instanceRepository)
        {
            this.instanceRepository = instanceRepository;
        }

        //Get api/Instances
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InstanceDTO>>> GetInstances()
        {
            return Ok(await instanceRepository.GetInstances());
        }

        //Single instance
        [HttpGet("{id}")]
        public async Task<ActionResult<InstanceDTO>> GetInstanceById(int id)
        {
            InstanceDTO instance = await instanceRepository.GetInstanceById(id);

            if (instance == null)
            {
                return NotFound();

            }

            return instance;
        }

        //Put
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstance(int id, Instance instance)
        {
            if (id != instance.Id)
            {
                return BadRequest();
            }

            bool updatedInstance = await instanceRepository.UpdateInstance(id, instance);

            if (!updatedInstance)
            {
                return NotFound();
            }

            return NoContent();
        }

        //Post
        [HttpPost]
        public async Task<ActionResult<Instance>> PostInstance(Instance instance)
        {
            await instanceRepository.SaveNewInstance(instance);

            return CreatedAtAction("GetInstance", new { id = instance.Id }, instance);

        }

        //Delete
        [HttpDelete("{id}")]
        public async Task<ActionResult<Instance>> DeleteInstance(int id)
        {
            var instance = await instanceRepository.DeleteInstance(id);

            if (instance == null)
            {
                return NotFound();
            }

            return instance;
        }


    }
}
