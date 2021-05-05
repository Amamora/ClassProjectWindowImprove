using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowClassProject.Model
{
    class CourseModel
    {
        public string courseID { get; set; }
        public string courseName { get; set; }
        public string departmentID { get; set; }
        public int credit { get; set; }
        public string descriptionCourse{get;set;}
        public CourseModel()
        {

        }
    }
}
