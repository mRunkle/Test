using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileNews_3
{
    public class SportsSubscription : Subscription
    {
        Subscription subscription;

        //CONSTRUCTOR
        public SportsSubscription(Subscription subscription)
        {
            this.subscription = subscription;
        }

        //METHODS
        public override string Description()
        {
            return subscription.Description() + "Sports ";
        }
    }
}
