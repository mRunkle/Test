using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileNews_2
{
    public class Phone
    {
        protected int phoneID;
        protected List<Subscription> phoneSubscriptionList = new List<Subscription>();
        protected string subscriptionListString;
        protected int subscriptionsOnPhone;

        public Phone(int phoneID)
        {
            this.phoneID = phoneID;
        }


        //METHODS
        public void Subscribe(Subscription subscription)
        {
            phoneSubscriptionList.Add(subscription);
        }
        
        public string ExtractSubscriptionsOnPhone()
        {
            int totalSubscriptions;

            foreach (Subscription subscription in phoneSubscriptionList)
            {
                this.subscriptionListString = subscription.Description();
            }

            //string[] split = subscriptionListString.Split(" ");

            return subscriptionListString;
        }

        //ACCESSORS        
        public int PhoneID
        {
            get
            {
                return phoneID;
            }
        }

        public List<Subscription> PhoneSubscriptionList
        {
            get
            {
                return phoneSubscriptionList;
            }
        }

        public int SubscriptionsOnPhone
        {
            get
            {
                return subscriptionsOnPhone;
            }
        }

        public string SubscriptionListString
        {
            get
            {
                return subscriptionListString;
            }
        }
    }

}
