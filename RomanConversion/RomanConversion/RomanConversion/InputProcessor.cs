using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanConversion
{
    public class InputProcessor
    {
        //MEMBER VARIABLES
        public int numericalValue;
        public string romanicalValue;
        public List<int> numericalDigits = new List<int>();
        public List<char> romanicalDigits = new List<char>();

        //CONSTRUCTORS
        public InputProcessor(string romanNumeral)
        {

        }
        
        public InputProcessor(int arabicNumeral)
        {
            
        }
    }
}
