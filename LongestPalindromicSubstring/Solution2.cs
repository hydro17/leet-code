using System;
using System.Collections.Generic;
using System.Text;

namespace LongestPalindromicSubstring
{
    class Solution2
    {
        private string strToCheckForPalindrome;
        private string longestPalindrome = "";

        public string LongestPalindrome(string str)
        {
            strToCheckForPalindrome = str;

            if (strToCheckForPalindrome == null) return "";

            for (int i = 0; i < strToCheckForPalindrome.Length; i++)
            {
                int first, last;
                first = last = i;

                string palindrome = FindLongestPalindrome(first, last);

                if (palindrome.Length > longestPalindrome.Length)
                {
                    longestPalindrome = palindrome;
                }

                if (i + 1 >= strToCheckForPalindrome.Length) continue;
                if (strToCheckForPalindrome[i] != strToCheckForPalindrome[i + 1]) continue;

                first = i;
                last = i + 1;

                palindrome = FindLongestPalindrome(first, last);

                if (palindrome.Length > longestPalindrome.Length)
                {
                    longestPalindrome = palindrome;
                }
            }

            return longestPalindrome;
        }

        private string FindLongestPalindrome(int first, int last)
        {
            while (TryNextFirstAndLast(first, last, strToCheckForPalindrome, out int nextFirst, out int nextLast)
                                && strToCheckForPalindrome[nextFirst] == strToCheckForPalindrome[nextLast])
            {
                first = nextFirst;
                last = nextLast;
            }

            string palindrome = strToCheckForPalindrome.Substring(first, last - first + 1);
            return palindrome;
        }

        private bool TryNextFirstAndLast(int first, int last, string str, out int nextFirst, out int nextLast)
        {
            nextFirst = first - 1;
            nextLast = last + 1;
            if (nextFirst >= 0 && nextLast < str.Length) return true;
            else return false;
        }
    }
}
