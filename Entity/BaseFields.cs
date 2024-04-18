using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityGradingSystem.Entity
{
    public  class BaseFields
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public BaseFields(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
