using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_0215
{
    /// <summary>
    /// 快速排序
    /// </summary>
    public class Solution2
    {
        public int FindKthLargest(int[] nums, int k)
        {
            //var minHeap = new SortedSet<(int, int)>(Comparer<(int, int)>.Create((x, y) =>
            //{
            //    int comparisonResult = x.Item1.CompareTo(y.Item1);
            //    return comparisonResult == 0 ? x.Item2.CompareTo(y.Item2) : comparisonResult;
            //}));

            var minHeap = new SortedSet<(int, int)>();

            for (int i = 0; i < nums.Length; i++)
            {
                minHeap.Add((nums[i], i));
                if (minHeap.Count > k) minHeap.Remove(minHeap.Min);
            }

            return minHeap.Min.Item1;
        }
    }
}
