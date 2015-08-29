using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanConversion
{
    public class RomanCharacter
    {
        //MEMBER VARIABLES
        string roman;
        int arabic;

        //CONSTRUCTOR
        public RomanCharacter(string romanCharacter, int arabicEquivalent)
        {
            this.roman = romanCharacter;
            this.arabic = arabicEquivalent;
        }

        //ACCESSORS
        public string Roman
        {
            get
            {
                return roman;
            }
        }

        public int Arabic
        {
            get
            {
                return arabic;
            }
        }





        //CONVERSION METHODS
        //public string ConvertArabicToRoman(int arabicNumeral)
        //{
        //    if (characterDictionary.ContainsValue(arabicNumeral))
        //    {
        //        this.roman = characterDictionary.FirstOrDefault(x => x.Value == arabicNumeral).Key;

        //        return this.roman;
        //    }
        //    else
        //    {
        //        return "Invalid Entry";
        //    }
        //}

        //public int ConvertRomanToArabic(string romanCharacter)
        //{
        //    if (characterDictionary.ContainsKey(romanCharacter))
        //    {
        //        this.arabic = characterDictionary.LastOrDefault(x => x.Key == romanCharacter).Value;

        //        return this.arabic;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}
    }
}
