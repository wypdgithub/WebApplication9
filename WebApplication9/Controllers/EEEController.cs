﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication9.Controllers
{
    public class EEEController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult aa()
        {
            return View();
        }
        public IActionResult dd()
        {
            return View();
        } 
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Upd(int id)
        {
             ViewBag.id=id;
            return View();
        }
    }
}
