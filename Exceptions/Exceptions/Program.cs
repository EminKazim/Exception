using Exceptions.Auth;
using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string password = "21345";
            Account account = new Account();
            account.Login(password);
        }
    }
}
