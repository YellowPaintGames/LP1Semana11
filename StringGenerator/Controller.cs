using System;
using System.Text;

namespace StringGenerator
{
    /// <summary>
    /// Controls the flow of information,
    /// Works as an intermediary between the model and the view
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// Misleading name ik, but calls a View and forces it to print out something,
        /// if the arg[0] IS an int then it'll call forth the generator to generate a 
        /// String using that as seed.
        /// 
        /// If not, Nope (<- That's what it will say btw)
        /// </summary>
        /// <param name="seed">As a string, the seed</param>
        public void GenerateAString(string seed)
        {
            //Creates a new View
            View V = new View();
            //The REAL seed
            int realSeed;
            //Checks if whatever you wrote is or not an int,
            //If it ain't, get Nope'd
            //If it is tho it will call out the generator
            //With the actual seed as an int
            if (Int32.TryParse(seed, out realSeed))
            {
                string output = Generator.Generate(realSeed);
                V.PrintOut(output);
            }
            else
            {
                V.PrintOut("Nope");
            }
        }
    }
}