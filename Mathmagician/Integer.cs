using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer
    {
        public int newInteger = -1;
        public List<int> integers = new List<int>();
        public void GenerateIntegers(int numOfIntegers)
        {
            if (numOfIntegers == 0)
            {
                Console.WriteLine("Here are the integers you didn't request! I hope you are pleased by their absence. Press any key to close.");
            }
            else {
                for (int i = 0; i < numOfIntegers; i++)
                {   
                    newInteger += 1;
                    Console.WriteLine("> " + newInteger);
                    integers.Add(newInteger);
                }
            }
        }

    }
}
  