using System;
using System.Collections.Generic;
using System.Text;

namespace LetterCombinationsOfPhoneNumber
{
    class Solution
    {
        private IDictionary<char, string> digitLetterMapping = new Dictionary<char, string>
        {
            ['2'] = "abc",
            ['3'] = "def",
            ['4'] = "ghi",
            ['5'] = "jkl",
            ['6'] = "mno",
            ['7'] = "pqrs",
            ['8'] = "tuv",
            ['9'] = "wxyz"
        };

        private IList<string> letterCombinations = new List<string>();

        public IList<string> LetterCombinations(string digits)
        {
            MakeLetterCombinations("", digits);

            return letterCombinations;
        }

        private void MakeLetterCombinations(string letterCombination, string digits)
        {
            if (digits.Length == 0 && letterCombination.Length != 0)
            {
                letterCombinations.Add(letterCombination);
                return;
            }

            string letters = digitLetterMapping[digits[0]];

            for (int i = 0; i < letters.Length; i++)
            {
                MakeLetterCombinations(letterCombination + letters[i], digits.Substring(1));
            }
        }
    }
}
