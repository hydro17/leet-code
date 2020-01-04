using System;

namespace LongestPalindromicSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string possiblePalindrome = "abbaddddcX1XcDdaavbvffgrrea";

            Solution s = new Solution();

            Console.WriteLine(s.LongestPalindrome(possiblePalindrome));
        }
    }

    public class Solution
    {
        public string LongestPalindrome(string str)
        {
            string longestPalindrome = "";

            for (int i = 0; i < str.Length; i++)
            {
                if ((str.Length - i) < longestPalindrome.Length) break;

                for (int j = 1; j <= str.Length - i; j++)
                {
                    if (j < longestPalindrome.Length) continue;

                    string possiblePalindrome = str.Substring(i, j);
                    
                    if (IsPalindrome(possiblePalindrome)) {
                        string palindrome = possiblePalindrome;

                        if (palindrome.Length > longestPalindrome.Length)
                        {
                            longestPalindrome = palindrome;
                        }
                    } 

                } 
            }

            return longestPalindrome;
        }

        private bool IsPalindrome(string possiblePalindrome)
        {
            for (int i = 0, j = possiblePalindrome.Length - 1; i < j; i++, j--)
            {
                if (possiblePalindrome[i] != possiblePalindrome[j]) return false;
            }

            return true;
        }
    }
}
