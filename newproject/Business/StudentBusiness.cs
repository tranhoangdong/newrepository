using newproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newproject.Business
{
    public class StudentBusiness
    {
        static IList<Student> studentList = new List<Student>()
        {
            new Student(){ StudentId=1, StudentName="John", Age = 18, Sex ="Male" },
                    new Student(){ StudentId=2, StudentName="Steve", Age = 21,Sex ="Male"  },
                    new Student(){ StudentId=3, StudentName="Bill", Age = 25,Sex ="Female" },
                    new Student(){ StudentId=4, StudentName="Ram", Age = 20,Sex ="Male" },
                    new Student(){ StudentId=5, StudentName="Ron", Age = 31,Sex ="Female" },
                    new Student(){ StudentId=6, StudentName="Chris", Age = 17,Sex ="Female" },
                    new Student(){ StudentId=7, StudentName="Rob", Age = 19,Sex ="Male" }
        };

        public List<Student> GetStudentList()
        {
            return studentList.ToList();
        }

        public void AddStudent(Student student)
        {
            studentList.Add(student);
        }

        public Student GetStudentById(int id)
        {
            //Get the student from studentList sample collection for demo purpose.
            //Get the student from the database in the real application
            var std = studentList.Where(s => s.StudentId == id).FirstOrDefault();

            return std;
        }

        public Student EditStudent(Student std)
        {
            //write code to update student 
            var student = studentList.Where(s => s.StudentId == std.StudentId).FirstOrDefault();
            student.StudentName = std.StudentName;
            student.Age = std.Age;
            student.Sex = std.Sex;

            return student;
        }

        // method nay de delete student bang id
        public List<Student> Delete(int id)
        {
            var student = studentList.Where(s => s.StudentId == id).FirstOrDefault();
            studentList.Remove(student);
            //write code to update student 

            return studentList.ToList();
        }


        // accesleve keu-tra-ve-tenham()
        //{ => casi nay phai co
        //} => casi nay phai co
        // ok ko?
        //ok
    }
}