using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TraCuuKienThucDemo0.Models;

namespace TraCuuKienThucDemo0.Controllers
{
    public class TopicController : Controller
    {
        ContentDB db = new ContentDB();
        // GET: Topic
        //[ChildActionOnly]
        public ActionResult LeftMenu()
        {
            return PartialView(db.DataAIs.ToList());
        }

        public ActionResult GoTo(int Id)
        {
            return RedirectToAction("Index", "Home", new { id = Id });
        }
    }
}