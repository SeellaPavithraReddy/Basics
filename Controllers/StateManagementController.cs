using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EFApp.Controllers
{
    [Route("[controller]")]
    public class StateManagementController : Controller
    {
        [Route("Page1")]
        [HttpGet]
        public ActionResult Page1()
        {
            return View();
        }
        [Route("Page1")]
        [HttpPost]
        public ActionResult Page1(string Name)
        {
            // Creating Cookie
            Response.Cookies.Append("Username", Name);
            return View("Page2");
        }
        [Route("Page3")]
        [HttpPost]
        public ActionResult Page3()
        {
            ViewBag.Name = Request.Cookies["Username"];
            return View("Page3");
        }
        [Route("Page4")]
        [HttpPost]
        public ActionResult Page4()
        {
           // ViewBag.NN = Request.Cookies["Username"];

            return View("Page5");
        }

    }
}