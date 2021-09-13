using newproject.Business;
using newproject.ViewModels;
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
            var model = new CreateGradeViewModel();
            var gradeList = gradeBusiness.GetGradeViewModelList();
            model.GradeName = gradeList.ToString();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Grade grade)
        {
            gradeBusiness.AddGrade(grade);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var gra = gradeBusiness.GetGradeViewModeByID(id);

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