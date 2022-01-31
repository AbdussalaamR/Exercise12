using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace Chapter12
{
    public class Question12
    {
        static string file =  "C:\\Windows\\win.ini";
        public static void ReadFile()
        {
           try
           {
                if (File.Exists(file))
            {
                var k = File.ReadAllLines(file);
                foreach (var item in k)
                {
                 Console.WriteLine(item);   
                }
            }
           }
           catch (FileNotFoundException e)
           {
               
               Console.WriteLine("The file could not be found" + e.Message);
           }
           catch (DirectoryNotFoundException e)
           {
               
               Console.WriteLine("The directory is not be found" + e.Message);
           }
           catch (PathTooLongException e)
           {
               
               Console.WriteLine("The given path is too long " + e.Message);
           }
           catch (Exception e)
           {
               
               Console.WriteLine(e.Message);
           }
        }
    }
}