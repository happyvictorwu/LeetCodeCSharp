// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var sol = new LeetCode_0001.Solution3();
int[] nums = { 2, 7, 11, 15 };
int target = 9;
var res = sol.TwoSum(nums, target);
Console.WriteLine("[" + String.Join(",", res) + "]");