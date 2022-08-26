using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomValidationDemo.Models;
using System.ComponentModel.DataAnnotations;

namespace CustomValidationDemo.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Emp emp)
        {
            if(ModelState.IsValid)
            {
                ModelState.Clear(); 
                return View();
            }
            return View();
        }
    }
}