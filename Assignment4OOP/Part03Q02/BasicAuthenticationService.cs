using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4OOP.Part03Q02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private string[] usernames = { "Ahmed", "Aya" };
        private string[] passwords = { "123", "456" };
        private string[][] roles =
        {
            new string[] { "admin", "editor" }, // roles for user1
            new string[] { "user", "viewer" }    // roles for user2
        };

        public bool AuthenticateUser(string username, string password)
        {
            // Check if the username and password match
            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == username && passwords[i] == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            // Find the user index
            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == username)
                {
                    // Check if the user has the specified role
                    foreach (string r in roles[i])
                    {
                        if (r == role)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }

}
