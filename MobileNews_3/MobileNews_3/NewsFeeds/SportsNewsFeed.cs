using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileNews_3
{
    public class SportsNewsFeed : NewsFeed
    {
        public SportsNewsFeed(string story)
        {
            this.pageName = "Sports";
            Content = story;
        }
    }
}
