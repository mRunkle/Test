using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2
{
    public class Subtraction
    {
        protected decimal difference;

        public decimal subtractNumbers(decimal input1, decimal input2)
        {
            this.difference = Decimal.Subtract(input1, input2);
            return this.difference;
        }
    }
}
