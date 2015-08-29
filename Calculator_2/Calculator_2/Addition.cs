using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2
{
    public class Addition
    {
        protected decimal sum;

        public decimal addNumbers(decimal[] input)
        {
            this.sum = input.Sum();
            return this.sum;
        }
    }
}
