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

            IList<IList<int>> _3itemSubsetsGivingSum0 = _3itemSubsets.Where(list => list.Sum(i => i) == 0).ToList();

            foreach (List<int> list in _3itemSubsetsGivingSum0)
            {
                list.Sort();
            }

            return RemoveSortedListDuplicates(_3itemSubsetsGivingSum0); ;
        }

        public IList<IList<int>> RemoveSortedListDuplicates(IList<IList<int>> duplicates)
        {
            int idx1 = 0;
            IList<int> indexesToDelete = new List<int>();

            while (idx1 < duplicates.Count - 1)
            {
                for(int idx2 = idx1 + 1; idx2 < duplicates.Count; idx2++)
                {
                    if (duplicates[idx1].SequenceEqual(duplicates[idx2])) indexesToDelete.Add(idx2);
                }

                IEnumerable<int> revIndexesToDelete = indexesToDelete.Reverse();

                foreach(int idx in revIndexesToDelete)
                {
                    duplicates.RemoveAt(idx);
                }

                indexesToDelete.Clear();
                idx1++;
            }

            return duplicates;
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
