using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicequestions2
{
    // Sealed class prevents inheritance
    sealed class SecuritySystem
    {
        public void AuthenticateUser(string username, string password)
        {
            Console.WriteLine($"Authenticating {username}...");
            Console.WriteLine("Access Granted!");
        }
    }

}
