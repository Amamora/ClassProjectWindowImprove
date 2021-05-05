using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowClassProject.Model
{
    class UserAccount
    {
        public int userAccountID {get;set ;}
        public string userAccount { get; set; }
        public string password { get; set; }

        public int typeID { get; set; }
        public UserAccount()
        {

        }
        //create constructor
        public UserAccount(int userAccountID,string userAccount,string password,int typeID)
        {
            this.userAccountID = userAccountID;
            this.userAccount = userAccount;
            this.password = password;
            this.typeID = typeID;

        }


    }
}
