using System;
using System.Text;
namespace StringGenerator
{
    /// <summary>
    /// Visual feedback for the user
    /// </summary>
    public class View
    {
        /// <summary>
        /// Does a Console Write Line, lol
        /// </summary>
        /// <param name="output">Whatever you need to be printed out</param>
        public void PrintOut(string output)
        {
            Console.Write(output);
        }
    }
}