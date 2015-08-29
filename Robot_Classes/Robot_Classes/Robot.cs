using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Classes 
{
    
    public abstract class Robot 
    {
       
        protected IPowerSource powerSource;
        protected IPart part;

        public Robot(IPowerSource powerSource, IPart part) 
        {
            this.powerSource = powerSource;
            this.part = part;
        }
    }
}
