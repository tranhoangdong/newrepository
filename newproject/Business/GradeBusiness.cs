using newproject.ViewModels;
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
            var gradeList = db.Grades.ToList();
            return gradeList;
        }

        public List<GradeViewModel> GetGradeViewModelList()
        {
            var gradeList = db.Grades.ToList().Select(x => new GradeViewModel
            {
                GradeID = x.GradeID,
                GradeName = x.GradeName
            })
            .ToList();

            return gradeList;
        }

        public void AddGrade (Grade grade)
        {
            db.Grades.Add(grade);
            db.SaveChanges();
        }
        public EditGradeViewModel GetGradeViewModeByID( int id)
        {
            var Gra = db.Grades.Where(s => s.GradeID == id)
               .Select(x => new EditGradeViewModel // Chuyen can
               {
                 
                   GradeID = x.GradeID,
                   GradeName = x.GradeName
               })
                .FirstOrDefault();

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