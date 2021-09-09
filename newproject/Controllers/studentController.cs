using newproject.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace newproject.Controllers
{
   

    public class StudentController : Controller
    {
        StudentBusiness studentBusiness;
        // GradeBusiness  gradeBusiness;
        public StudentController()
        {
            studentBusiness = new StudentBusiness();
        }

        // GET: Student
        public ActionResult Index()
        {
            var studentList = studentBusiness.GetStudentList();
            return View(studentList);
        }



        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        { 
            
          

            studentBusiness.AddStudent(student);

            return RedirectToAction("Index");
        }


        public ActionResult Edit(int id)
        {
            var std = studentBusiness.GetStudentById(id);

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            var studentList = studentBusiness.EditStudent(std);
            return RedirectToAction("Index", studentList);
        }
        

        public ActionResult Delete(int id)
        {
            var studentList = studentBusiness.Delete(id);

            return View("Index", studentList);
            //return View(studentList);
        }
        public ActionResult Details(int id)
        {
            var student = studentBusiness.Detail(id);

            return View(student);
        }

        

    }

}