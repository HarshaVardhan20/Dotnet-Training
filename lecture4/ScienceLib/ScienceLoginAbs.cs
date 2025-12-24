using Common;
using System;
using System.Collections.Generic;
using System.Text;
namespace ScienceLib
{
    public class ScienceLoginAbs : LoginAbs
    {
        public override void Login(string username, string password)
        {
            if (LoginProcess())
            {
                Console.WriteLine("Login Successful");
            }
            Console.WriteLine("Login unsuccessful");
            return;
        }

        public override void Logout(string username, string password)
        {
            if (LogoutProcess())
            {
                {
                    Console.WriteLine("Logout Successful");
                }
                Console.WriteLine("Logout unsuccessful");
                return;
            }

        }

        internal string  protectedFunc()
        {
            return "protected func";
        }
    }
}
