using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newproject.Business
{
    public class GradeBusiness
    {
        TestMVCEntities db = new TestMVCEntities();
        public List<Grade> GetGradeList()
        {
            var GradeList = db.Grades.ToList();
            return GradeList;
        }
        public void AddGrade (Grade grade)
        {
            db.Grades.Add(grade);
            db.SaveChanges();
        }
        public Grade GetByID( int id)
        {
            var Gra = db.Grades.Where(s => s.GradeID == id).FirstOrDefault();

            return Gra ;
        }
        public Grade EditGrade ( Grade gra)
        {
            var grade = db.Grades.Where(s => s.GradeID == gra.GradeID).FirstOrDefault();
            grade.GradeName = gra.GradeName;
            db.SaveChanges();
            return grade;
        }
       public List<Grade> Delete(int id)
        {
            var grade = db.Grades.Where(s => s.GradeID == id).FirstOrDefault();
            db.Grades.Remove(grade);
            db.SaveChanges();
            return db.Grades.ToList();        }
    }
 

}