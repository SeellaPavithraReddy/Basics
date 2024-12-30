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
    public class EmpController : Controller
    
    {
    private readonly ProductDBContext context;
            public EmpController(ProductDBContext context)
        {
            this.context = context;

        }

        [Route("emp")]
        [HttpGet]
        public ActionResult getEmp(){
            EmpValidations1 ev=new EmpValidations1();
            return View(ev);
        }
        [Route("emp")]
        [HttpPost]
        public ActionResult getEmp(EmpValidations1 E){
            if(ModelState.IsValid){
                context.EmpValidations1s.Add(E);
                context.SaveChanges();
                ViewBag.msg="1 row inserted";
                return View(E);
            }
            return View(E);
        }
        
    }
}