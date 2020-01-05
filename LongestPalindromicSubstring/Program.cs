using System;

namespace LongestPalindromicSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string possiblePalindrome1 = "abbaddddcX1XcDdaavbvffgrrea";
            string possiblePalindrome2 = "abbaddddcX11XcDdaavbvffgrrea";

            Solution s = new Solution();
            Solution2 s2 = new Solution2();

            Console.WriteLine(s.LongestPalindrome(possiblePalindrome1));
            Console.WriteLine(s2.LongestPalindrome(possiblePalindrome1));

            Console.WriteLine(s.LongestPalindrome(possiblePalindrome2));
            Console.WriteLine(s2.LongestPalindrome(possiblePalindrome2));
        }
    }
}
