using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HigherOrderFunctions
{
    public class Functions
    {
        //BASE FUNCTIONS
        public int sort(List<int> list)
        {
            var sortedList = (list.OrderByDescending(i => i)).ToList();

            return sortedList[0];
        }

        public int binarySearch(List<int> orderedList, int target)
        {
            int start = 0;
            int end = (orderedList.Count - 1);
            int mid;

            while (start <= end)
            {
                mid = (start + end) / 2;
                if (orderedList[mid] < target)
                {
                    start = mid + 1;
                    continue;
                }
                else if (orderedList[mid] > target)
                {
                    end = mid - 1;
                    continue;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }

        public int sequentialSort(List<int> list)
        {
            int largestNumber = 0;
            foreach (int i in list)
            {
                if (i > largestNumber)
                {
                    largestNumber = i;
                }
            }
            return largestNumber;
        }


        //HIGH ORDER FUNCTIONS
        public int highOrderSort(Func<List<int>, int> pick, List<int> numberList)
        {           
            return pick(numberList);
        }

        public int highOrderBinarySearch(Func<List<int>, int, int> pick, List<int> numberlist, int target)
        {
            return pick(numberlist, target);
        }

        public int highOrderSequentialSort(Func<List<int>, int> pick, List<int> numberList)
        {
            return pick(numberList);
        }
    }
}
