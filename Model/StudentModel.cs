using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowClassProject.Model
{
    class StudentModel
    {
        public string studentID { get; set; }
        public string studentFName { get; set; }
        public string studentLName { get; set; }
        public DateTime studentBDate { get; set; }
        public string studentAdress { get; set; }
        public  bool studentGender { get; set; }
        public string studentPhone { get; set; }
        public string studentEmail { get; set; }
        public string studentCMND { get; set; }
        public byte[] picture { get; set; }
        public string classID { get; set; }
        public int userAccountID { get; set; }

        public StudentModel()
        {

        }


    }
}
