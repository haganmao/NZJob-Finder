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
        public ActionResult jobpass(Job job) {

            //initial a list
            List<Job> jobPassList = new List<Job>();
            Database1Entities1 db = new Database1Entities1();

            try
            {
                db.Jobs.Add(job);
                db.SaveChanges();
                var jobs = (from j in db.Jobs orderby j.JobId select j);
                ViewBag.jobPassList = jobs;
                return View(job);
            }
            catch {

                throw new Exception("Please check your employer id");
            }
        }

   

        public ActionResult jobDelete(string jobTitle, int JobId=0)
        {
           
            Database1Entities1 db = new Database1Entities1();

            //initial a list
            List<Job> jobDeleteList = new List<Job>();

            //Find the matched job Id
            var jobDeleteById = db.Jobs.Find(JobId);

            //Find the matched job Title
            List<Job> jobDeleteByTitle = db.Jobs.Where(j => j.jobTitle == jobTitle).ToList();


            //Find the matched job Title and job ID
            List<Job> jobDelete = db.Jobs.Where(j => j.jobTitle == jobTitle && j.JobId == JobId).ToList();

            //delete job by id
            if (JobId > 0)
            {
                db.Jobs.Remove(jobDeleteById);
                ViewBag.jobDeleteList = jobDeleteById;
                db.SaveChanges();
                return View();
            }

            //delete job by title 
            else if (jobTitle != null)
            {
                foreach (var x in jobDeleteByTitle)
                {
                    db.Jobs.Remove(x);
                }
                db.SaveChanges();
                return View();
            }

            //delete job by title and id
            else
            {
                foreach (var j in jobDelete)
                {
                    db.Jobs.Remove(j);
                    db.SaveChanges();
                }
                return View();
            }

        }

    }
}