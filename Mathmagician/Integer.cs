using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer
    {
        //private List<int> _integers = new List<int>();

        public void GenerateIntegers(int numOfIntegers)
        {
            var startingNumber = -1;
            for (int i = 0; i <numOfIntegers; i++ )
            {
                startingNumber += 1;
                Console.WriteLine("> " + startingNumber);
            }
        }

    }
}
  