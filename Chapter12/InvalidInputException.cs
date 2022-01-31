using System;
namespace Chapter12
{
    public class InvalidInputException:Exception
    {
        public InvalidInputException(string message): base(message)
        {

        }
    }
}