using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2
{
    public class CallAddition : Addition
    {
        protected decimal answer;

        public decimal AdditionCall(string userInput)
        {
            string[] inputSplit = userInput.Split('+');
            decimal[] inputDecimals = new decimal[inputSplit.Length];
            for (int i = 0; i < inputSplit.Length; i++)
            {
                inputDecimals[i] = decimal.Parse(inputSplit[i]);
            }

            this.answer = base.addNumbers(inputDecimals);

            Console.WriteLine(this.answer);
            Console.ReadLine();
            return this.answer;
        }
    }
}
