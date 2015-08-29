using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HigherOrderFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //LIST CREATION & SORT FOR BINARY
            List<int> numberList = new List<int>() { 12, 17, 984, 230, 48, 7, 1, 507 }; //sorted => 1, 7, 12, 17, 48, 230, 507, 984
            var sortedList = (numberList.OrderBy(i => i)).ToList();

            //STOPWATCH CREATION FOR FUNCTION TIMING
            Stopwatch sortStopwatch = new Stopwatch();
            Stopwatch sequentialStopwatch = new Stopwatch();
            Stopwatch binaryStopwatch = new Stopwatch();

            //FUNCTION CALLS WRAPPED FOR TIMING
            Functions functions = new Functions();
            //sort
            sortStopwatch.Start();
            int sortResult = functions.highOrderSort(functions.sort, numberList);
            sortStopwatch.Stop();
            
            //sequential
            sequentialStopwatch.Start();
            int sequentialResult = functions.highOrderSequentialSort(functions.sequentialSort, numberList);
            sequentialStopwatch.Stop();

            //binary
            binaryStopwatch.Start();
            int binaryResult = functions.highOrderBinarySearch(functions.binarySearch, sortedList, 48);
            binaryStopwatch.Stop();

            //WRITE SORT RESULTS AND TIMING CALC
            Console.WriteLine(sortResult);
            Console.WriteLine("Sort Time: {0}", sortStopwatch.Elapsed.TotalMilliseconds);
            Console.WriteLine(Environment.NewLine);
            
            Console.WriteLine(sequentialResult);
            Console.WriteLine("Sequential Time: {0}", sequentialStopwatch.Elapsed.TotalMilliseconds);
            Console.WriteLine(Environment.NewLine);
            
            Console.WriteLine(binaryResult);
            Console.WriteLine("Binary Time: {0}", sequentialStopwatch.Elapsed.TotalMilliseconds);
            Console.WriteLine(Environment.NewLine);


            Console.ReadLine();
        }
    }
}
