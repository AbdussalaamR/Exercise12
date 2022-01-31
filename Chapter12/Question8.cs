using System;
using System.IO;
using System.Collections.Generic;
namespace Chapter12
{
    public class Question8
    {
        public static void ReadNumber(int start, int end)
        {
            Console.WriteLine($"Enter number within the range {start} and {end}: ");
            int num = int.Parse(Console.ReadLine());
           if (start ! <= num || num ! <= end)
           {
               throw new InvalidInputException ("Input not within range.");
           }
        }
    }
}