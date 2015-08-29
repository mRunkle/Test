using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileNews_2
{
    public class NewsFeed
    {
        protected string pageName;
        protected string content;
        protected bool newContent = false;

        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }

        public bool NewContent
        {
            get
            {
                return newContent;
            }
            set
            {
                newContent = value;
            }
        }

        public string PageName
        {
            get
            {
                return pageName;
            }
        }
    }
}
