using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS_Test
{
    class Program
    {
        public class WordTools
        {
            public static string ReverseWords(string sentence)
            {
                string[] words = sentence.Split(' ');
                Array.Reverse(words);
                return string.Join(" ", words);
            }
        }

        static string substringMethod2(string input, StringBuilder buffer)
        {
            buffer.Clear();
            buffer.Append(input, 3, 2);
            return buffer.ToString();
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(string.Join(" ", ((Enumerable.Range(0, 1001)).ToArray())));

            //***********************************************************//

            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Shipments shipments = new Shipments();

            //int sum = shipments.sumEven(numbers);

            //Console.WriteLine(sum);
            //Console.ReadLine();

            //***********************************************************//

            //const string s1 = "Bill Gates is the richest man on Earth";

            //string rev1 = WordTools.ReverseWords(s1);
            //Console.WriteLine(rev1);

            //***********************************************************//

            StringBuilder buffer = new StringBuilder();

            Console.WriteLine(buffer.ToString());

            string input = "A string of test words";
            string output = substringMethod2(input, buffer);

            Console.WriteLine(input);
            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}
