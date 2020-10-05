using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NZJobFInder.Models;
namespace NZJobFInder.Controllers
{
    public class feedbackController : Controller
    {
        // GET: feedback
        public ActionResult Index()
        {
            return View();
        }

        //save feedback to db
        public ActionResult msgpass([Bind(Include = "feedName,feedEmail,feedMessage")]Message message) {

            List<Message> msgList = new List<Message>();

            msgList.Count();
            using (Database1Entities1 db = new Database1Entities1())
            {    
                db.Messages.Add(message);
                db.SaveChanges();
                var msg = (from m in db.Messages orderby m.Id select m).ToList();
                ViewBag.msgList = msg;
                return View();
            }
                    
        } 

    }
}