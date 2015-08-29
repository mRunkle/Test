using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionPolls_2
{
    public class Candidate
    {
        protected string lastName;
        protected List<int> pollRatings;

        public Candidate(Dictionary<string, int> candidateData)
        {
            //this.lastName = candidateData.Keys;
            //this.pollRatings.Add(rating);
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public List<int> PollRatings
        {
            get
            {
                return pollRatings;
            }
        }

        public void addPollRating(int rating)
        {
            this.pollRatings.Add(rating);
        }
    }
}