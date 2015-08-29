using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Classes
{
    public class BionicLegs : IPart 
    {

        public void servicePart() 
        {
            Random rsp = new Random();
            int randomSP = rsp.Next(1, 101);

            if(randomSP % 2 == 0) 
            {
                Console.WriteLine("Your legs have spring, and do not require service!");
            }
            else 
            {
                Console.WriteLine("Your legs require service!");
            }
        }

        public void replacePart() 
        {
            Random rsp = new Random();
            int randomSP = rsp.Next(1, 101);

            if (randomSP % 2 == 0) 
            {
                Console.WriteLine("Your legs have spring, and do not require replacement!");
            }
            else 
            {
                Console.WriteLine("Your legs require replacement!");
            }
        }
    }
}