﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DevelopingYou.API.Controllers
{
    public class GoalsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
