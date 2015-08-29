using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Classes
{
    class CoalFurnace : IPowerSource
    {
        public int availableCoal;

        public void setAvailableCoal(int quantity)
        {
            this.availableCoal = quantity;
            Console.WriteLine("You have " + quantity + " metric tons of coal.");
        }

        public void turnOn()
        {
            Console.WriteLine("Robot furnace is fired.");
        }

        public void consumePower(int rateOfConsumption)
        {
            Console.WriteLine("Robot is burning coal.");
            this.availableCoal = this.availableCoal - rateOfConsumption;
            Console.WriteLine("You now have " + this.availableCoal + " metric tons of coal.");
        }
    }
}
