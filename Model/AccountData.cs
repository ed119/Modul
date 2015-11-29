using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tooktodo
{
    public class Credentials
    {
        //login + password
    }

    public class AccountData
        
    {
        //Логин
        public string email
        {
            get;
            set;
        }
        public string password
        {
            get;
            set;
        }


        


        
        public override string ToString()
        {
            return "email" + email +", password=" + password;
        }
    }
}
