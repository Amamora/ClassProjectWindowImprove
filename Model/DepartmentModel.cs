using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowClassProject.Model
{
    class DepartmentModel
    {
        public string departmentID { get; set; }
        public string departmentName { get; set; }
        public string teacherID { get; set; }

        public DepartmentModel()
        {

        }
        public DepartmentModel(string departID,string departName,string teachID)
        {
            this.departmentID = departID;
            this.departmentName = departName;
            this.teacherID = teachID;
        }
    }
}
