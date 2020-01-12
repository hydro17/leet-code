using System;
using System.Collections.Generic;

namespace _3Sum
{
    class Program
    {
        static void Main(string[] args)
        {
           IList<IList<int>> subsets = new Solution().ThreeSum(new[] { 1, 2, 0, -2, 3 , 4, -1});

            foreach (List<int> intList in subsets)
            {
                foreach (int i in intList)
                {
                    Console.Write($"{i},");
                }

                Console.WriteLine();
            }
        }
    }
}
