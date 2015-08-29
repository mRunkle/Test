using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileNews_3
{
    public class Phone
    {
        List<string> phoneSubscriptionInput = new List<string>();

        //CONSTRUCTORS
        public Phone(string subscription1)
        {
            this.phoneSubscriptionInput.Add(subscription1);
        }

        public Phone(string subscription1, string subscription2)
        {
            this.phoneSubscriptionInput.Add(subscription1);
            this.phoneSubscriptionInput.Add(subscription2);
        }

        //ACCESSORS        
        public List<string> PhoneSubscriptionInput
        {
            get
            {
                return phoneSubscriptionInput;
            }
        }

        /*
        public List<Subscription> SubscriptionObjectsOnPhone
        {
            get
            {
                return subscriptionObjectsOnPhone;
            }
            set
            {
                subscriptionObjectsOnPhone = value;
            }
        }
        */
    }
}