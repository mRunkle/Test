using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Classes
{
    class DolphinRobot : Robot 
    {

        public int rateOfConsumption = 0;  //added


        public DolphinRobot(IPowerSource powerSource, IPart part) : base(powerSource, part) 
        {
            this.rateOfConsumption = 2; //added
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



























































        public void printImage() {
            Console.WriteLine("                                          .--.");
            Console.WriteLine("                  _______             .-'  .'");
            Console.WriteLine("          .---u'''       ''''---._  .'    %");
            Console.WriteLine("        .'                        '--.    %");
            Console.WriteLine("  __.--'  o                          ''.. '");
            Console.WriteLine("(____.                                  ':");
            Console.WriteLine("  `----.__                                 '.");
            Console.WriteLine("            `----------__                     '");
            Console.WriteLine("                   '.   . ''--.                 '.");
            Console.WriteLine("                      '. '. bIt ''-.              '.");
            Console.WriteLine("                         '-.)        ''-.           '.");
            Console.WriteLine("                                          ''.         '.");
            Console.WriteLine("                                             ''.       '.");
            Console.WriteLine("                                                ''.      '.");
            Console.WriteLine("                                                  ''.    '.");
            Console.WriteLine("                             ^~^~^~^~^~^~^~^~^~^~^~^~^''.  '^~^~^~^~^");
            Console.WriteLine("                                                  ^~^~^~^  ~^~");
            Console.WriteLine("                                                       ^~^~^~");
        }
    }
}
