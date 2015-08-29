using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileNews_3
{
    public class Connection
    {
        Server server;
        List<NewsFeed> newsFeedList = new List<NewsFeed>();

        //CONSTRUCTOR
        public Connection(Server server)
        {
            this.server = server;
        }

        //Server communication


        //News Feed communication
        public void AddNewsFeed(NewsFeed newsFeed)
        {
            newsFeedList.Add(newsFeed);
        }

        public List<NewsFeed> NewsFeedList
        {
            get
            {
                return newsFeedList;
            }
        }

        public void IsNewContentAvailable()
        {

        }

        public void GetAllContent()
        {

        }
    }
}
