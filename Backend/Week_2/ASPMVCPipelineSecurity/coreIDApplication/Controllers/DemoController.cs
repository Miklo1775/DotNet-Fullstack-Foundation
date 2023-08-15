﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace coreIDApplication.Controllers
{
    //[AllowAnonymous]
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Details() {
            
            return View();
        }

        [Authorize]
        public IActionResult Policy()
        {
            return View();
        }
    }
}
