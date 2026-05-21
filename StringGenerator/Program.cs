using System;
using System.Text;

namespace StringGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller C = new Controller();
            C.GenerateAString(args[0]);
        }
    }
}