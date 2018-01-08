using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AmigoForm.Models;

namespace AmigoForm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Index(BugReportModel model)
        {
            if (string.IsNullOrEmpty(model.CustomerName))
            {
                ModelState.AddModelError("Name", "Your Name is Required");
            }
            else if((model.CustomerName).Length < 3)
            {
                ModelState.AddModelError("Name", "Please Enter a valid name (at least 3 characters)");
            }
            if (ModelState.IsValid)
            {
                ViewBag.Name = model.CustomerName;
                //Submit to Api
            }
            return View(model);
        }
    }
}
