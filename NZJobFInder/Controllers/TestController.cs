using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NZJobFInder.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {

            //assign a list of string to a list  
            var students = new List<string> { "Wang", "Gao", "Mao" };

            ViewBag.stus = students;

            return View();
        }
    }
}