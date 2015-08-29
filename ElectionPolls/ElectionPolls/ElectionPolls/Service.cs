using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ElectionPolls
{
    public class Service
    {
        string lastName;
        List<int> ratings;

        public Candidate createCandidateFromFile(string fileName)
        {
            var reader = new StreamReader(File.OpenRead(@"C:\Users\mrunkle_he\Desktop\" + fileName));
            
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var value = line.Split(',');

                lastName = value[0];

                for (int i = 1; i < value.Length; i++)
                {
                    ratings.Add(int.Parse(value[i]));
                }
            }

            return new Candidate(lastName, ratings);
        }
    }
}