using Homework_17_Exceptions.Authentication;
using System;

namespace Homework_17_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {


            //Homework Login Password Check
            Account.Login("Filankes@gmail.com", "12345");


            //try
            //{
            //    int a = 5;
            //    int b = 0;
            //    var result = a / b;
            //    Console.WriteLine(result);

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            //Divide(5, 3);
        }

        //public static void Divide(int num1, int num2)
        //{
        //    try
        //    {
        //        if (num2 == 2)
        //        {
        //            throw new DivideByZeroException("Num cant equal to 2");
        //        }
        //        Console.WriteLine(num1/num2);
             
                

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
            
        //}

    }
}
