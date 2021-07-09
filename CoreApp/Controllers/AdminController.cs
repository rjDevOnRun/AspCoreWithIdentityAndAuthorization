using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            //TempData["Message"] = $"Successfully edited User information!";
            return View();
        }
    }
}
