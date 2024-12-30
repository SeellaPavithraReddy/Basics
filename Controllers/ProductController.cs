using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EFApp.Data;
using EFApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFApp.Controllers
{
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly ProductDBContext context;
        public ProductController(ProductDBContext context)
        {
            this.context = context;

        }

        [Route("Insert")]
        [HttpGet]
        public ActionResult Insert()
        {
            Product1 p = new Product1();
            return View(p);
        }
        [Route("Insert")]
        [HttpPost]
        public ActionResult Insert(Product1 p)
        {
            context.Product1s.Add(p);
            context.SaveChanges();
            ViewBag.msg = "1 row inserted";
            ViewBag.plist = context.Product1s.ToList();

            return View();
        }
        // [Route("Delete")]
        // [HttpPost]
        // public ActionResult Delete(Product1 p)
        // {
        //     context.Product1s.Remove(p);
        //     context.SaveChanges();
        //     ViewBag.msg = "1 row Deleted";
        //     ViewBag.plist = context.Product1s.ToList();

        //     return View();
        // }
        [Route("Update")]
        [HttpGet]
        public ActionResult Update()
        {
            Product1 p = new Product1();
            return View(p);
        }
        // [Route("ExtractProduct")]
        // [HttpGet]
        // public ActionResult Extract(int Id)
        // {
        //     var p1 = (from p2 in context.Product1s
        //               where p2.Id == Id
        //               select p2).FirstOrDefault();
        //     if (p1 == null)
        //     {
        //         ViewBag.msg = "No Product Exist";
        //     }
        //     return View("Delete", p1);
        // }
                [Route("ExtractProduct")]
        [HttpGet]
        public ActionResult Extract(int Id)
        {
            var p1 = (from p2 in context.Product1s
                      where p2.Id == Id
                      select p2).FirstOrDefault();
            if (p1 == null)
            {
                ViewBag.msg = "No Product Exist";
            }
            return View("Update", p1);
        }

        [Route("Update")]
        [HttpPost]
        public ActionResult Update(Product1 P)
        {
            var s = (from s1 in context.Product1s
                     where s1.Id == P.Id
                     select s1).FirstOrDefault();                                                                                                       
            // context.Product1s.Remove(s);
            if (s is not null)
            {
                s.ProductName = P.ProductName;
                s.Dom = P.Dom;
                s.Price = P.Price;
              
                context.SaveChanges();
                ViewBag.msg = "1 row Updated";

            }
            else
            {
                ViewBag.msg = "No row updated";
            }
            ModelState.Clear();
            P = new Product1();
            return View(P);
        }


        [Route("Delete")]
        [HttpGet]
        public ActionResult Delete()
        {
            Product1 p = new Product1();
     
            return View(p);
        }
        [Route("Delete")]
        [HttpPost]
        public ActionResult Delete(Product1 P)
        {
            var s = (from s1 in context.Product1s
                     where s1.Id == P.Id
                     select s1).FirstOrDefault();
            
            if (s is not null)
            {
               
                s.ProductName = P.ProductName;
                s.Dom = P.Dom;
                s.Price = P.Price;
                context.Product1s.Remove(s);
                context.SaveChanges();
                ViewBag.msg = "1 row Deleted";

            }
            else
            {
                ViewBag.msg = "No row Deleted";
            }
            ModelState.Clear();
            P = new Product1();
            return View(P);
        }
    }
}