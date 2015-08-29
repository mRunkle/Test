using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ElectionPolls_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take in file --- Filter data --- Format data
            Service service = new Service();
            List<string> filteredData = service.filterFile(@"C:\Users\mrunkle_he\Desktop\Polls_Master.csv");
            List<string[]> splitFilteredData = service.splitFilteredData(filteredData);
            
            // Sort dictionary of tallied results to find projected winner
            Dictionary<string, int> resultsCollection = service.resultsCollection(splitFilteredData);
            List<int> resultValues = resultsCollection.Values.ToList();
            List<int> descendingSort = resultValues.OrderByDescending(r => r).ToList();

            string projectedWinner;
            projectedWinner = resultsCollection.First(r => r.Value == descendingSort[0]).Key;

            Console.WriteLine("Projected 2016 Winner: " + projectedWinner);

            Console.ReadLine();
        }
    }
}
