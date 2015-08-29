using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileNews_3
{
    public class PoliticalNewsFeed : NewsFeed
    {
        public PoliticalNewsFeed(string story)
        {
            this.pageName = "Politics";
            Content = story;
        }
    }
}
