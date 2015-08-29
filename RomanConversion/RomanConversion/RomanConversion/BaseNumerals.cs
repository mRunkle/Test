using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanConversion
{
    public class BaseNumerals
    {
        protected Dictionary<string, int> baseNumeralCollection = new Dictionary<string, int>();

        protected void addToBaseNumeralCollection(RomanCharacter romanCharacter)
        {
            string roman = romanCharacter.Roman;
            int arabic = romanCharacter.Arabic;

            baseNumeralCollection.Add(roman, arabic);
        }

        public void createRomanBase()
        {
            RomanCharacter one = new RomanCharacter("I", 1);
            addToBaseNumeralCollection(one);

            RomanCharacter five = new RomanCharacter("V", 5);
            addToBaseNumeralCollection(five);

            RomanCharacter ten = new RomanCharacter("X", 10);
            addToBaseNumeralCollection(ten);

            RomanCharacter fifty = new RomanCharacter("L", 50);
            addToBaseNumeralCollection(fifty);

            RomanCharacter oneHundred = new RomanCharacter("C", 100);
            addToBaseNumeralCollection(oneHundred);

            RomanCharacter fiveHundred = new RomanCharacter("D", 500);
            addToBaseNumeralCollection(fiveHundred);

            RomanCharacter oneThousand = new RomanCharacter("M", 1000);
            addToBaseNumeralCollection(oneThousand);
        }

        public Dictionary<string, int> BaseNumeralsCollection
        {
            get
            {
                return baseNumeralCollection;
            }
        }
    }
}
