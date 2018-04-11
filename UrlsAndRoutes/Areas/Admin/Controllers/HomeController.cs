﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Areas.Admin.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UrlsAndRoutes.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        Person[] data = new Person[] {
        new Person{ Name = "Alice", City = "London"},
        new Person{ Name = "Bob", City = "Paris"},
        new Person{ Name = "Joe", City = "New York"}
        };
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(data);
        }
    }
}
