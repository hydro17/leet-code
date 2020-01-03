using System;

namespace LongestPalindromicSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string possiblePalindrome = "abba";

            Solution s = new Solution();

            //Console.WriteLine($"abba: {s.IsPalindrome("abba")}");
            //Console.WriteLine($"abb: {s.IsPalindrome("abb")}");
            //Console.WriteLine($"b: {s.IsPalindrome("b")}");
        }

       

        //public static string LongestPalindrome(string s)
        //{

        //}
    }

    public class Solution
    {
        public string LongestPalindrome(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {

            }
            str.Substring()

            return null;
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
