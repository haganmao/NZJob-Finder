using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NZJobFInder.Models;

namespace NZJobFInder.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }





        //serach job by job title or location
        public ActionResult searchbyKeyWord(string jobTitle, string jobLocation)
        {
            //intial a list 
            List<Job> jobList = new List<Job>();
            Database1Entities1 db = new Database1Entities1();
            


            //get all avalible jobs
            var joball = (from j in db.Jobs orderby j.JobId select j).ToList();


            //search by title
            var jobbytitle = (from j in db.Jobs where j.jobTitle == jobTitle select j).ToList();

            //search by location
            var jobbyLocation = (from j in db.Jobs where j.jobLocation == jobLocation select j).ToList();

            //serach job by title keyword and location
            var jobbyKeyAndLocation = (from j in db.Jobs where j.jobTitle == jobTitle && j.jobLocation == jobLocation select j).ToList();


            //blank jobTitle and jobLocation
            if (jobTitle == "" && jobLocation == "")
            {
                //list all availiable jobs
                ViewBag.jobList = joball;
                return View();
            }
            
            else if (jobTitle != null && jobLocation == "")
            {
                ViewBag.jobList = jobbytitle;
                return View();
            }

            else if (jobTitle == "" && jobLocation != null) {

                ViewBag.jobList = jobbyLocation;
                return View();
            }

            else
            {
                ViewBag.jobList = jobbyKeyAndLocation;
                return View();
            }
        }

    }
}