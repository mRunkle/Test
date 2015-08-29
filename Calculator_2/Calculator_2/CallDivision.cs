using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2
{
    public class CallDivision : Division
    {
        protected decimal answer;

        public decimal DivisionCall(string userInput)
        {
            string[] inputSplit = userInput.Split('/');
            decimal[] inputDecimals = new decimal[inputSplit.Length];
            for (int i = 0; i < inputSplit.Length; i++)
            {
                inputDecimals[i] = decimal.Parse(inputSplit[i]);
            }

            this.answer = base.divideNumbers(inputDecimals[0], inputDecimals[1]);

            Console.WriteLine(this.answer);
            Console.ReadLine();
            return this.answer;
        }
    }
}
