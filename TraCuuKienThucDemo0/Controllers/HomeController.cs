using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TraCuuKienThucDemo0.Models;

namespace TraCuuKienThucDemo0.Controllers
{
    public class HomeController : Controller
    {
        ContentDB db = new ContentDB();
        public ActionResult Index(int id = 1)
        {
            return View(db.DataAIs.Where(d => d.ID == id).FirstOrDefault());
        }

        [HttpPost]
        public JsonResult StartSearch(FormCollection data)
        {
            string keyword = data["keyword"];
            JsonResult js = new JsonResult();

            List<DataAI> result = db.DataAIs.Where(d => d.Title.StartsWith(keyword)).ToList();
            if(result.Count > 0)
            {
                js.Data = new
                {
                    status = "OK",
                };
            } else
            {
                js.Data = new
                {
                    status = "ERR",
                };
            }

            return Json(js, JsonRequestBehavior.AllowGet);
        }
    }
}