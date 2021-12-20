using Exceptions.Constans;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Auth
{
    public class Account
    {
        public void Login( string password)
        {
            try
            {
                if (password.Length < 6)
                {
                    throw new Exception(Messages.PasswordMessage);
                }
                Console.WriteLine("Valid password");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
           

        }
    }
}
