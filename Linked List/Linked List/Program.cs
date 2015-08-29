using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            //list.addToEnd(9);
            //list.addToEnd(5);
            //list.addToEnd(7);
            //list.addToEnd(11);

            //list.addToBeginning(9);
            //list.addToBeginning(5);
            //list.addToBeginning(7);
            //list.addToBeginning(11);

            //test comments

            list.addSorted(9);
            list.addSorted(5);
            list.addSorted(7);
            list.addSorted(11);

            list.print();

            Console.ReadLine();
        }
    }
}
