using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NZJobFInder.Models;
namespace NZJobFInder.Controllers
{
    public class JobController : Controller
    {
        // GET: Job
        public ActionResult Index()
        {
            return View();
        }



        //save job details to db
        public string jobpass(Job job) {

            try {
                Database1Entities db = new Database1Entities();
                db.Jobs.Add(job);
                db.SaveChanges();
                return "add success!";
            }
            catch
            {
                return "add failed, please check your employer id first";
            }

        }

    }
}