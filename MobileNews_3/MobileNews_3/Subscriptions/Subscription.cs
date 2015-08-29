using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileNews_3
{
    public class Subscription
    {
        protected string description;

        public virtual string Description()
        {
            return description;
        }
    }
}
