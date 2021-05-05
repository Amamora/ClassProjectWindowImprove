using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowClassProject.Model
{
    class GroupModel
    {
        ///it's mean group subject in database
        ///
        public string groupID { get; set; }

        public string groupName { get; set; }
        public string teacherID { get; set; }
        public string studentID { get; set; }
        public int semesterID {get;set;}
        public string courseID { get; set; }
    
    }
}
