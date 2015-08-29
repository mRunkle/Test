using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS_Test
{
    public class Shipments
    {
        public int sumEven(int[] numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        public int[] Numbers { get; set; }
    }
}
