using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int initialValue)
        {
            value = initialValue;
            left = null;
            right = null;
        }
    }
}
