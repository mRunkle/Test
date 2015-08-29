using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Classes 
{
    
    class Program 
    {
        
        static void Main(string[] args) 
        {
            /**** ELEMENTS USED BY ALL ROBOT TYPES ****/
            //Declare Battery
            Battery b = new Battery();

            //Declare Coal Furnace
            CoalFurnace cf = new CoalFurnace();

            //Randomly establish battery life or available coal
            Random rnd = new Random();
            int bLife = rnd.Next(1, 101);

            //Random number generator for call of either service or replace method
            Random sr = new Random();
            int serviceRandom = rnd.Next(1, 51);



            /**** RANDOMLY GENERATE ROBOT DECLARATION ****/
            Random gr = new Random();
            int generatorRandom = gr.Next(1, 1001);

            if (generatorRandom % 2 == 0) 
            {
                //BUTTER ROBOT DECLARATION
                BionicLegs l = new BionicLegs();
                ButterRobot br = new ButterRobot(cf, l);

                Console.WriteLine("STAND BY: Generating Butter Robot");
                Console.ReadLine();
 
                //POWER
                br.turnOn();
                Console.ReadLine();

                //Console write battery life
                //b.setBatteryLife(bLife);
                cf.setAvailableCoal(bLife);
                Console.ReadLine();
                
                br.usePower();
                Console.ReadLine();
                

                //SERVICE
                if(serviceRandom % 2 == 0) 
                {
                    br.servicePart();
                    Console.ReadLine();
                }
                else 
                {
                    br.replacePart();
                    Console.ReadLine();
                }
            }
            else 
            {
                //DOLPHIN ROBOT DECLARATION
                BionicFlipper f = new BionicFlipper();
                DolphinRobot dr = new DolphinRobot(cf, f);

                Console.WriteLine("STAND BY: Generating Dolphin Robot");
                dr.printImage();                   
                Console.ReadLine();

                //POWER
                dr.turnOn();
                Console.ReadLine();

                //Console write battery life
                //b.setBatteryLife(bLife);
                cf.setAvailableCoal(bLife);
                Console.ReadLine();

                dr.usePower();
                Console.ReadLine();


                //SERVICE
                if (serviceRandom % 2 == 0)
                {
                    dr.servicePart();
                    Console.ReadLine();
                }
                else
                {
                    dr.replacePart();
                    Console.ReadLine();
                }
            }
        }
    }
}
