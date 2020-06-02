using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevelopingYou.API.Data.Interfaces;
using DevelopingYou.API.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

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

        
    }
}
