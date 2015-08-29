using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2
{
    public class Division
    {
        protected decimal quotient;

        public decimal divideNumbers(decimal input1, decimal input2)
        {
            this.quotient = input1 / input2;
            return this.quotient;
        }
    }
}
