using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class List
    {
        public Node headNode;

        public List()
        {
            headNode = null;
        }

        public void addToEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                addToBeginning(data);
            }
        }

        public void addSorted(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else if (data < headNode.data)
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
            else
            {
                headNode.addSorted(data);
            }
        }

        public void addToBeginning(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
        }

        public void print()
        {
            if (headNode != null)
            {
                headNode.print();
            }
        }
    }
}
