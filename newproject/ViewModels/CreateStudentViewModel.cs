using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newproject.ViewModels
{
    public class CreateStudentViewModel
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public Nullable<int> Age { get; set; }
        public string Sex { get; set; }
        public List<GradeViewModel> Grades { get; set; }
    }

    public class GradeViewModel
    {
        public int GradeID { get; set; }
        public string GradeName { get; set; }

    }
}