using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowClassProject.View.ViewLogin;
using WindowClassProject.View.ViewManageStudent;

namespace WindowClassProject
{
    static class Program
    {
       
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login_Form log = new Login_Form();
            Application.Run(new ManageForm());
        }
    }
}
