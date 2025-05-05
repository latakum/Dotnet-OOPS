using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_OOPS_Concepts.Models
{
    public class User
    {
        private string _password;
        public string Username;

        public User(string username, string password) {
            Username = username;
            _password = password;
        }

        public bool ValidatePassword(string userpassword)
        {
            return _password == userpassword;
        }
    }
}
