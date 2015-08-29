using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Classes
{
    class BionicFlipper : IPart 
    {

        public void servicePart() 
        {
            Random rsp = new Random();
            int randomSP = rsp.Next(1, 101);

            if (randomSP % 2 == 0) 
            {
                Console.WriteLine("Your flipper is flipping, and does not require service!");
            }
            else 
            {
                Console.WriteLine("Your flipper requires service!");
            }
        }

        public void replacePart() 
        {
            Random rsp = new Random();
            int randomSP = rsp.Next(1, 101);

            if (randomSP % 2 == 0) 
            {
                Console.WriteLine("Your flipper is flipping, and does not require replacement!");
            }
            else 
            {
                Console.WriteLine("Your flipper requires replacement!");
            }
        }
    }
}
