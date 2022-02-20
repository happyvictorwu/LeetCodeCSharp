using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_0001
{
    public class Solution3
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                if (dict.ContainsKey(num))
                {
                    return new int[] { i, dict[num] };
                }
                dict[target - num] = i;
            }
            return new int[] { -1, -1 };
        }
    }
}
