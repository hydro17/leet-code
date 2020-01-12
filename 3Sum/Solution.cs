using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3Sum
{
    public class Solution
    {
        private IList<IList<int>> _3itemSubsets = new List<IList<int>>();

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Make3ItemSubsets(new List<int>(), nums);

            return _3itemSubsets.Where(list => list.Sum(i => i) == 0).ToList();
        }

        private void Make3ItemSubsets(IList<int> subset, int[] nums)
        {
            if (subset.Count == 3)
            {
                _3itemSubsets.Add(subset);
                return;
            }

            if (nums.Length == 0) return;

            IList<int> newSubsetPlusNewItem = new List<int>(subset);
            newSubsetPlusNewItem.Add(nums[0]);
            
            IList<int> newSubsetWithoutNewItem = new List<int>(subset);

            int[] numsWithoutOneItem = nums.Where((val, idx) => idx > 0).ToArray();

            Make3ItemSubsets(newSubsetPlusNewItem, numsWithoutOneItem);
            Make3ItemSubsets(newSubsetWithoutNewItem, numsWithoutOneItem);
        }
    }

}
