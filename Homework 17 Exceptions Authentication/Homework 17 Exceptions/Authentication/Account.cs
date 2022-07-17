using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_17_Exceptions.Authentication
{
    public class Account: Exception
    {
       


        public static void Login (string mail, string password)
        {
            try
            {
                if (mail != "Filankes@gmail.com" || password != "12345")
                {
                    throw new Exception("Unhandled exception. Access denied.");
                }
                Console.WriteLine("Access accepted");



            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        
           
        

    }
}
