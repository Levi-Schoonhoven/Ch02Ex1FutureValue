﻿using Microsoft.AspNetCore.Mvc;

namespace Ch02Ex1FutureValue.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Mary";
            ViewBag.FV = 99999.99;
            return View();
        }
    }
}
