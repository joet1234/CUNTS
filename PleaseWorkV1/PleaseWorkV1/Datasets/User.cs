using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PleaseWorkV1.DataSets
{
    public class User
    {
        public String StudentNumber { set; get; }
        public String Password { set; get; }

        public User()
        {

        }

        public User(String StudentNumber, String Password)
        {
            this.StudentNumber = StudentNumber;
            this.Password = Password;
        }

        public bool ValidateUsername(String StudentNumber)
        {
            //Ensure 8 Letters 
            if (StudentNumber.Length == 8)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool withinDatabase()
        {
            return true;
        }


    }


}