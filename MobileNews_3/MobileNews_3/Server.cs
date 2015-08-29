using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileNews_3
{
    public class Server
    {
        protected List<Phone> phoneRefList = new List<Phone>();
        protected Subscription compiledSubscription = null;

        //METHODS
        public void CreateSubscriptions(List<string> feedsToSubscribe)
        {
            for (int i = 0; i < feedsToSubscribe.Count; i++)
            {
                switch (feedsToSubscribe[i].ToLower())
                {
                    case "":
                        break;

                    case "politics":
                        PoliticalSubscription politicalSubscription = new PoliticalSubscription(compiledSubscription);
                        this.compiledSubscription = politicalSubscription;
                        break;

                    case "sports":
                        SportsSubscription sportsSubscription = new SportsSubscription(compiledSubscription);
                        this.compiledSubscription = sportsSubscription;
                        break;

                    default:
                        break;
                } 
            }
        }
        
        public void AddToPhoneRefList(Phone phone)
        {

        }

        public Subscription CompiledSubscription
        {
            get
            {
                return compiledSubscription;
            }
        }
    }
}
