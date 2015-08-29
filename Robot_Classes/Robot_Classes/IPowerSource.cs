using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Classes 
{
    
    public interface IPowerSource 
    {
    
        void turnOn();
        
        void consumePower(int rateOfConsumption);
    }
}
