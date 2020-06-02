using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevelopingYou.API.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevelopingYou.API.Controllers
{
    public class InstancesController : ControllerBase
    {
        IInstanceRepository instanceRepository;

        public InstancesController(IInstanceRepository instanceRepository)
        {
            this.instanceRepository = instanceRepository;
        }

        
    }
}
