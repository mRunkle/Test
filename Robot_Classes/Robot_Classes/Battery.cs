using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Classes 
{
    
    public class Battery : IPowerSource 
    {

        public Battery()
        {

        }

        public int batteryLife;
        
        public void setBatteryLife(int life) 
        {
            batteryLife = life;
            Console.WriteLine("Battery life is " + batteryLife);
        }

        public void turnOn()
        {
            Console.WriteLine("Robot is On");
        }

        public void consumePower(int rateOfConsumption)
        {
            Console.WriteLine("Robot is Consuming Power");
            this.batteryLife = this.batteryLife - rateOfConsumption;
            Console.WriteLine("Battery life is now " + this.batteryLife);
        }
    }
}