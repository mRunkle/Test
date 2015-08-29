using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREATE ROMAN-ARABIC NUMERAL PAIRS
            BaseNumerals baseNumerals = new BaseNumerals();
            baseNumerals.createRomanBase();

            //STORE BASE NUMERAL COLLECTION IN MAIN() DICTIONARY
            Dictionary<string, int> numeralCollection = baseNumerals.BaseNumeralsCollection;


            foreach (KeyValuePair<string, int> pair in numeralCollection)
            {
                Console.WriteLine(pair);
            }

            Console.WriteLine("Enter either Roman or Arabic numeral for conversion: ");
            var userInput = Console.ReadLine();

            Console.WriteLine(userInput);

            Console.ReadLine();
        }
    }
}
