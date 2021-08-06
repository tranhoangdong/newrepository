using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace newproject.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        public ActionResult Index()
        {
            return View();
        }
    }
}