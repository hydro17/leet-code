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
            if (str == null) return "";
            
            strToCheckForPalindrome = str;

            for (int i = 0; i < strToCheckForPalindrome.Length; i++)
            {
                FindOddLongestPalindrome(i);
                FindEvenLongestPalindrome(i);
            }

            return longestPalindrome;
        }

        private void FindOddLongestPalindrome(int i)
        {
            int first, last;
            first = last = i;

            FindLongestPalindrome(first, last);
        }

        private void FindEvenLongestPalindrome(int i)
        {
            int first = i;
            int last = i + 1;

            if (last < strToCheckForPalindrome.Length)
            {
                if (strToCheckForPalindrome[first] == strToCheckForPalindrome[last])
                {
                    FindLongestPalindrome(first, last);
                }
            }
        }

        private void FindLongestPalindrome(int first, int last)
        {
            while (TryNextFirstAndLast(first, last, strToCheckForPalindrome, out int nextFirst, out int nextLast)
                                && strToCheckForPalindrome[nextFirst] == strToCheckForPalindrome[nextLast])
            {
                first = nextFirst;
                last = nextLast;
            }

            string palindrome = strToCheckForPalindrome.Substring(first, last - first + 1);

            if (palindrome.Length > longestPalindrome.Length)
            {
                longestPalindrome = palindrome;
            }
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
