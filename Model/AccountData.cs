using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul
{
    public class Credentials
    {
        //login + password
    }

    public class AccountData
        //новый класс для именования параметров
    {
        //Логин
        public string phone
        {
            get;
            set;
        }
        public string password
        {
            get;
            set;
        }

        public string smscode
        {
            get;
            set;
        }

        //платежка
        public string FieldCorrName
        {
            get;
            set;
        }

        public string FieldDescription
        {
            get;
            set;
        }

        public string FieldAmount
        {
            get;
            set;
        }

        //reg

        public string SurName { get; set; }
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Mail { get; set; }

        public string Ogrn { get; set; }

        public string PassOne { get; set; }

        public string PassTwo { get; set; }
        


        
        public override string ToString()
        {
            return "phone=" + phone +", password=" + password;
        }
    }
}
