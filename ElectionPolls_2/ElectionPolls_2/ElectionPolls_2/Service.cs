using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ElectionPolls_2
{
    public class Service
    {
        public List<string> filterFile(string fileName)
        {
            //Read all lines of source file
            string[] pollReportLines = File.ReadAllLines(fileName);

            //Strip general election polls from source
            List<string> generalElectionPolls = pollReportLines.Where(p => p.Contains("+") && p.Contains("vs")).ToList();

            //Split general election poll results to allow access to winner segment - i.e. Clinton +6
            List<string[]> splitGeneralElectionPolls = generalElectionPolls.Select(g => g.Split(',')).ToList();

            //Create list of winner segments
            List<string> generalElectionWinners = new List<string>();
            splitGeneralElectionPolls.ForEach(s =>
            {
                foreach (string dataLine in s)
                {
                    if (dataLine.Contains('+'))
                    {
                        generalElectionWinners.Add(dataLine);
                    }
                }
            });

            //Reformat list of winner segments from "Clinton +6" to "Clinton,6"
            List<string> formatGeneralElectionWinners = new List<string>();
            generalElectionWinners.ForEach(g =>
            {
                g = g.Replace(" +", ",");
                formatGeneralElectionWinners.Add(g);
            });

            return formatGeneralElectionWinners;
        }

        public List<string[]> splitFilteredData(List<string> filteredData)
        {
            List<string[]> splitFilteredData = new List<string[]>();
            foreach (string s in filteredData)
            {
                string[] splitString;
                splitString = s.Split(',');

                splitFilteredData.Add(splitString);
            }

            return splitFilteredData;
        }

        public Dictionary<string, int> resultsCollection(List<string[]> splitFilteredData)
        {
            Dictionary<string, int> resultsCollection = new Dictionary<string, int>();
            foreach (string[] result in splitFilteredData)
            {
                if (!resultsCollection.ContainsKey(result[0]))
                {
                    resultsCollection.Add(result[0], int.Parse(result[1]));
                }
                else
                {
                    resultsCollection[result[0]] += int.Parse(result[1]);
                }
            }

            return resultsCollection;
        }
    }
}
