using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileNews_2
{
    public class Server
    {
        protected List<Phone> phoneRefList = new List<Phone>();
        protected int totalSubscriptions = 0;

        public void AddToPhoneRefList (Phone phone, int numberOfSubscriptions)
        {
            phoneRefList.Add(phone);
            this.totalSubscriptions += numberOfSubscriptions;
        }

        public int TotalSubscriptions
        {
            get
            {
                return totalSubscriptions;
            }
        }
    }
}
