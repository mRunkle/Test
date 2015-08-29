using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class Tree
    {
        Node top;

        public Tree()
        {
            top = null;
        }

        public Tree(int initialValue)
        {
            top = new Node(initialValue);
        }

        public void AddRc(int value)
        {
            // recursive add
            AddR(ref top, value);
        }

        private void AddR(ref Node N, int value)
        {
            // recursive search for where to add new node
            if (N == null)
            {
                // Node doesn't exist add it here
                Node newNode = new Node(value);
                N = newNode; // set the old node reference to the newly created node thus attaching it to the tree
                return; // end the function call and fall back
            }

            if (value < N.value)
            {
                AddR(ref N.left, value);
                return;
            }

            if (value >= N.value)
            {
                AddR(ref N.right, value);
                return;
            }
        }

        public void Print(Node N, ref string s)
        {
            // write out the tree in sorted order to the string s
            // implement using recursion
            if (N == null)
            {
                N = top;
            }

            if (N.left != null)
            {
                Print(N.left, ref s);
                s = s + N.value.ToString().PadLeft(3);
            }
            else
            {
                s = s + N.value.ToString().PadLeft(3);
            }

            if (N.right != null)
            {
                Print(N.right, ref s);
            }
        }

        // non-recursive add
        //public void add(int value)
        //{
        //    // non-recursive add
        //    if (top == null) // tree is empty
        //    {
        //        // add value as base node
        //        Node newNode = new Node(value);
        //        top = newNode;
        //        return;
        //    }

        //    Node currentNode = top;
        //    bool added = false;
        //    while (!added)
        //    {
        //        // traverse tree
        //        if (value < currentNode.value)
        //        {
        //            // go left
        //            if (currentNode.left == null)
        //            {
        //                // Add item
        //                Node newNode = new Node(value);
        //                currentNode.left = newNode;
        //                added = true;
        //            }
        //            else
        //            {
        //                currentNode = currentNode.left;
        //            }
        //        }

        //        // go right
        //        if (value >= currentNode.value)
        //        {
        //            if (currentNode.right == null)
        //            {
        //                Node newNode = new Node(value);
        //                currentNode.right = newNode;
        //                added = true;
        //            }
        //            else
        //            {
        //                currentNode = currentNode.right;
        //            }
        //        }
        //    }
        //}
    }
}
