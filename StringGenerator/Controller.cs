using System;
using System.Text;

namespace StringGenerator
{
    public class Controller
    {
        public void GenerateAString(string seed)
        {
            View V = new View();
            int realSeed;
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