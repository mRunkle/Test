using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Classes 
{
    
    public class ButterRobot : Robot 
    {

        protected int rateOfConsumption = 0;


        public ButterRobot(IPowerSource powerSource, IPart part) : base(powerSource, part) 
        {
            this.rateOfConsumption = 5;
        }

        public void turnOn() 
        {
            powerSource.turnOn();
        }

        public void usePower() 
        {
            Console.WriteLine("Rate of power consumption is " + rateOfConsumption);
            powerSource.consumePower(rateOfConsumption);
        }

        public void servicePart() 
        {
            part.servicePart();
        }

        public void replacePart() 
        {
            part.replacePart();
        }
    }
}
