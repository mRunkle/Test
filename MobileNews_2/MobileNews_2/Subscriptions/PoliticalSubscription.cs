using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileNews_2
{
    public class PoliticalSubscription : Subscription
    {
        Subscription subscription;

        //CONSTRUCTOR
        public PoliticalSubscription(Subscription subscription)
        {
            this.subscription = subscription;
        }

        //METHODS
        public override string Description()
        {
            return subscription.Description() + "Politics ";
        }
    }
}
