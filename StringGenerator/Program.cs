using System;
using System.Text;

namespace StringGenerator
{
    /// <summary>
    /// The place where everything happens
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Controller created here
            Controller C = new Controller();
            //And using the first argument makes a string of numbers
            C.GenerateAString(args[0]);
        }
    }
}