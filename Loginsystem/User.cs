using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loginsystem
{
    public class User
    {
        private string password;
        public string username;

        public string Password {set => password = value; }
        public string Username { get => username; set => username = value; }
    }
}
