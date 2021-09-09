using newproject.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace newproject.Controllers
{
    public class GradeController : Controller
    {
        GradeBusiness gradeBusiness;
        public GradeController()
        {
            gradeBusiness = new GradeBusiness();
        }
        public ActionResult Index()
        {
            var GradeList = gradeBusiness.GetGradeList();
            return View(GradeList);

        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Grade grade)
        {
            gradeBusiness.AddGrade(grade);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var gra = gradeBusiness.GetByID(id);

            return View(gra);
        }

        [HttpPost]
        public ActionResult Edit(Grade gra)
        {
            var GradeList = gradeBusiness.EditGrade(gra);
            return RedirectToAction("Index", GradeList);
        }
         public ActionResult Delete(int id)
        {
            var gradeList   = gradeBusiness.Delete(id);

            return View("Index", gradeList);
           
        }
       
    }
}