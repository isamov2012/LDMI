﻿using Microsoft.AspNetCore.Mvc;

namespace LWI.Controllers
{
    public class LwiController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}