using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AmigoForm.Models;
using System.Text.RegularExpressions;

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
            if (model.CustomerName == null || model.CustomerName.Trim().Length == 0) 
            {
                ModelState.AddModelError("Name", "Your Name is Required");
            }
            else if((model.CustomerName).Length < 3)
            {
                ModelState.AddModelError("Name", "Please Enter a valid name (at least 3 characters)");
            }

            if(model.Email == null || model.Email.Trim().Length == 0)
            {
                ModelState.AddModelError("Email", "Your Email is Required");
            }
            else
            {
                string emailRegex = @"^\w+@\w+\.\w+|\w+\.\w+";
                Regex re = new Regex(emailRegex);
                if (!re.IsMatch(model.Email))
                {
                    ModelState.AddModelError("Email", "Email is not valid");
                }
            }

            if(model.BugDesc == null || model.BugDesc.Trim().Length == 0)
            {
                ModelState.AddModelError("Description", "The Bug Description is required");
            }

            if (model.BugType == null || model.BugType.Trim().Length == 0)
            {
                ModelState.AddModelError("BugType", "Please Select Bug Type");
            }

                if (ModelState.IsValid)
            {
                //Submit to Api
            }
            return View(model);
        }
    }
}
