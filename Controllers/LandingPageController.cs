﻿using Microsoft.AspNetCore.Mvc;

namespace RZA___Riget_Zoo_Adventures.Controllers
{
    public class LandingPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
