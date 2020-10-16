using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication9.Controllers.Teachers
{
    public class CeShiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
