using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Multiplication
    {
        protected decimal product;

        public decimal multiplyNumbers(decimal input1, decimal input2)
        {
            this.product = input1 * input2;
            return this.product;
        }
    }
}
