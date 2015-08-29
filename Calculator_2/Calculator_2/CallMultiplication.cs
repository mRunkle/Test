﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2
{
    public class CallMultiplication : Multiplication
    {
        protected decimal answer;

        public decimal MultiplicationCall(string userInput)
        {
            string[] inputSplit = userInput.Split('*');
            decimal[] inputDecimals = new decimal[inputSplit.Length];
            for (int i = 0; i < inputSplit.Length; i++)
            {
                inputDecimals[i] = decimal.Parse(inputSplit[i]);
            }

            this.answer = base.multiplyNumbers(inputDecimals[0], inputDecimals[1]);

            Console.WriteLine(answer);
            Console.ReadLine();
            return answer;
        }
    }
}
