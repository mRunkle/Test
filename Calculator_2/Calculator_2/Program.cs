using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put down that abacus, and enter your math here!");
            string userInput = Console.ReadLine();

            if (userInput.Contains("+"))
            {
                CallAddition addition = new CallAddition();
                addition.AdditionCall(userInput);
            }
            else if (userInput.Contains("-"))
            {
                CallSubtraction subtraction = new CallSubtraction();
                subtraction.SubtractionCall(userInput);
            }
            else if (userInput.Contains("*"))
            {
                CallMultiplication multiplication = new CallMultiplication();
                multiplication.MultiplicationCall(userInput);
            }
            else if (userInput.Contains("/"))
            {
                CallDivision division = new CallDivision();
                division.DivisionCall(userInput);
            }
        }
    }
}
