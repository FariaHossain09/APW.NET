using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskCV.Controllers
{
    public class CVController : Controller
    {
        // GET: CV
        public ActionResult CVProfile()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Edu()
        {
            return View();
        }

        public ActionResult Project()
        {
            return View();
        }
    }
}