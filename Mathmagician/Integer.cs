using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer
    {
        //counter, increments by 1 for each new integer
        public int newInteger = 0;

        //list to store generated integers for testing
        public List<int> integers = new List<int>();
        
        //method takes an int, increments the counter that many times, outputs 
        //each number along the way & adds it to the list
        public int[] GenerateIntegers(int numOfIntegers)
        {
            if (numOfIntegers == 0)
            {
                return integers.ToArray();
            }
            else {
                for (int i = 0; i < numOfIntegers; i++)
                {   
                    integers.Add(newInteger);
                    newInteger += 1;
                }
                return integers.ToArray();
            }
        }
    }
}
  