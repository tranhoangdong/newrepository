using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace newproject.ViewModels
{
    public class TestViewModel
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public Nullable<int> Age { get; set; }
        public string Sex { get; set; }
        public int? GradeID { get; set; }
        public string GradeName { get; set; }

        public string TenTuoi { get; set; }

        //public virtual Grade Grade { get; set; }
    }
}
