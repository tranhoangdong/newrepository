using newproject.Business;
using newproject.Models;
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
        public ActionResult Create(string studentName, int age, string sex)
        {
            // TODO
            var student = new Student();
            student.StudentName = studentName;
            student.Age = age;
            student.Sex = sex;

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

        //Delete(id)
        //studentBusiness.Delete(id)

    }

}