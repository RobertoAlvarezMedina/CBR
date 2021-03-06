﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CBR_Web.Models;

namespace CBR_Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Login()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Login_Nuevo()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Login_Existente()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Premium()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult MenuAdmin()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult MenuUser()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
