using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Exceptions
{
   public class LoginExceptions : Exception
    {
        public LoginExceptions(string msj):base(msj)
        {

        }
    }
}
