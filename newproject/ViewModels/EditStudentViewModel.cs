using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newproject.ViewModels
{
    public class EditStudentViewModel
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public Nullable<int> Age { get; set; }
        public string Sex { get; set; }
       public int? GradeID { get; set; }
    }
}