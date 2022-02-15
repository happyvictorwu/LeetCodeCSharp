using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_0001;
using System;
using System.Collections.Generic;

namespace Test_LeetCode_0001
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void Test_TwoSum()
        {
            int[] nums = GetRandomArray();
            int target = new Random().Next(-10, 11);

            for (int i = 0; i < 1000; i++)
            {
                var sol2 = new Solution2();
                var sol3 = new Solution3();
                int[] expected = sol2.TwoSum(nums, target);
                int[] actual = sol3.TwoSum(nums, target);
                Array.Sort(expected);
                Array.Sort(actual);
                string expectedString = String.Join(",", expected);
                string actualString = String.Join(",", actual);
                if (expectedString == "-1,-1" && actualString == "-1,-1")
                {
                    i--;
                }
                Assert.AreEqual(expectedString, actualString, $"\nnums: [{String.Join(",", nums)}]\nexpected: [{expectedString}] \n actual: [{actualString}]\n");
            }
        }

        private int[] GetRandomArray()
        {
            Random random = new Random();
            int lenOfArray = random.Next(2, 11);
            int[] result = new int[lenOfArray];
            for (int i = 0; i < lenOfArray; i++)
            {
                result[i] = random.Next(-10, 11);
            }
            return result;
        }
    }
}