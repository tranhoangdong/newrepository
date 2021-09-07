using System.Collections.Generic;
using System.Linq;

namespace newproject.Business
{
    public class StudentBusiness
    {
        

        TestMVCEntities db = new TestMVCEntities();

        public List<Student> GetStudentList()
        {
            var studentList = db.Students.ToList();
            return studentList;
        }

        public void AddStudent(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges(); // Khi them thi phai save Change.
        }

        public Student GetStudentById(int id)
        {
            //Get the student from studentList sample collection for demo purpose.
            //Get the student from the database in the real application
            var std = db.Students.Where(s => s.StudentID == id).FirstOrDefault();

            return std;
        }

        public Student EditStudent(Student std)
        {
            //write code to update student 
            var student = db.Students.Where(s => s.StudentID == std.StudentID).FirstOrDefault();
            student.StudentName = std.StudentName;
            student.Age = std.Age;
            student.Sex = std.Sex;
            db.SaveChanges();
            return student;
        }

        // method nay de delete student bang id
        public List<Student> Delete(int id)
        {
            var student = db.Students.Where(s => s.StudentID == id).FirstOrDefault();
            db.Students.Remove(student);
            //write code to update student 
            db.SaveChanges();
            return db.Students.ToList();
        }

        public Student Detail(int id)
        {
            var student = db.Students.Where(s => s.StudentID == id).FirstOrDefault();
            return student;
            //thig liststudent.where(student =, 867767
        }


        // accesleve keu-tra-ve-tenham()
        //{ => casi nay phai co
        //} => casi nay phai co
        // ok ko?
        //ok
    }
}