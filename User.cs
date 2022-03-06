using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerSurvey
{
    class User
    {
        private string username;
        private string firstname;
        private string lastname;
        private int age;
        private string gender;
        private string password;
      
        public string Username
        {
            set
            {
                username = value;
            }
            get
            {
                return username;
            }
        }
        public string Firstname
        {
            set
            {
                firstname = value;
            }
            get
            {
                return firstname;
            }
        }
        public string Lastname
        {
            set
            {
                lastname = value;
            }
            get
            {
                return lastname;
            }
        }
        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
        public string Gender
        {
            set
            {
                gender = value;
            }
            get
            {
                return gender;
            }
        }
       
        public string Password
        {
            set
            {
                password = value;
            }
            get
            {
                return password;
            }
        }       


    }
}
