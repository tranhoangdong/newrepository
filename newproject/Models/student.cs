using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace newproject.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        //  [Display(Name = "Name")]
       
        public string StudentName { get; set; }
        public int Age { get; set; }
        public bool isNewlyEnrolled { get; set; }
        public string Password { get; set; }
        public DateTime DoB { get; set; }
        public string Sex { get; set; }
    }
    
}