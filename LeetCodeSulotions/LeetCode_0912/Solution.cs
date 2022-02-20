using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_0912
{
    /// <summary>
    /// 快速排序
    /// </summary>
    public class Solution
    {
        public int[] SortArray(int[] nums)
        {
            QuickSort(nums, 0, nums.Length - 1);
            return nums;
        }

        private void QuickSort(int[] nums, int l, int r)
        {
            if (l >= r) return;
            int p = Partition(nums, l, r);
            QuickSort(nums, l, p);
            QuickSort(nums, p + 1, r);
        }

        private int Partition(int[] nums, int l, int r)
        {
            int x = nums[l + r >> 1];
            int i = l - 1, j = r + 1;
            while (i < j)
            {
                do ++i; while (nums[i] < x);
                do --j; while (nums[j] > x);
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
