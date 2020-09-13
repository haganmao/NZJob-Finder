using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NZJobFInder.Models;
namespace NZJobFInder.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: Feedback
        public ActionResult Index()
        {
            return View();
        }

        public string feedpass(Feedback feedback) {

            try
            {
                Database1Entities db = new Database1Entities();
                db.Feedbacks.Add(feedback);
                db.SaveChanges();
                return "feedback saved success";
            }
            catch {
                return "feedback saved fail";
            }
        }
    }
}