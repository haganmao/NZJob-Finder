using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NZJobFInder.Models;

namespace NZJobFInder.Controllers
{
    public class employerController : Controller
    {
        // GET: employer
        public ActionResult Index()
        {
            return View();
        }


        //public ActionResult regpass([Bind(Include = "employerName,employerAddress,employerPhoneNum,employerUserName,employerPassword,employerEmailAddress")] Employer employer) {
        //    using (NZJobFinderEntities2 db = new NZJobFinderEntities2())
        //    {
        //        db.Employers.Add(employer);
        //        db.SaveChanges();
        //    }
        //    return View(employer);
        //}

        //SAVE employer info to db
        public ActionResult regpass(Employer employer) {
            try
            {
                Database1Entities1 db = new Database1Entities1();
                db.Employers.Add(employer);
                db.SaveChanges();
                return View(employer);
            }
            catch {
                return View(employer);
            }
        }
    }
}