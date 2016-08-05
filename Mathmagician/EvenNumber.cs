using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class EvenNumber
    {
        //create a new number (that's supposed to be even)
        public int usereven { get; set; }

        //create a counter that will add 2 to each number following the "usereven"
        public int counter = 2;

        //create a method that adds 2 to the usereven number 
        public int Add2ToUserEven(int usereven, int counter)
        {
            return usereven + counter; 
        }
    }

}
