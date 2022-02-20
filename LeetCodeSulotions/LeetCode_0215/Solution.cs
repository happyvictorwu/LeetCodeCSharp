using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_0215
{
    /// <summary>
    /// 快速排序
    /// </summary>
    public class Solution
    {
        public int FindKthLargest(int[] nums, int k)
        {
            return QuickSort(nums, 0, nums.Length - 1, k);
        }

        private int QuickSort(int[] nums, int l, int r, int k)
        {
            if (l == r) return nums[l];

            int p = Partitioner(nums, l, r);
            int leftNum = p - l + 1;
            if (leftNum >= k) return QuickSort(nums, l, p, k);
            return QuickSort(nums, p + 1, r, k - leftNum);
        }

        private int Partitioner(int[] nums, int l, int r)
        {
            int x = nums[l + r >> 1];
            int i = l - 1, j = r + 1;
            while (i < j)
            {
                do i++; while (nums[i] > x);
                do j--; while (nums[j] < x);
                if (i < j) Swap(ref nums[i], ref nums[j]);
            }
            return j;
        }

        private void Swap(ref int v1, ref int v2)
        {
            int t = v1;
            v1 = v2;
            v2 = t;
        }
    }
}
