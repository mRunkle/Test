using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Classes {
    
    abstract class Locomotion {
        
        public IPart part;

        public Locomotion(IPart part) {
            this.part = part;
        }
    }
}
