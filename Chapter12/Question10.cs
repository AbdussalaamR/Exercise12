using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace Chapter12
{
    public class Question10
    {
        public static void ReadBinary(string a)
        {
                try
                {
                    if (File.Exists(a))
                    {
                        var j = File.ReadAllLines(a);
                        foreach (var item in j)
                        {
                            Console.WriteLine(Byte.Parse(item));
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