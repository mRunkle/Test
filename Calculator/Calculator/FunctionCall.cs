using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class FunctionCall
    {
        public decimal callAddition(string userInput)
        {
            string[] inputSplit = userInput.Split('+');
            decimal[] inputDecimals = new decimal[inputSplit.Length];
            for (int i = 0; i < inputSplit.Length; i++)
            {
                inputDecimals[i] = decimal.Parse(inputSplit[i]);
            }

            Addition firstAdder = new Addition();
            decimal answer = firstAdder.addNumbers(inputDecimals);

            Console.WriteLine(answer);
            Console.ReadLine();
            return answer;
        }

        public decimal callSubtraction(string userInput)
        {
            string[] inputSplit = userInput.Split('-');
            decimal[] inputDecimals = new decimal[inputSplit.Length];
            for (int i = 0; i < inputSplit.Length; i++)
            {
                inputDecimals[i] = decimal.Parse(inputSplit[i]);
            }

            Subtraction firstSubtraction = new Subtraction();
            decimal answer = firstSubtraction.subtractNumbers(inputDecimals[0], inputDecimals[1]);

            Console.WriteLine(answer);
            Console.ReadLine();
            return answer;
        }

        public decimal callMultiplication(string userInput)
        {
            string[] inputSplit = userInput.Split('*');
            decimal[] inputDecimals = new decimal[inputSplit.Length];
            for (int i = 0; i < inputSplit.Length; i++)
            {
                inputDecimals[i] = decimal.Parse(inputSplit[i]);
            }

            Multiplication firstMultiply = new Multiplication();
            decimal answer = firstMultiply.multiplyNumbers(inputDecimals[0], inputDecimals[1]);

            Console.WriteLine(answer);
            Console.ReadLine();
            return answer;
        }

        public decimal callDivision(string userInput)
        {
            string[] inputSplit = userInput.Split('/');
            decimal[] inputDecimals = new decimal[inputSplit.Length];
            for (int i = 0; i < inputSplit.Length; i++)
            {
                inputDecimals[i] = decimal.Parse(inputSplit[i]);
            }

            Division firstDivide = new Division();
            decimal answer = firstDivide.divideNumbers(inputDecimals[0], inputDecimals[1]);

            Console.WriteLine(answer);
            Console.ReadLine();
            return answer;
        }
    }
}
