using System;
using System.Collections.Generic;
using System.Linq;

namespace _3Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IList<int>> subsets = new Solution().ThreeSum(new[] { 1, 2, 0, -2, 3, 4, -1 });

            foreach (List<int> intList in subsets)
            {
                string subset = "";

                foreach (int i in intList)
                {
                    subset += String.Format($"{i},");
                    //Console.Write($"{i},");
                }

                Console.WriteLine(subset.Substring(0, subset.Length - 1));
            }

            //List<int> l1 = new List<int>(new[] {1, 2, 3}).
            //List<int> l2 = new List<int>(new[] {1, 2, 3});
            //List<int> l3 = new List<int>(new[] {1, 3, 2});

            //Console.WriteLine(l1.Equals(l2));
            //Console.WriteLine(l1.SequenceEqual(l2));
            //l3.Sort();
            //Console.WriteLine(l1.SequenceEqual(l3));
        }
    }
}
