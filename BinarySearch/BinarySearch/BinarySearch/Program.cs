using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            List<int> unorderedList = new List<int>() { 43, 85, 7, 6, 34, 2, 4, 18, 3};
            List<string> orderedList = new List<string>(); // empty. why is it here?

            foreach (int i in unorderedList)
            {
                tree.AddRc(i);
            }

            string treeString = "";
            tree.Print(null, ref treeString);
            Console.WriteLine(treeString);

            Console.ReadLine();
        }
    }
}
