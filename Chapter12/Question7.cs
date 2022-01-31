using System;
using System.IO;
using System.Collections.Generic;
namespace Chapter12
{
    public class Question7
    {
        public static void Answer()
        {
            try
            {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(num));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
        }
    }
}