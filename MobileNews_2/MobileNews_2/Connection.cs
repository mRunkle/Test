using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileNews_2
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
        public void AddPhoneToServer(Phone phone)
        {
            switch (phone.SubscriptionsOnPhone)
            {
                case 0:
                    break;
                case 1:
                    server.AddToPhoneRefList(phone, 1);
                    break;
                case 2:
                    server.AddToPhoneRefList(phone, 2);
                    break;
                default:
                    break;
            }
        }

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
