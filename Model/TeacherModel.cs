using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowClassProject.Model
{
    class TeacherModel
    {
        public string teacherID { get; set; }
        public string teacherFName { get; set; }
        public string teacherLName { get; set; }
        public DateTime teacherBDate { get; set; }

        public bool teacherGender { get; set; }
        public string teacherPhone { get; set; }
        public string teacherEmail { get; set; }
        public string teacherCMND { get; set; }

        public byte[] picture { get; set; }
        public int userAccountID { get; set; }


        public TeacherModel()
        {

        }
    }
}
