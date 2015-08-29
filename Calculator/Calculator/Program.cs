using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter elegant mathematical operation to be solved >");
            string userInput = Console.ReadLine();
            FunctionCall functionCall = new FunctionCall();

            if (userInput.Contains("+"))
            {
                FunctionCall callAdder = new FunctionCall();
                callAdder.callAddition(userInput);
            }
            else if (userInput.Contains("-"))
            {
                FunctionCall callSubtract = new FunctionCall();
                callSubtract.callSubtraction(userInput);
            }
            else if (userInput.Contains("*"))
            {
                FunctionCall callMultiplication = new FunctionCall();
                callMultiplication.callMultiplication(userInput);
            }
            else if (userInput.Contains("/"))
            {
                FunctionCall callDivision = new FunctionCall();
                callDivision.callDivision(userInput);
            }
        }
    }
}
