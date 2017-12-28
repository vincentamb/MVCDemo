﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            ViewData["Countries"] =  new List<string>()
            {
                "India",
                "USA",
                "UK",
                "Canada"
            };
            return View();
        }
    }
}