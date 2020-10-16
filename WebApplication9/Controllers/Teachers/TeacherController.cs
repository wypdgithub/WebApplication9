using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication9.Controllers.Teachers
{
    public class TeacherController : Controller
    {
        public IActionResult GetList()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Upd()
        {
            
            return View();
        }
        public IActionResult UpdTeacher(int id)
        {
            ViewBag.sid = id;
            return View();
        }
        public IActionResult LLL()
        {
            
            return View();
        }
        public IActionResult CCC()
        {

            return View();
        }
    }
}
