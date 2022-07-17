using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_17_Exceptions.Exceptions
{
    class DivideException : Exception 
    {

        public DivideException(string message):base(message)
        {

        }
    }
}
