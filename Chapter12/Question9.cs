using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace Chapter12
{
    public class Question9
    {
        public static void ReadFile(string a)
        {
            try
            {
                if (File.Exists(a))
                {
                    var j = File.ReadAllLines(a);
                    foreach (var item in j)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch (Exception e)
            {
                
                Console.WriteLine(e.Message);
            }
        }
    }
}