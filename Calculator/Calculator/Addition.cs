using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
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
