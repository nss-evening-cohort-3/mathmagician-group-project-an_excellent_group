using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class EvenNumber
    {
        
        //create a method that returns however many numbers in a list item 
        public List<int> CreateEvennNumberList(int usernumberoftimes)
        {
            //Create an empty list that the numbers will go inside of.
             List<int> usernumbers = new List<int>();

            //create the number that the list will start at
            int mycounter = 0;

            //loop through the number that represents the number of even numbers that the user wants
            for (var i=0; i < usernumberoftimes; i++)
            {
                //add the counter (the starting number) to the empty list
                usernumbers.Add(mycounter);

                //increment the counter by 2 each time the loop occurs.
                mycounter = mycounter + 2;
            }

            //send back the list after the loop is finished.
            return usernumbers; 
        }
    }

}
