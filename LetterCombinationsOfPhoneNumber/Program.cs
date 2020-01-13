using System;
using System.Collections.Generic;

namespace LetterCombinationsOfPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> letterCombinations = new Solution().LetterCombinations("23");

            foreach(string comb in letterCombinations)
            {
                Console.WriteLine(comb);
            }
        }
    }
}
