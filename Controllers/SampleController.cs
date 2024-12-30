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
    public class SampleController : Controller
    {
        [Route("Index1")]
        public ActionResult Index1(){
            List<int> l=new List<int>(){1,2,3,4,5,6,7,8,9};
            ViewBag.data="Hello";
            TempData["tdata"]="Hello P";
            ViewData["vdata"]="Hello";

            return View();
        }
        // [Route("Index2")]
        // public ActionResult Index2(){
        //                 List<int> l=new List<int>(){1,2,3,4,5,6,7,8,9};

        //     ViewData["data"]="Hello";
        //     return View();
        // }
        [Route("Index3")]
        public ActionResult Index3(){
            String s=ViewBag.data;
            String s1=(string)ViewData["data"];
            // String s2=(string)TempData["data"];
            return View();
        }
        [Route("Index4")]
        public ActionResult Index4(){
            return View();
        }

    }
}